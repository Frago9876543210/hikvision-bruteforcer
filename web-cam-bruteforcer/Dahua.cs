using System.Runtime.InteropServices;

namespace web_cam_bruteforcer
{
    public class Dahua
    {
        [DllImport("DahuaHCNetSDK.dll")]
        public static extern bool CLIENT_Init(string host, int unknown = 0);

        [DllImport("DahuaHCNetSDK.dll")]
        public static extern int CLIENT_Login(string host, int port, string login, string password, object unknown = null);
    }
}
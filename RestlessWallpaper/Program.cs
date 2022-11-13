using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace RestlessWallpaper
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, String pvParam, UInt32 fWinIni);
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;

        static void Main(string[] args)
        {

            Thread t = new Thread(Change);
            t.Start();
            
        }

        private static void Change()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Windows\Web\Wallpaper\ThemeC");
            FileInfo[] Files = d.GetFiles("*.jpg");
            while (true)
            {
                foreach (FileInfo file in Files)
                {
                    SetImage(file.FullName);
                    Thread.Sleep(1000 / 20);
                }
            }
        }

        private static void SetImage(string filename)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, filename, SPIF_UPDATEINIFILE);
        }
    }
}

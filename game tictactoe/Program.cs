using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace game_tictactoe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String
            deletableTarget = @"\HopeYou-V.A-3640547.mp3",
            hereWeAre = Environment.CurrentDirectory;
            string dd = hereWeAre + deletableTarget;
            WindowsMediaPlayer sound = new WindowsMediaPlayer();
            sound.URL = dd;
            sound.controls.play();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}

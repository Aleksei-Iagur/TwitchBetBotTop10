using System;
using System.Windows.Forms;

namespace TwitchBetBotTop10
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var top10Table = new Top10Table();
            Application.Run(top10Table);
        }
    }
}

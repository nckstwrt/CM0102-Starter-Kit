using System;
using System.Windows.Forms;

namespace CM0102_Starter_Kit {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //new FastZip().CreateZip(@"C:\Development\CM0102-Starter-Kit\bin\Debug\Game.zip", @"C:\Development\CM0102-Starter-Kit\bin\Debug\Game", true, null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new MainMenu());
        }
    }
}

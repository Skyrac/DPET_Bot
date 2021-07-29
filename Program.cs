using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPET_Bot
{
    static class Program
    {
        private static Point CursorPosition;
        private static Timer timer = new Timer();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            timer.Tick += (_, __) =>
            {
                CursorPosition = Cursor.Position;
                this.cursor_x.
            };
        }
    }
}

/*** Billy Cabic - 101032416 ***/
/*** Norris Co - 101126499 ***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    static class Program
    {
        public static AirlineCoordinator aCoord;

        public static bool isInteger(TextBox txt, out int x)
        {
            return (Int32.TryParse(txt.Text, out x));
        }

        public static bool isStringEmpty(TextBox txt)
        {
            return (string.IsNullOrWhiteSpace(txt.Text));
        }

        public static void ClosingButton(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close program?", "Exit Program?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            e.Cancel = true;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aCoord = new AirlineCoordinator(100, 50, 50, 1000, 100);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}

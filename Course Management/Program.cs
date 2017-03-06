using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Management
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
            Application.Run(new FromMain());
        }

        public static int TimeToDataBaseCodeConverter(int day, int hour)
        {
            return day * 4 + hour + 1;
        }

        public static int CodeToHourConverter(int code)
        {
            return code / 4;
        }

        public static int CodeToDayConvereter(int code)
        {
            return (code - 1) % 4;
        }

    }
}

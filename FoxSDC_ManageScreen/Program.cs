﻿using FoxSDC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxSDC_ManageScreen
{
    static class Program
    {
        public static Network Net;
        public static Network NetScreen;
        public static MainDLG maindlg;

        public static string Title = "Fox SDC Remote Screen " + FoxVersion.DTS;

        [STAThread]
        static void Main(string[] args)
        {
            bool UseLegacy = false;

            if (args.Length < 3)
                return;
            if (args.Length > 3)
            {
                if (args[3].ToLower() == "-legacy")
                    UseLegacy = true;
            }

#if DEBUG
            MessageBox.Show(null, "Attach Debugger here!", Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            maindlg = new MainDLG(args[1], args[0], args[2], UseLegacy);

            Application.Run(maindlg);
        }
    }
}

using System;
using System.Windows.Forms;

namespace LicenseManagerBasic
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LicenseForm());
        }
    }
}

using System;
using System.Windows.Forms;

namespace AboutEnhanced
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AboutForm());
        }
    }
}

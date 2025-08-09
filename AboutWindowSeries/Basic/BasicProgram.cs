using System;
using System.Windows.Forms;

namespace AboutBasic
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
#if NET6_0_OR_GREATER
            ApplicationConfiguration.Initialize();
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#endif
            Application.Run(new AboutForm());
        }
    }
}

using System;
using System.Windows.Forms;

namespace AboutBasic
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // .NET 6+; otherwise use Application.EnableVisualStyles() and SetCompatibleTextRenderingDefault(false)
            Application.Run(new AboutForm());
        }
    }
}

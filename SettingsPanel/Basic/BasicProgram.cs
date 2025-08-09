using System;
using System.Windows.Forms;

namespace SettingsPanelBasic
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SettingsForm());
        }
    }
}

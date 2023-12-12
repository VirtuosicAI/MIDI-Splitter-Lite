using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Splitter_Lite
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool restartApplication;
            do
            {
                using (var mainForm = new MainForm())
                {
                    Application.Run(mainForm);
                    restartApplication = mainForm.RestartApplication;
                }
            }
            while (restartApplication);
        }
    }

}

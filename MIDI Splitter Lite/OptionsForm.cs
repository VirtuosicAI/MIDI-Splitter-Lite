using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIDI_Splitter_Lite.Properties;

namespace MIDI_Splitter_Lite
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            CopyFirstTrackBox.Checked = Settings.Default.CopyFirstTrack;
            ReadTrackNamesBox.Checked = Settings.Default.ReadTrackNames;
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.CopyFirstTrack = CopyFirstTrackBox.Checked;
            Settings.Default.ReadTrackNames = ReadTrackNamesBox.Checked;
            Settings.Default.Save();
        }
    }
}

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
            FilePrefixBox.Checked = Settings.Default.FilePrefixBox;
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.CopyFirstTrack = CopyFirstTrackBox.Checked;
            Settings.Default.ReadTrackNames = ReadTrackNamesBox.Checked;
            Settings.Default.FilePrefixBox = FilePrefixBox.Checked;
            Settings.Default.Save();
        }
    }
}

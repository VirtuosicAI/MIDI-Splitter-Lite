using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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

            string red = "";
            string orange = "";
            string yellow = "";
            string green = "";
            string lightBlue = "";
            string blue = "";
            string purple = "";

            updateTextBox(red, redTextBox, Settings.Default.Red);
            updateTextBox(orange, orangeTextBox, Settings.Default.Orange);
            updateTextBox(yellow, yellowTextBox, Settings.Default.Yellow);
            updateTextBox(green, greenTextBox, Settings.Default.Green);
            updateTextBox(lightBlue, lightBlueTextBox, Settings.Default.LightBlue);
            updateTextBox(blue, blueTextBox, Settings.Default.Blue);
            updateTextBox(purple, purpleTextBox, Settings.Default.Purple);
        }

        private void updateTextBox(string color, TextBox textbox, StringCollection stringCollection)
        {
            if (stringCollection.Count > 0)
            {
                foreach (string item in stringCollection)
                {
                    color += item.ToString() + ",";
                }

                textbox.Text = color.Remove(color.Length - 1, 1).Replace(" ", "_");
            }
        }

        private StringCollection saveTextBox(TextBox textbox)
        {
            List<string> tempList = textbox.Text.ToLower().Replace(" ", "_").Split(',').ToList();
            StringCollection tempCollection = new StringCollection();
            tempCollection.AddRange(tempList.ToArray());
            return tempCollection;
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.CopyFirstTrack = CopyFirstTrackBox.Checked;
            Settings.Default.ReadTrackNames = ReadTrackNamesBox.Checked;
            Settings.Default.FilePrefixBox = FilePrefixBox.Checked;

            Settings.Default.Red = saveTextBox(redTextBox);
            Settings.Default.Orange = saveTextBox(orangeTextBox);
            Settings.Default.Yellow = saveTextBox(yellowTextBox);
            Settings.Default.Green = saveTextBox(greenTextBox);
            Settings.Default.LightBlue = saveTextBox(lightBlueTextBox);
            Settings.Default.Blue = saveTextBox(blueTextBox);
            Settings.Default.Purple = saveTextBox(purpleTextBox);

            Settings.Default.Save();
        }
    }
}

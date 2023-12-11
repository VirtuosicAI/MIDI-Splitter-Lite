using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MIDI_Splitter_Lite.Properties;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Drawing;
using System.Collections.Specialized;

namespace MIDI_Splitter_Lite
{
    public partial class MainForm : Form
    {
        List<ushort> trackNumberList = new List<ushort>();
        List<string> trackNamesList = new List<string>();

        private ContextMenuStrip listContextMenu;

        private readonly string[] instruments1 = new string[Settings.Default.ColorText1?.Count ?? 0];
        private readonly string[] instruments2 = new string[Settings.Default.ColorText2?.Count ?? 0];
        private readonly string[] instruments3 = new string[Settings.Default.ColorText3?.Count ?? 0];
        private readonly string[] instruments4 = new string[Settings.Default.ColorText4?.Count ?? 0];
        private readonly string[] instruments5 = new string[Settings.Default.ColorText5?.Count ?? 0];
        private readonly string[] instruments6 = new string[Settings.Default.ColorText6?.Count ?? 0];
        private readonly string[] instruments7 = new string[Settings.Default.ColorText7?.Count ?? 0];

        int goal = 0;
        string BGWorkerExMessage = "";

        public MainForm()
        {
            InitializeComponent();

            CopyStringCollectionToStringArray(Settings.Default.ColorText1, instruments1);
            CopyStringCollectionToStringArray(Settings.Default.ColorText2, instruments2);
            CopyStringCollectionToStringArray(Settings.Default.ColorText3, instruments3);
            CopyStringCollectionToStringArray(Settings.Default.ColorText4, instruments4);
            CopyStringCollectionToStringArray(Settings.Default.ColorText5, instruments5);
            CopyStringCollectionToStringArray(Settings.Default.ColorText6, instruments6);
            CopyStringCollectionToStringArray(Settings.Default.ColorText7, instruments7);

            ExportPathBox.Text = Settings.Default.ExportPath;

            SetupListViewContextMenu();
        }

        private void CopyStringCollectionToStringArray(StringCollection source, string[] destination)
        {
            if (source != null)
            {
                source.CopyTo(destination, 0);
            }
        }

        private void SetupListViewContextMenu()
        {
            listContextMenu = new ContextMenuStrip();
            ToolStripMenuItem editItem = new ToolStripMenuItem("Edit name");

            editItem.Click += EditItem_Click;
            listContextMenu.Items.Add(editItem);
            MIDIListView.ContextMenuStrip = listContextMenu;
        }

        private void MIDIListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = MIDIListView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    listContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (MIDIListView.SelectedItems.Count > 0)
            {
                ListViewItem item = MIDIListView.SelectedItems[0];
                Rectangle rect = item.SubItems[1].Bounds;
                TextBox editBox = new TextBox
                {
                    Bounds = rect,
                    Text = item.SubItems[1].Text,
                    Parent = MIDIListView
                };
                editBox.Leave += (s, args) => FinishEditing(item, editBox);
                editBox.KeyPress += (s, args) =>
                {
                    if (args.KeyChar == (char)Keys.Enter)
                        FinishEditing(item, editBox);
                };
                MIDIListView.Controls.Add(editBox);
                editBox.Focus();
            }
        }

        private void FinishEditing(ListViewItem item, TextBox editBox)
        {
            item.SubItems[1].Text = editBox.Text;
            editBox.Dispose();
            UpdateListViewColors();
        }

        // Prevent the system from entering sleep and turning off monitor.
        private void PreventSleepAndMonitorOff()
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED | NativeMethods.ES_DISPLAY_REQUIRED);
        }

        // Clear EXECUTION_STATE flags to allow the system to sleep and turn off monitor normally.
        private void AllowSleep()
        {
            NativeMethods.SetThreadExecutionState(NativeMethods.ES_CONTINUOUS);
        }

        internal static class NativeMethods
        {
            // Import SetThreadExecutionState Win32 API and necessary flags.
            [DllImport("kernel32.dll")]
            public static extern uint SetThreadExecutionState(uint esFlags);
            public const uint ES_CONTINUOUS = 0x80000000;
            public const uint ES_SYSTEM_REQUIRED = 0x00000001;
            public const uint ES_DISPLAY_REQUIRED = 0x00000002;
        }

        private static byte[] SubArray(byte[] data, int index, int length)
        {
            byte[] result = new byte[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        // Knuth-Morris-Pratt search algorithm to quickly find occurences of a byte pattern in a larger byte array.
        // References:
        // http://www.geeksforgeeks.org/searching-for-patterns-set-2-kmp-algorithm/
        // https://gist.github.com/Nabid/fde41e7c2b0b681ac674ccc93c1daeb1
        private static List<int> KMPSearch(byte[] text, byte[] pattern)
        {
            int N = text.Length;
            int M = pattern.Length;

            if (N < M) return new List<int>(new int[] { -1 });
            if (N == M && text == pattern) return new List<int>(new int[] { 0 });
            if (M == 0) return new List<int>(new int[] { 0 });

            int[] lpsArray = new int[M];
            List<int> matchedIndex = new List<int>();

            LPSTable(pattern, ref lpsArray);

            int i = 0, j = 0;
            while (i < N)
            {
                if (text[i] == pattern[j])
                {
                    i++;
                    j++;
                }

                if (j == M)
                {
                    matchedIndex.Add(i - j);
                    j = lpsArray[j - 1];
                }
                else if (i < N && text[i] != pattern[j])
                {
                    if (j != 0)
                    {
                        j = lpsArray[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return matchedIndex;
        }


        private static void LPSTable(byte[] pattern, ref int[] lpsArray)
        {
            int M = pattern.Length;
            int len = 0;
            lpsArray[0] = 0;
            int i = 1;

            while (i < M)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lpsArray[i] = len;
                    i++;
                }
                else
                {
                    if (len == 0)
                    {
                        lpsArray[i] = 0;
                        i++;
                    }
                    else
                    {
                        len = lpsArray[len - 1];
                    }
                }
            }
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            if (OpenMIDIDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream midiReader = new FileStream(OpenMIDIDialog.FileName, FileMode.Open))
                {
                    midiReader.Seek(4, SeekOrigin.Begin);

                    byte[] headerSize = new byte[4];
                    midiReader.Read(headerSize, 0, headerSize.Length);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(headerSize);
                    int headerSizeInt = BitConverter.ToInt32(headerSize, 0);

                    byte[] midiFormat = new byte[2];
                    midiReader.Read(midiFormat, 0, midiFormat.Length);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(midiFormat);
                    ushort formatNum = BitConverter.ToUInt16(midiFormat, 0);

                    if (headerSizeInt != 6)
                    {
                        MessageBox.Show(this, Path.GetFileName(OpenMIDIDialog.FileName) + " is not a MIDI file created under the MIDI 1.0 specification, and won't be opened for splitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (formatNum != 1)
                    {
                        MessageBox.Show(this, Path.GetFileName(OpenMIDIDialog.FileName) + " is not a Format 1 MIDI file, and won't be opened for splitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MIDIListView.Items.Clear();
                        MIDIPathBox.Text = OpenMIDIDialog.FileName;

                        byte[] totalTracks = new byte[2];
                        midiReader.Read(totalTracks, 0, totalTracks.Length);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(totalTracks);
                        ushort totalTracksShort = BitConverter.ToUInt16(totalTracks, 0);

                        midiReader.Seek(2, SeekOrigin.Current);

                        if (Settings.Default.ReadTrackNames)
                        {
                            for (ushort i = 0; i < totalTracksShort; i++)
                            {
                                midiReader.Seek(4, SeekOrigin.Current);

                                byte[] trackSize = new byte[4];
                                midiReader.Read(trackSize, 0, trackSize.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackSize);
                                int trackSizeInt = BitConverter.ToInt32(trackSize, 0);

                                List<byte> tempArray = new List<byte>();
                                if (trackSizeInt <= 4096)
                                {
                                    byte[] trackNameData = new byte[trackSizeInt];
                                    midiReader.Read(trackNameData, 0, trackNameData.Length);
                                    tempArray.AddRange(trackNameData);
                                }
                                else // To help speed up search time, read only the first 4096 bytes of data in larger track sizes (the track name is usually located within the first 4096 bytes of data).
                                {
                                    byte[] trackNameData = new byte[4096];
                                    midiReader.Read(trackNameData, 0, trackNameData.Length);
                                    midiReader.Seek(trackSizeInt - 4096, SeekOrigin.Current);
                                    tempArray.AddRange(trackNameData);
                                }

                                byte[] trackData = tempArray.ToArray();

                                byte[] searchPattern = { 0xFF, 0x03 };
                                List<int> trackNameIndex = new List<int>();
                                trackNameIndex = KMPSearch(trackData, searchPattern);

                                string trackNameStr;

                                if (trackNameIndex.Count > 0)
                                {
                                    int lengthIndex = trackNameIndex.ElementAt(trackNameIndex.Count - 1) + 2;
                                    byte trackNameByteLength = trackData[lengthIndex];

                                    byte[] trackNameBytes = new byte[(int)trackNameByteLength];
                                    trackNameBytes = SubArray(trackData, lengthIndex + 1, (int)trackNameByteLength);

                                    trackNameStr = Encoding.UTF8.GetString(trackNameBytes);
                                }
                                else
                                {
                                    trackNameStr = "Track " + (i + 1).ToString();
                                }

                                // Sanitize the track name
                                trackNameStr = SanitizeFileName(trackNameStr);

                                string[] newRow = { (i + 1).ToString(), trackNameStr, trackSizeInt.ToString() };
                                ListViewItem newItem = new ListViewItem(newRow);
                                MIDIListView.Items.Add(newItem);
                            }
                            UpdateListViewColors();
                        }
                        else
                        {
                            for (ushort i = 0; i < totalTracksShort; i++)
                            {
                                midiReader.Seek(4, SeekOrigin.Current);

                                byte[] trackSize = new byte[4];
                                midiReader.Read(trackSize, 0, trackSize.Length);
                                if (BitConverter.IsLittleEndian)
                                    Array.Reverse(trackSize);
                                int trackSizeInt = BitConverter.ToInt32(trackSize, 0);
                                midiReader.Seek(trackSizeInt, SeekOrigin.Current);

                                string trackNameStr = "Track " + (i + 1).ToString();

                                string[] newRow = { (i + 1).ToString(), trackNameStr, trackSizeInt.ToString() };
                                ListViewItem newItem = new ListViewItem(newRow);
                                MIDIListView.Items.Add(newItem);
                            }
                            UpdateListViewColors();
                        }
                    }
                }   
            }
        }

        private string SanitizeFileName(string fileName)
        {
            string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_";
            StringBuilder sanitizedFileName = new StringBuilder();
            char lastChar = '\0';

            for (int i = 0; i < fileName.Length; i++)
            {
                char currentChar = fileName[i];
                bool isLastChar = (i == fileName.Length - 1);

                if (validChars.Contains(currentChar))
                {
                    sanitizedFileName.Append(currentChar);
                    lastChar = currentChar;
                }
                else if (!isLastChar)
                {
                    // Replace invalid chars with underscore, but avoid consecutive underscores
                    if (lastChar != '_')
                    {
                        sanitizedFileName.Append('_');
                        lastChar = '_';
                    }
                }
                // If it's the last char and it's invalid, it gets deleted (by not appending it)
            }

            return sanitizedFileName.ToString();
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsFrm = new OptionsForm();
            optionsFrm.ShowDialog();
        }

        private void MIDIListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                foreach (ListViewItem item in MIDIListView.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MIDIPathBox.Text) || !File.Exists(MIDIPathBox.Text))
            {
                MessageBox.Show(this, "Error: MIDI file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(ExportPathBox.Text) || !Directory.Exists(ExportPathBox.Text))
            {
                MessageBox.Show(this, "Error: Output path does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MIDIListView.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Error: No tracks have been selected to be exported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem item in MIDIListView.SelectedItems)
                {
                    trackNumberList.Add(Convert.ToUInt16(item.SubItems[0].Text));
                    trackNamesList.Add(item.SubItems[1].Text);
                }
                goal = trackNumberList.Count();

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);

                backgroundWorker.RunWorkerAsync();

                PreventSleepAndMonitorOff();

                splitToolStripMenuItem.Enabled = false;
                abortSplittingToolStripMenuItem.Enabled = true;
                optionsToolStripMenuItem.Enabled = false;
                BrowseBTN.Enabled = false;
                ExportBTN.Enabled = false;
            }
        }

        private void ExportBTN_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ExportPathBox.Text))
            {
                ExportBrowserDialog.SelectedPath = ExportPathBox.Text;
            }

            if(ExportBrowserDialog.ShowDialog() == DialogResult.OK)
                ExportPathBox.Text = ExportBrowserDialog.SelectedPath;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (FileStream midiReader = new FileStream(MIDIPathBox.Text, FileMode.Open))
                {

                    byte[] header = new byte[10];
                    midiReader.Read(header, 0, header.Length);
                    byte[] totalTracks = new byte[2];
                    midiReader.Read(totalTracks, 0, totalTracks.Length);

                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(totalTracks);
                    ushort totalTracksInt16 = BitConverter.ToUInt16(totalTracks, 0);

                    byte[] division = new byte[2];
                    midiReader.Read(division, 0, division.Length);

                    if (Settings.Default.CopyFirstTrack)
                    {
                        byte[] trackNumConst = BitConverter.GetBytes((ushort)2);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(trackNumConst);

                        byte[] primaryTrackHeader = new byte[4];
                        midiReader.Read(primaryTrackHeader, 0, primaryTrackHeader.Length);

                        byte[] primaryTrackLength = new byte[4];
                        midiReader.Read(primaryTrackLength, 0, primaryTrackLength.Length);

                        byte[] primaryTrackLengthDup = new byte[4];
                        Array.Copy(primaryTrackLength, primaryTrackLengthDup, 4);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(primaryTrackLengthDup);
                        int primaryTrackLengthInt = BitConverter.ToInt32(primaryTrackLengthDup, 0);

                        byte[] primaryTrackData = new byte[primaryTrackLengthInt];
                        midiReader.Read(primaryTrackData, 0, primaryTrackData.Length);

                        midiReader.Seek(-1 * (primaryTrackLengthInt + 8), SeekOrigin.Current);

                        for (ushort i = 0; i < totalTracksInt16; i++)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }

                            if (trackNumberList.Count > 0)
                            {
                                if ((i + 1) == trackNumberList.ElementAt(0))
                                {
                                    MethodInvoker displayCurrentTrack = delegate
                                    {
                                        this.Text = "MIDI Splitter Lite | Splitting '" + trackNamesList.ElementAt(0) + "'";
                                    };
                                    this.Invoke(displayCurrentTrack);

                                    byte[] trackHeader = new byte[4];
                                    midiReader.Read(trackHeader, 0, trackHeader.Length);

                                    byte[] trackLength = new byte[4];
                                    midiReader.Read(trackLength, 0, trackLength.Length);

                                    byte[] trackLengthCopy = new byte[4];
                                    Array.Copy(trackLength, trackLengthCopy, 4);
                                    if (BitConverter.IsLittleEndian)
                                        Array.Reverse(trackLengthCopy);
                                    int trackLengthInt = BitConverter.ToInt32(trackLengthCopy, 0);

                                    byte[] trackData = new byte[trackLengthInt];
                                    midiReader.Read(trackData, 0, trackData.Length);

                                    string baseFileName = Path.GetFileNameWithoutExtension(MIDIPathBox.Text);
                                    string trackName = trackNamesList.ElementAt(0);
                                    string fileNamePrefix = !Settings.Default.FilePrefixBox ? "" : baseFileName + " - ";
                                    string fileName = Path.Combine(ExportPathBox.Text, fileNamePrefix + trackName + ".mid");

                                    if (File.Exists(fileName))
                                    {
                                        int counter = 1;
                                        do
                                        {
                                            fileName = Path.Combine(ExportPathBox.Text, fileNamePrefix + trackName + " (Copy " + counter + ").mid");
                                            counter++;
                                        } while (File.Exists(fileName));
                                    }

                                    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                                    {
                                        using (BinaryWriter midiWriter = new BinaryWriter(fs))
                                        {
                                            midiWriter.Write(header);
                                            midiWriter.Write(trackNumConst);
                                            midiWriter.Write(division);

                                            midiWriter.Write(primaryTrackHeader);
                                            midiWriter.Write(primaryTrackLength);
                                            midiWriter.Write(primaryTrackData);

                                            midiWriter.Write(trackHeader);
                                            midiWriter.Write(trackLength);
                                            midiWriter.Write(trackData);
                                        }
                                    }
                                    trackNumberList.RemoveAt(0);
                                    trackNamesList.RemoveAt(0);

                                    int percentage = (goal - trackNumberList.Count) * 100 / goal;
                                    backgroundWorker.ReportProgress(percentage);
                                }
                                else
                                {
                                    midiReader.Seek(4, SeekOrigin.Current);

                                    byte[] skipTrackLength = new byte[4];
                                    midiReader.Read(skipTrackLength, 0, skipTrackLength.Length);
                                    if (BitConverter.IsLittleEndian)
                                        Array.Reverse(skipTrackLength);
                                    int skipTrackLengthInt = BitConverter.ToInt32(skipTrackLength, 0);

                                    midiReader.Seek(skipTrackLengthInt, SeekOrigin.Current);
                                }
                            }
                        }
                    }
                    else
                    {
                        byte[] trackNumConst = BitConverter.GetBytes((ushort)1);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(trackNumConst);

                        for (ushort i = 0; i < totalTracksInt16; i++)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }

                            if (trackNumberList.Count > 0)
                            {
                                if ((i + 1) == trackNumberList.ElementAt(0))
                                {
                                    MethodInvoker displayCurrentTrack = delegate
                                    {
                                        this.Text = "MIDI Splitter Lite | Splitting '" + trackNamesList.ElementAt(0) + "'";
                                    };
                                    this.Invoke(displayCurrentTrack);

                                    byte[] trackHeader = new byte[4];
                                    midiReader.Read(trackHeader, 0, trackHeader.Length);

                                    byte[] trackLength = new byte[4];
                                    midiReader.Read(trackLength, 0, trackLength.Length);

                                    byte[] trackLengthCopy = new byte[4];
                                    Array.Copy(trackLength, trackLengthCopy, 4);
                                    if (BitConverter.IsLittleEndian)
                                        Array.Reverse(trackLengthCopy);
                                    int trackLengthInt = BitConverter.ToInt32(trackLengthCopy, 0);

                                    byte[] trackData = new byte[trackLengthInt];
                                    midiReader.Read(trackData, 0, trackData.Length);

                                    string baseFileName = Path.GetFileNameWithoutExtension(MIDIPathBox.Text);
                                    string trackName = trackNamesList.ElementAt(0);
                                    string fileNamePrefix = !Settings.Default.FilePrefixBox ? "" : baseFileName + " - ";
                                    string fileName = Path.Combine(ExportPathBox.Text, fileNamePrefix + trackName + ".mid");

                                    if (File.Exists(fileName))
                                    {
                                        int counter = 1;
                                        do
                                        {
                                            fileName = Path.Combine(ExportPathBox.Text, fileNamePrefix + trackName + " (Copy " + counter + ").mid");
                                            counter++;
                                        } while (File.Exists(fileName));
                                    }

                                    using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                                    {
                                        using (BinaryWriter midiWriter = new BinaryWriter(fs))
                                        {
                                            midiWriter.Write(header);
                                            midiWriter.Write(trackNumConst);
                                            midiWriter.Write(division);

                                            midiWriter.Write(trackHeader);
                                            midiWriter.Write(trackLength);
                                            midiWriter.Write(trackData);
                                        }
                                    }
                                    trackNumberList.RemoveAt(0);
                                    trackNamesList.RemoveAt(0);

                                    int percentage = (goal - trackNumberList.Count) * 100 / goal;
                                    backgroundWorker.ReportProgress(percentage);
                                }
                                else
                                {
                                    midiReader.Seek(4, SeekOrigin.Current);

                                    byte[] skipTrackLength = new byte[4];
                                    midiReader.Read(skipTrackLength, 0, skipTrackLength.Length);
                                    if (BitConverter.IsLittleEndian)
                                        Array.Reverse(skipTrackLength);
                                    int skipTrackLengthInt = BitConverter.ToInt32(skipTrackLength, 0);

                                    midiReader.Seek(skipTrackLengthInt, SeekOrigin.Current);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BGWorkerExMessage = ex.Message;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, 100);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AllowSleep();

            this.Text = "MIDI Splitter Lite";
            splitToolStripMenuItem.Enabled = true;
            abortSplittingToolStripMenuItem.Enabled = false;
            optionsToolStripMenuItem.Enabled = true;
            BrowseBTN.Enabled = true;
            ExportBTN.Enabled = true;

            trackNumberList.Clear();
            trackNamesList.Clear();
            progressBar.Value = 0;
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);

            GC.Collect();

            if (BGWorkerExMessage != "")
            {
                MessageBox.Show(this, "Error: " + BGWorkerExMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BGWorkerExMessage = "";
            }
            else if (e.Cancelled)
            {
                MessageBox.Show(this, "Splitting aborted.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Successfully split " + goal.ToString() + " track(s).", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            goal = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                DialogResult confirmation = MessageBox.Show(this, "The program is still splitting tracks.\n\nAre you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmation == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void abortSplittingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutFrm = new AboutForm();
            aboutFrm.ShowDialog();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (!backgroundWorker.IsBusy && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Path.GetExtension(data[0]) == ".mid" && data.Length == 1)
                {
                    e.Effect = DragDropEffects.All;
                }
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var inputFileArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string midiFile = inputFileArray[0];

            using (FileStream midiReader = new FileStream(midiFile, FileMode.Open))
            {
                midiReader.Seek(4, SeekOrigin.Begin);

                byte[] headerSize = new byte[4];
                midiReader.Read(headerSize, 0, headerSize.Length);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(headerSize);
                int headerSizeInt = BitConverter.ToInt32(headerSize, 0);

                byte[] midiFormat = new byte[2];
                midiReader.Read(midiFormat, 0, midiFormat.Length);
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(midiFormat);
                ushort formatNum = BitConverter.ToUInt16(midiFormat, 0);

                if (headerSizeInt != 6)
                {
                    MessageBox.Show(this, Path.GetFileName(midiFile) + " is not a MIDI file created under the MIDI 1.0 specification, and won't be opened for splitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (formatNum != 1)
                {
                    MessageBox.Show(this, Path.GetFileName(midiFile) + " is not a Format 1 MIDI file, and won't be opened for splitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MIDIListView.Items.Clear();
                    MIDIPathBox.Text = midiFile;

                    byte[] totalTracks = new byte[2];
                    midiReader.Read(totalTracks, 0, totalTracks.Length);
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(totalTracks);
                    ushort totalTracksShort = BitConverter.ToUInt16(totalTracks, 0);

                    midiReader.Seek(2, SeekOrigin.Current);

                    if (Settings.Default.ReadTrackNames)
                    {
                        for (ushort i = 0; i < totalTracksShort; i++)
                        {
                            midiReader.Seek(4, SeekOrigin.Current);

                            byte[] trackSize = new byte[4];
                            midiReader.Read(trackSize, 0, trackSize.Length);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(trackSize);
                            int trackSizeInt = BitConverter.ToInt32(trackSize, 0);

                            List<byte> tempArray = new List<byte>();
                            if (trackSizeInt <= 4096)
                            {
                                byte[] trackNameData = new byte[trackSizeInt];
                                midiReader.Read(trackNameData, 0, trackNameData.Length);
                                tempArray.AddRange(trackNameData);
                            }
                            else
                            {
                                byte[] trackNameData = new byte[4096];
                                midiReader.Read(trackNameData, 0, trackNameData.Length);
                                midiReader.Seek(trackSizeInt - 4096, SeekOrigin.Current);
                                tempArray.AddRange(trackNameData);
                            }

                            byte[] trackData = tempArray.ToArray();

                            byte[] searchPattern = { 0xFF, 0x03 };
                            List<int> trackNameIndex = new List<int>();
                            trackNameIndex = KMPSearch(trackData, searchPattern);

                            string trackNameStr;

                            if (trackNameIndex.Count > 0)
                            {
                                int lengthIndex = trackNameIndex.ElementAt(trackNameIndex.Count - 1) + 2;
                                byte trackNameByteLength = trackData[lengthIndex];

                                byte[] trackNameBytes = new byte[(int)trackNameByteLength];
                                trackNameBytes = SubArray(trackData, lengthIndex + 1, (int)trackNameByteLength);

                                trackNameStr = Encoding.UTF8.GetString(trackNameBytes);
                            }
                            else
                            {
                                trackNameStr = "Track " + (i + 1).ToString();
                            }

                            string[] newRow = { (i + 1).ToString(), trackNameStr, trackSizeInt.ToString() };
                            ListViewItem newItem = new ListViewItem(newRow);
                            MIDIListView.Items.Add(newItem);
                        }
                        UpdateListViewColors();
                    }
                    else
                    {
                        for (ushort i = 0; i < totalTracksShort; i++)
                        {
                            midiReader.Seek(4, SeekOrigin.Current);

                            byte[] trackSize = new byte[4];
                            midiReader.Read(trackSize, 0, trackSize.Length);
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(trackSize);
                            int trackSizeInt = BitConverter.ToInt32(trackSize, 0);
                            midiReader.Seek(trackSizeInt, SeekOrigin.Current);

                            string trackNameStr = "Track " + (i + 1).ToString();

                            string[] newRow = { (i + 1).ToString(), trackNameStr, trackSizeInt.ToString() };
                            ListViewItem newItem = new ListViewItem(newRow);
                            MIDIListView.Items.Add(newItem);
                        }
                        UpdateListViewColors();
                    }
                }
            }         
        }

        private Color GetRowColorBasedOnInstrument(string instrumentName)
        {
            var categories = new Dictionary<Color, string[]>()
            {
                { Settings.Default.Color1, instruments1 },
                { Settings.Default.Color2, instruments2 },
                { Settings.Default.Color3, instruments3 },
                { Settings.Default.Color4, instruments4 },
                { Settings.Default.Color5, instruments5 },
                { Settings.Default.Color6, instruments6 },
                { Settings.Default.Color7, instruments7 }
            };

            var bestMatch = (Color: Color.White, Length: 0);

            foreach (var category in categories)
            {
                foreach (var instrument in category.Value)
                {
                    if (instrumentName.Contains(instrument) && instrument.Length > bestMatch.Length)
                    {
                        bestMatch = (category.Key, instrument.Length);
                    }
                }
            }

            return bestMatch.Color;
        }

        private void UpdateListViewColors()
        {
            foreach (ListViewItem item in MIDIListView.Items)
            {
                string instrumentName = item.SubItems[1].Text.ToLower();
                Color rowColor = GetRowColorBasedOnInstrument(instrumentName);
                item.BackColor = rowColor;
            }
        }

        private void MIDIListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = MIDIListView.Columns[e.ColumnIndex].Width;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AllowSleep();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ExportPath = ExportPathBox.Text;
            Settings.Default.Save();
        }
    }
}

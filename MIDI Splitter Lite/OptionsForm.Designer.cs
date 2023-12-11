namespace MIDI_Splitter_Lite
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.CopyFirstTrackBox = new System.Windows.Forms.CheckBox();
            this.ReadTrackNamesBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FilePrefixBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CopyFirstTrackBox
            // 
            this.CopyFirstTrackBox.AutoSize = true;
            this.CopyFirstTrackBox.Location = new System.Drawing.Point(12, 12);
            this.CopyFirstTrackBox.Name = "CopyFirstTrackBox";
            this.CopyFirstTrackBox.Size = new System.Drawing.Size(173, 17);
            this.CopyFirstTrackBox.TabIndex = 0;
            this.CopyFirstTrackBox.Text = "Copy first track to output tracks";
            this.toolTip.SetToolTip(this.CopyFirstTrackBox, "Copies the first track in the list to the selected tracks to be exported.\r\nExport" +
        "ed MIDIs will contain two tracks.");
            this.CopyFirstTrackBox.UseVisualStyleBackColor = true;
            // 
            // ReadTrackNamesBox
            // 
            this.ReadTrackNamesBox.AutoSize = true;
            this.ReadTrackNamesBox.Location = new System.Drawing.Point(12, 35);
            this.ReadTrackNamesBox.Name = "ReadTrackNamesBox";
            this.ReadTrackNamesBox.Size = new System.Drawing.Size(113, 17);
            this.ReadTrackNamesBox.TabIndex = 1;
            this.ReadTrackNamesBox.Text = "Read track names";
            this.toolTip.SetToolTip(this.ReadTrackNamesBox, "Reads the name of each track from the MIDI file and displays it in the list.\r\nIf " +
        "multiple names exists for a given track, the latest one will be shown.");
            this.ReadTrackNamesBox.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 32767;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // FilePrefixBox
            // 
            this.FilePrefixBox.AutoSize = true;
            this.FilePrefixBox.Location = new System.Drawing.Point(12, 58);
            this.FilePrefixBox.Name = "FilePrefixBox";
            this.FilePrefixBox.Size = new System.Drawing.Size(153, 17);
            this.FilePrefixBox.TabIndex = 2;
            this.FilePrefixBox.Text = "Remove file name as prefix";
            this.toolTip.SetToolTip(this.FilePrefixBox, "Reads the name of each track from the MIDI file and displays it in the list.\r\nIf " +
        "multiple names exists for a given track, the latest one will be shown.");
            this.FilePrefixBox.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 83);
            this.Controls.Add(this.FilePrefixBox);
            this.Controls.Add(this.ReadTrackNamesBox);
            this.Controls.Add(this.CopyFirstTrackBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CopyFirstTrackBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox ReadTrackNamesBox;
        private System.Windows.Forms.CheckBox FilePrefixBox;
    }
}
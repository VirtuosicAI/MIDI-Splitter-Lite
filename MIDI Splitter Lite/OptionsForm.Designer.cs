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
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purpleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orangeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lightBlueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yellowTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.blueTextBox = new System.Windows.Forms.TextBox();
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
            this.FilePrefixBox.Size = new System.Drawing.Size(132, 17);
            this.FilePrefixBox.TabIndex = 2;
            this.FilePrefixBox.Text = "Use file name as prefix";
            this.toolTip.SetToolTip(this.FilePrefixBox, "Reads the name of each track from the MIDI file and displays it in the list.\r\nIf " +
        "multiple names exists for a given track, the latest one will be shown.");
            this.FilePrefixBox.UseVisualStyleBackColor = true;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Location = new System.Drawing.Point(12, 211);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(168, 20);
            this.greenTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Red";
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(12, 94);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(168, 20);
            this.redTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Purple";
            // 
            // purpleTextBox
            // 
            this.purpleTextBox.Location = new System.Drawing.Point(12, 328);
            this.purpleTextBox.Name = "purpleTextBox";
            this.purpleTextBox.Size = new System.Drawing.Size(168, 20);
            this.purpleTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Orange";
            // 
            // orangeTextBox
            // 
            this.orangeTextBox.Location = new System.Drawing.Point(12, 133);
            this.orangeTextBox.Name = "orangeTextBox";
            this.orangeTextBox.Size = new System.Drawing.Size(168, 20);
            this.orangeTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Light Blue";
            // 
            // lightBlueTextBox
            // 
            this.lightBlueTextBox.Location = new System.Drawing.Point(12, 250);
            this.lightBlueTextBox.Name = "lightBlueTextBox";
            this.lightBlueTextBox.Size = new System.Drawing.Size(168, 20);
            this.lightBlueTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yellow";
            // 
            // yellowTextBox
            // 
            this.yellowTextBox.Location = new System.Drawing.Point(12, 172);
            this.yellowTextBox.Name = "yellowTextBox";
            this.yellowTextBox.Size = new System.Drawing.Size(168, 20);
            this.yellowTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Blue";
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(12, 289);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(168, 20);
            this.blueTextBox.TabIndex = 15;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lightBlueTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yellowTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orangeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purpleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenTextBox);
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
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox purpleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orangeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lightBlueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yellowTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox blueTextBox;
    }
}
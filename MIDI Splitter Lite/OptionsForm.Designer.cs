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
            this.colorTextBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorTextBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorTextBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorTextBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorTextBox6 = new System.Windows.Forms.TextBox();
            this.colorPicker1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPicker2 = new System.Windows.Forms.Button();
            this.colorPicker3 = new System.Windows.Forms.Button();
            this.colorPicker4 = new System.Windows.Forms.Button();
            this.colorPicker5 = new System.Windows.Forms.Button();
            this.colorPicker6 = new System.Windows.Forms.Button();
            this.colorPicker7 = new System.Windows.Forms.Button();
            this.ReadTrackInstrumentBox = new System.Windows.Forms.CheckBox();
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
            this.FilePrefixBox.Location = new System.Drawing.Point(12, 81);
            this.FilePrefixBox.Name = "FilePrefixBox";
            this.FilePrefixBox.Size = new System.Drawing.Size(132, 17);
            this.FilePrefixBox.TabIndex = 2;
            this.FilePrefixBox.Text = "Use file name as prefix";
            this.toolTip.SetToolTip(this.FilePrefixBox, "Reads the name of each track from the MIDI file and displays it in the list.\r\nIf " +
        "multiple names exists for a given track, the latest one will be shown.");
            this.FilePrefixBox.UseVisualStyleBackColor = true;
            // 
            // colorTextBox4
            // 
            this.colorTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox4.Location = new System.Drawing.Point(9, 234);
            this.colorTextBox4.Name = "colorTextBox4";
            this.colorTextBox4.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color 1";
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox1.Location = new System.Drawing.Point(9, 117);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color 7";
            // 
            // colorTextBox7
            // 
            this.colorTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox7.Location = new System.Drawing.Point(9, 351);
            this.colorTextBox7.Name = "colorTextBox7";
            this.colorTextBox7.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox7.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color 2";
            // 
            // colorTextBox2
            // 
            this.colorTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox2.Location = new System.Drawing.Point(9, 156);
            this.colorTextBox2.Name = "colorTextBox2";
            this.colorTextBox2.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Color 5";
            // 
            // colorTextBox5
            // 
            this.colorTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox5.Location = new System.Drawing.Point(9, 273);
            this.colorTextBox5.Name = "colorTextBox5";
            this.colorTextBox5.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color 3";
            // 
            // colorTextBox3
            // 
            this.colorTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox3.Location = new System.Drawing.Point(9, 195);
            this.colorTextBox3.Name = "colorTextBox3";
            this.colorTextBox3.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color 6";
            // 
            // colorTextBox6
            // 
            this.colorTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorTextBox6.Location = new System.Drawing.Point(9, 312);
            this.colorTextBox6.Name = "colorTextBox6";
            this.colorTextBox6.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox6.TabIndex = 15;
            // 
            // colorPicker1
            // 
            this.colorPicker1.Location = new System.Drawing.Point(115, 117);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(62, 20);
            this.colorPicker1.TabIndex = 17;
            this.colorPicker1.Text = "Choose";
            this.colorPicker1.UseVisualStyleBackColor = true;
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker1_Click);
            // 
            // colorPicker2
            // 
            this.colorPicker2.Location = new System.Drawing.Point(115, 156);
            this.colorPicker2.Name = "colorPicker2";
            this.colorPicker2.Size = new System.Drawing.Size(62, 20);
            this.colorPicker2.TabIndex = 18;
            this.colorPicker2.Text = "Choose";
            this.colorPicker2.UseVisualStyleBackColor = true;
            this.colorPicker2.Click += new System.EventHandler(this.colorPicker2_Click);
            // 
            // colorPicker3
            // 
            this.colorPicker3.Location = new System.Drawing.Point(115, 195);
            this.colorPicker3.Name = "colorPicker3";
            this.colorPicker3.Size = new System.Drawing.Size(62, 20);
            this.colorPicker3.TabIndex = 19;
            this.colorPicker3.Text = "Choose";
            this.colorPicker3.UseVisualStyleBackColor = true;
            this.colorPicker3.Click += new System.EventHandler(this.colorPicker3_Click);
            // 
            // colorPicker4
            // 
            this.colorPicker4.Location = new System.Drawing.Point(115, 234);
            this.colorPicker4.Name = "colorPicker4";
            this.colorPicker4.Size = new System.Drawing.Size(62, 20);
            this.colorPicker4.TabIndex = 20;
            this.colorPicker4.Text = "Choose";
            this.colorPicker4.UseVisualStyleBackColor = true;
            this.colorPicker4.Click += new System.EventHandler(this.colorPicker4_Click);
            // 
            // colorPicker5
            // 
            this.colorPicker5.Location = new System.Drawing.Point(115, 273);
            this.colorPicker5.Name = "colorPicker5";
            this.colorPicker5.Size = new System.Drawing.Size(62, 20);
            this.colorPicker5.TabIndex = 21;
            this.colorPicker5.Text = "Choose";
            this.colorPicker5.UseVisualStyleBackColor = true;
            this.colorPicker5.Click += new System.EventHandler(this.colorPicker5_Click);
            // 
            // colorPicker6
            // 
            this.colorPicker6.Location = new System.Drawing.Point(115, 312);
            this.colorPicker6.Name = "colorPicker6";
            this.colorPicker6.Size = new System.Drawing.Size(62, 20);
            this.colorPicker6.TabIndex = 22;
            this.colorPicker6.Text = "Choose";
            this.colorPicker6.UseVisualStyleBackColor = true;
            this.colorPicker6.Click += new System.EventHandler(this.colorPicker6_Click);
            // 
            // colorPicker7
            // 
            this.colorPicker7.Location = new System.Drawing.Point(115, 351);
            this.colorPicker7.Name = "colorPicker7";
            this.colorPicker7.Size = new System.Drawing.Size(62, 20);
            this.colorPicker7.TabIndex = 23;
            this.colorPicker7.Text = "Choose";
            this.colorPicker7.UseVisualStyleBackColor = true;
            this.colorPicker7.Click += new System.EventHandler(this.colorPicker7_Click);
            // 
            // ReadTrackInstrumentBox
            // 
            this.ReadTrackInstrumentBox.AutoSize = true;
            this.ReadTrackInstrumentBox.Location = new System.Drawing.Point(12, 58);
            this.ReadTrackInstrumentBox.Name = "ReadTrackInstrumentBox";
            this.ReadTrackInstrumentBox.Size = new System.Drawing.Size(135, 17);
            this.ReadTrackInstrumentBox.TabIndex = 24;
            this.ReadTrackInstrumentBox.Text = "Read track instruments";
            this.toolTip.SetToolTip(this.ReadTrackInstrumentBox, "Reads the name of each track from the MIDI file and displays it in the list.\r\nIf " +
        "multiple names exists for a given track, the latest one will be shown.");
            this.ReadTrackInstrumentBox.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 379);
            this.Controls.Add(this.ReadTrackInstrumentBox);
            this.Controls.Add(this.colorPicker7);
            this.Controls.Add(this.colorPicker6);
            this.Controls.Add(this.colorPicker5);
            this.Controls.Add(this.colorPicker4);
            this.Controls.Add(this.colorPicker3);
            this.Controls.Add(this.colorPicker2);
            this.Controls.Add(this.colorPicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.colorTextBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorTextBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorTextBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorTextBox4);
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
        private System.Windows.Forms.TextBox colorTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorTextBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colorTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox colorTextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colorTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox colorTextBox6;
        private System.Windows.Forms.Button colorPicker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorPicker2;
        private System.Windows.Forms.Button colorPicker3;
        private System.Windows.Forms.Button colorPicker4;
        private System.Windows.Forms.Button colorPicker5;
        private System.Windows.Forms.Button colorPicker6;
        private System.Windows.Forms.Button colorPicker7;
        private System.Windows.Forms.CheckBox ReadTrackInstrumentBox;
    }
}
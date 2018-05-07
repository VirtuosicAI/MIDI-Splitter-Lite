namespace MIDI_Splitter_Lite
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abortSplittingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MIDIPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportPathBox = new System.Windows.Forms.TextBox();
            this.MIDIListView = new System.Windows.Forms.ListView();
            this.TrackNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.ExportBTN = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.OpenMIDIDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(479, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem,
            this.toolStripSeparator2,
            this.abortSplittingToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.splitToolStripMenuItem.Text = "Split track(s)";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // abortSplittingToolStripMenuItem
            // 
            this.abortSplittingToolStripMenuItem.Enabled = false;
            this.abortSplittingToolStripMenuItem.Name = "abortSplittingToolStripMenuItem";
            this.abortSplittingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abortSplittingToolStripMenuItem.Text = "Abort splitting";
            this.abortSplittingToolStripMenuItem.Click += new System.EventHandler(this.abortSplittingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MIDI File:";
            // 
            // MIDIPathBox
            // 
            this.MIDIPathBox.Location = new System.Drawing.Point(70, 29);
            this.MIDIPathBox.Name = "MIDIPathBox";
            this.MIDIPathBox.ReadOnly = true;
            this.MIDIPathBox.Size = new System.Drawing.Size(316, 20);
            this.MIDIPathBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Path:";
            // 
            // ExportPathBox
            // 
            this.ExportPathBox.Location = new System.Drawing.Point(85, 58);
            this.ExportPathBox.Name = "ExportPathBox";
            this.ExportPathBox.ReadOnly = true;
            this.ExportPathBox.Size = new System.Drawing.Size(301, 20);
            this.ExportPathBox.TabIndex = 4;
            // 
            // MIDIListView
            // 
            this.MIDIListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackNumber,
            this.TrackName,
            this.TrackSize});
            this.MIDIListView.FullRowSelect = true;
            this.MIDIListView.GridLines = true;
            this.MIDIListView.Location = new System.Drawing.Point(12, 85);
            this.MIDIListView.Name = "MIDIListView";
            this.MIDIListView.Size = new System.Drawing.Size(454, 156);
            this.MIDIListView.TabIndex = 5;
            this.MIDIListView.UseCompatibleStateImageBehavior = false;
            this.MIDIListView.View = System.Windows.Forms.View.Details;
            this.MIDIListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.MIDIListView_ColumnWidthChanging);
            this.MIDIListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MIDIListView_KeyDown);
            // 
            // TrackNumber
            // 
            this.TrackNumber.Text = "Track #";
            this.TrackNumber.Width = 53;
            // 
            // TrackName
            // 
            this.TrackName.Text = "Track Name";
            this.TrackName.Width = 300;
            // 
            // TrackSize
            // 
            this.TrackSize.Text = "Track Size";
            this.TrackSize.Width = 80;
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.Location = new System.Drawing.Point(392, 27);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(75, 23);
            this.BrowseBTN.TabIndex = 6;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = true;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // ExportBTN
            // 
            this.ExportBTN.Location = new System.Drawing.Point(392, 56);
            this.ExportBTN.Name = "ExportBTN";
            this.ExportBTN.Size = new System.Drawing.Size(75, 23);
            this.ExportBTN.TabIndex = 7;
            this.ExportBTN.Text = "Export";
            this.ExportBTN.UseVisualStyleBackColor = true;
            this.ExportBTN.Click += new System.EventHandler(this.ExportBTN_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 250);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(479, 23);
            this.progressBar.TabIndex = 10;
            // 
            // OpenMIDIDialog
            // 
            this.OpenMIDIDialog.Filter = "MIDI Files|*.mid";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 273);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ExportBTN);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.MIDIListView);
            this.Controls.Add(this.ExportPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MIDIPathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIDI Splitter Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortSplittingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MIDIPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExportPathBox;
        private System.Windows.Forms.ListView MIDIListView;
        private System.Windows.Forms.ColumnHeader TrackNumber;
        private System.Windows.Forms.ColumnHeader TrackName;
        private System.Windows.Forms.ColumnHeader TrackSize;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.Button ExportBTN;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog OpenMIDIDialog;
        private System.Windows.Forms.FolderBrowserDialog ExportBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}


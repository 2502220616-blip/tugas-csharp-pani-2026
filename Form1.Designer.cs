namespace meet_5
{
    partial class PictureViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSelectFolder = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            cboPictures = new ComboBox();
            picShow = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, mnuSelectFolder, mnuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(270, 34);
            mnuOpen.Text = "Open";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSelectFolder
            // 
            mnuSelectFolder.Name = "mnuSelectFolder";
            mnuSelectFolder.Size = new Size(270, 34);
            mnuSelectFolder.Text = "Select Folder";
            mnuSelectFolder.Click += toolStripMenuItem2_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(270, 34);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // cboPictures
            // 
            cboPictures.FormattingEnabled = true;
            cboPictures.Location = new Point(0, 36);
            cboPictures.Name = "cboPictures";
            cboPictures.Size = new Size(182, 33);
            cboPictures.TabIndex = 1;
            cboPictures.SelectedIndexChanged += cboPictures_SelectedIndexChanged;
            // 
            // picShow
            // 
            picShow.Location = new Point(0, 75);
            picShow.Name = "picShow";
            picShow.Size = new Size(150, 75);
            picShow.SizeMode = PictureBoxSizeMode.AutoSize;
            picShow.TabIndex = 2;
            picShow.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // PictureViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picShow);
            Controls.Add(cboPictures);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PictureViewer";
            Text = "PictureViewer";
            Load += PictureViewer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSelectFolder;
        private ToolStripMenuItem mnuExit;
        private ComboBox cboPictures;
        private PictureBox picShow;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
    }
}

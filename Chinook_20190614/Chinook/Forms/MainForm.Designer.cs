namespace Chinook.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMdi = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbArtist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlbum = new System.Windows.Forms.ToolStripButton();
            this.tsbTrack = new System.Windows.Forms.ToolStripButton();
            this.tsbNontification = new System.Windows.Forms.ToolStripButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "E&xit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniArtist,
            this.mniAlbum,
            this.mniTrack,
            this.mniMdi});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "F&orm";
            // 
            // mniArtist
            // 
            this.mniArtist.Name = "mniArtist";
            this.mniArtist.Size = new System.Drawing.Size(110, 22);
            this.mniArtist.Text = "&Artist";
            this.mniArtist.Click += new System.EventHandler(this.MniArtist_Click);
            // 
            // mniAlbum
            // 
            this.mniAlbum.Name = "mniAlbum";
            this.mniAlbum.Size = new System.Drawing.Size(110, 22);
            this.mniAlbum.Text = "A&lbum";
            this.mniAlbum.Click += new System.EventHandler(this.MniAlbum_Click);
            // 
            // mniTrack
            // 
            this.mniTrack.Name = "mniTrack";
            this.mniTrack.Size = new System.Drawing.Size(110, 22);
            this.mniTrack.Text = "&Track";
            this.mniTrack.Click += new System.EventHandler(this.MniTrack_Click);
            // 
            // mniMdi
            // 
            this.mniMdi.Name = "mniMdi";
            this.mniMdi.Size = new System.Drawing.Size(110, 22);
            this.mniMdi.Text = "&Mdi";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHelp,
            this.mniAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mniHelp
            // 
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(107, 22);
            this.mniHelp.Text = "&Help";
            this.mniHelp.Click += new System.EventHandler(this.MniHelp_Click);
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(107, 22);
            this.mniAbout.Text = "&About";
            this.mniAbout.Click += new System.EventHandler(this.MniAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbArtist,
            this.toolStripSeparator1,
            this.tsbAlbum,
            this.tsbTrack,
            this.tsbNontification});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbArtist
            // 
            this.tsbArtist.Image = global::Chinook.Properties.Resources.Artist;
            this.tsbArtist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArtist.Name = "tsbArtist";
            this.tsbArtist.Size = new System.Drawing.Size(55, 22);
            this.tsbArtist.Text = "Artist";
            this.tsbArtist.ToolTipText = "클릭시 ArtistForm이 열림";
            this.tsbArtist.Click += new System.EventHandler(this.TsbArtist_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAlbum
            // 
            this.tsbAlbum.Image = global::Chinook.Properties.Resources.Album;
            this.tsbAlbum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlbum.Name = "tsbAlbum";
            this.tsbAlbum.Size = new System.Drawing.Size(63, 22);
            this.tsbAlbum.Text = "Album";
            this.tsbAlbum.Click += new System.EventHandler(this.TsbAlbum_Click);
            // 
            // tsbTrack
            // 
            this.tsbTrack.Image = global::Chinook.Properties.Resources.Track;
            this.tsbTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrack.Name = "tsbTrack";
            this.tsbTrack.Size = new System.Drawing.Size(55, 22);
            this.tsbTrack.Text = "Track";
            this.tsbTrack.Click += new System.EventHandler(this.TsbTrack_Click);
            // 
            // tsbNontification
            // 
            this.tsbNontification.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNontification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNontification.Image = ((System.Drawing.Image)(resources.GetObject("tsbNontification.Image")));
            this.tsbNontification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNontification.Name = "tsbNontification";
            this.tsbNontification.Size = new System.Drawing.Size(35, 22);
            this.tsbNontification.Text = "알림";
            this.tsbNontification.Click += new System.EventHandler(this.TsbNontification_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tmrNotification
            // 
            this.tmrNotification.Interval = 10000;
            this.tmrNotification.Tick += new System.EventHandler(this.TmrNotification_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniArtist;
        private System.Windows.Forms.ToolStripMenuItem mniAlbum;
        private System.Windows.Forms.ToolStripMenuItem mniTrack;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
        private System.Windows.Forms.ToolStripMenuItem mniMdi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbArtist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAlbum;
        private System.Windows.Forms.ToolStripButton tsbTrack;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripButton tsbNontification;
        private System.Windows.Forms.Timer tmrNotification;
    }
}
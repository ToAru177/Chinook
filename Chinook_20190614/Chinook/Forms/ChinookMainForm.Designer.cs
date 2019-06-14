namespace Chinook.Forms
{
    partial class ChinookMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.폼OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbArtist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlbum = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTrack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInvoice = new System.Windows.Forms.ToolStripButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.폼OToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(113, 22);
            this.mniExit.Text = "종료(&X)";
            this.mniExit.ToolTipText = "프로그램 종료";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // 폼OToolStripMenuItem
            // 
            this.폼OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniArtist,
            this.mniAlbum,
            this.mniTrack,
            this.mniCustomer,
            this.mniInvoice});
            this.폼OToolStripMenuItem.Name = "폼OToolStripMenuItem";
            this.폼OToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.폼OToolStripMenuItem.Text = "폼(&O)";
            // 
            // mniArtist
            // 
            this.mniArtist.Name = "mniArtist";
            this.mniArtist.Size = new System.Drawing.Size(126, 22);
            this.mniArtist.Text = "&Artist";
            this.mniArtist.ToolTipText = "ArtistListForm 실행";
            this.mniArtist.Click += new System.EventHandler(this.MniArtist_Click);
            // 
            // mniAlbum
            // 
            this.mniAlbum.Name = "mniAlbum";
            this.mniAlbum.Size = new System.Drawing.Size(126, 22);
            this.mniAlbum.Text = "A&lbum";
            this.mniAlbum.ToolTipText = "AlbumListForm 실행";
            this.mniAlbum.Click += new System.EventHandler(this.MniAlbum_Click);
            // 
            // mniTrack
            // 
            this.mniTrack.Name = "mniTrack";
            this.mniTrack.Size = new System.Drawing.Size(126, 22);
            this.mniTrack.Text = "&Track";
            this.mniTrack.ToolTipText = "TrackListForm 실행";
            this.mniTrack.Click += new System.EventHandler(this.MniTrack_Click);
            // 
            // mniCustomer
            // 
            this.mniCustomer.Name = "mniCustomer";
            this.mniCustomer.Size = new System.Drawing.Size(126, 22);
            this.mniCustomer.Text = "&Customer";
            this.mniCustomer.ToolTipText = "CustomerListForm 실행";
            this.mniCustomer.Click += new System.EventHandler(this.MniCustomer_Click);
            // 
            // mniInvoice
            // 
            this.mniInvoice.Name = "mniInvoice";
            this.mniInvoice.Size = new System.Drawing.Size(126, 22);
            this.mniInvoice.Text = "&Invoice";
            this.mniInvoice.ToolTipText = "InvoiceListForm 실행";
            this.mniInvoice.Click += new System.EventHandler(this.MniInvoice_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHelp,
            this.mniAbout});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // mniHelp
            // 
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(180, 22);
            this.mniHelp.Text = "&Help";
            this.mniHelp.ToolTipText = "프로그램에 대한 도움말";
            // 
            // mniAbout
            // 
            this.mniAbout.Name = "mniAbout";
            this.mniAbout.Size = new System.Drawing.Size(180, 22);
            this.mniAbout.Text = "정보(&B)";
            this.mniAbout.ToolTipText = "프로그램 정보";
            this.mniAbout.Click += new System.EventHandler(this.MniAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbArtist,
            this.toolStripSeparator1,
            this.tsbAlbum,
            this.toolStripSeparator2,
            this.tsbTrack,
            this.toolStripSeparator3,
            this.tsbInvoice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbArtist
            // 
            this.tsbArtist.Image = global::Chinook.Properties.Resources.Artist;
            this.tsbArtist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArtist.Name = "tsbArtist";
            this.tsbArtist.Size = new System.Drawing.Size(55, 22);
            this.tsbArtist.Text = "Artist";
            this.tsbArtist.ToolTipText = "클릭시 ArtistListForm 실행";
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
            this.tsbAlbum.ToolTipText = "클릭시 AlbumListForm 실행";
            this.tsbAlbum.Click += new System.EventHandler(this.TsbAlbum_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTrack
            // 
            this.tsbTrack.Image = global::Chinook.Properties.Resources.Track;
            this.tsbTrack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrack.Name = "tsbTrack";
            this.tsbTrack.Size = new System.Drawing.Size(55, 22);
            this.tsbTrack.Text = "Track";
            this.tsbTrack.ToolTipText = "클릭시 TrackListForm 실행";
            this.tsbTrack.Click += new System.EventHandler(this.TsbTrack_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbInvoice
            // 
            this.tsbInvoice.Image = global::Chinook.Properties.Resources.Invoice;
            this.tsbInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInvoice.Name = "tsbInvoice";
            this.tsbInvoice.Size = new System.Drawing.Size(65, 22);
            this.tsbInvoice.Text = "Invoice";
            this.tsbInvoice.ToolTipText = "클릭시 InvoiceListForm 실행";
            this.tsbInvoice.Click += new System.EventHandler(this.TsbInvoice_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(538, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "tool 활성화";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ChinookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChinookMainForm";
            this.Text = "ChinookMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem 폼OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniArtist;
        private System.Windows.Forms.ToolStripMenuItem mniAlbum;
        private System.Windows.Forms.ToolStripMenuItem mniTrack;
        private System.Windows.Forms.ToolStripMenuItem mniCustomer;
        private System.Windows.Forms.ToolStripMenuItem mniInvoice;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripMenuItem mniAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbArtist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAlbum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbTrack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbInvoice;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
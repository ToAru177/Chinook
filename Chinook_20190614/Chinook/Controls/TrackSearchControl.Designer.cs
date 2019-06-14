namespace Chinook.Controls
{
    partial class TrackSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.bdsGenre = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbGenreId = new System.Windows.Forms.CheckBox();
            this.chbAlbumId = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbGenreId = new System.Windows.Forms.ComboBox();
            this.cbbAlbumId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGenre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsAlbum
            // 
            // 
            // bdsGenre
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbGenreId);
            this.groupBox1.Controls.Add(this.chbAlbumId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbGenreId);
            this.groupBox1.Controls.Add(this.cbbAlbumId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // chbGenreId
            // 
            this.chbGenreId.AutoSize = true;
            this.chbGenreId.Location = new System.Drawing.Point(368, 17);
            this.chbGenreId.Name = "chbGenreId";
            this.chbGenreId.Size = new System.Drawing.Size(15, 14);
            this.chbGenreId.TabIndex = 8;
            this.chbGenreId.UseVisualStyleBackColor = true;
            this.chbGenreId.CheckedChanged += new System.EventHandler(this.chbGenreId_CheckedChanged);
            // 
            // chbAlbumId
            // 
            this.chbAlbumId.AutoSize = true;
            this.chbAlbumId.Location = new System.Drawing.Point(198, 16);
            this.chbAlbumId.Name = "chbAlbumId";
            this.chbAlbumId.Size = new System.Drawing.Size(15, 14);
            this.chbAlbumId.TabIndex = 7;
            this.chbAlbumId.UseVisualStyleBackColor = true;
            this.chbAlbumId.CheckedChanged += new System.EventHandler(this.cbxAlbumId_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(689, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색(&s)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Enter += new System.EventHandler(this.btnSearch_Enter);
            this.btnSearch.Leave += new System.EventHandler(this.btnSearch_Leave);
            // 
            // cbbGenreId
            // 
            this.cbbGenreId.DataSource = this.bdsGenre;
            this.cbbGenreId.DisplayMember = "Name";
            this.cbbGenreId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenreId.Enabled = false;
            this.cbbGenreId.FormattingEnabled = true;
            this.cbbGenreId.Location = new System.Drawing.Point(389, 14);
            this.cbbGenreId.Name = "cbbGenreId";
            this.cbbGenreId.Size = new System.Drawing.Size(100, 20);
            this.cbbGenreId.TabIndex = 5;
            this.cbbGenreId.ValueMember = "GenreId";
            // 
            // cbbAlbumId
            // 
            this.cbbAlbumId.DataSource = this.bdsAlbum;
            this.cbbAlbumId.DisplayMember = "Title";
            this.cbbAlbumId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlbumId.Enabled = false;
            this.cbbAlbumId.FormattingEnabled = true;
            this.cbbAlbumId.Location = new System.Drawing.Point(219, 14);
            this.cbbAlbumId.Name = "cbbAlbumId";
            this.cbbAlbumId.Size = new System.Drawing.Size(100, 20);
            this.cbbAlbumId.TabIndex = 4;
            this.cbbAlbumId.ValueMember = "AlbumId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "앨범 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "장르 :";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(49, 14);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 1;
            this.txbName.Enter += new System.EventHandler(this.txbName_Enter);
            this.txbName.Leave += new System.EventHandler(this.txbName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // TrackSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TrackSearchControl";
            this.Size = new System.Drawing.Size(770, 48);
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGenre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsAlbum;
        private System.Windows.Forms.BindingSource bdsGenre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbGenreId;
        private System.Windows.Forms.ComboBox cbbAlbumId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbAlbumId;
        private System.Windows.Forms.CheckBox chbGenreId;
    }
}

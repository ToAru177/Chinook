namespace Chinook.Forms
{
    partial class AlbumListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbArtistId = new System.Windows.Forms.ComboBox();
            this.bdsArtist = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbAlbumTitle = new System.Windows.Forms.TextBox();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbArtistId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbAlbumTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // cbbArtistId
            // 
            this.cbbArtistId.DataSource = this.bdsArtist;
            this.cbbArtistId.DisplayMember = "Name";
            this.cbbArtistId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtistId.FormattingEnabled = true;
            this.cbbArtistId.Location = new System.Drawing.Point(237, 20);
            this.cbbArtistId.Name = "cbbArtistId";
            this.cbbArtistId.Size = new System.Drawing.Size(121, 20);
            this.cbbArtistId.TabIndex = 4;
            this.cbbArtistId.ValueMember = "ArtistId";
            this.cbbArtistId.Enter += new System.EventHandler(this.cbbArtistId_Enter);
            this.cbbArtistId.Leave += new System.EventHandler(this.cbbArtistId_Leave);
            // 
            // bdsArtist
            // 
            this.bdsArtist.DataSource = typeof(Chinook.Data.Artist);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "아티스트 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "제목 : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(456, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검색(&s)";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbAlbumTitle
            // 
            this.txbAlbumTitle.Location = new System.Drawing.Point(44, 20);
            this.txbAlbumTitle.Name = "txbAlbumTitle";
            this.txbAlbumTitle.Size = new System.Drawing.Size(116, 21);
            this.txbAlbumTitle.TabIndex = 1;
            this.txbAlbumTitle.Enter += new System.EventHandler(this.txbAlbumTitle_Enter);
            this.txbAlbumTitle.Leave += new System.EventHandler(this.txbAlbumTitle_Leave);
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AllowUserToAddRows = false;
            this.dgvAlbum.AllowUserToDeleteRows = false;
            this.dgvAlbum.AllowUserToResizeColumns = false;
            this.dgvAlbum.AllowUserToResizeRows = false;
            this.dgvAlbum.AutoGenerateColumns = false;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.artistNameDataGridViewTextBoxColumn});
            this.dgvAlbum.DataSource = this.bdsAlbum;
            this.dgvAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlbum.Location = new System.Drawing.Point(5, 62);
            this.dgvAlbum.MultiSelect = false;
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.ReadOnly = true;
            this.dgvAlbum.RowTemplate.Height = 23;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(545, 304);
            this.dgvAlbum.TabIndex = 4;
            // 
            // bdsAlbum
            // 
            this.bdsAlbum.DataSource = typeof(Chinook.Data.Album);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AlbumId";
            this.dataGridViewTextBoxColumn3.HeaderText = "AlbumId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            this.artistNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // AlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 371);
            this.Controls.Add(this.dgvAlbum);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AlbumListForm";
            this.Load += new System.EventHandler(this.AlbumListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbAlbumTitle;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.ComboBox cbbArtistId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsArtist;
        private System.Windows.Forms.BindingSource bdsAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
    }
}
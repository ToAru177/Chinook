namespace Chinook.Controls
{
    partial class InvoiceSearchControl
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
            this.bdsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbToDate = new System.Windows.Forms.CheckBox();
            this.chbFromDate = new System.Windows.Forms.CheckBox();
            this.chbBillingCountry = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCountry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsCountry
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbToDate);
            this.groupBox1.Controls.Add(this.chbFromDate);
            this.groupBox1.Controls.Add(this.chbBillingCountry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbCountry);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // chbToDate
            // 
            this.chbToDate.AutoSize = true;
            this.chbToDate.Location = new System.Drawing.Point(646, 16);
            this.chbToDate.Name = "chbToDate";
            this.chbToDate.Size = new System.Drawing.Size(15, 14);
            this.chbToDate.TabIndex = 11;
            this.chbToDate.UseVisualStyleBackColor = true;
            this.chbToDate.CheckedChanged += new System.EventHandler(this.chbToDate_CheckedChanged);
            // 
            // chbFromDate
            // 
            this.chbFromDate.AutoSize = true;
            this.chbFromDate.Location = new System.Drawing.Point(500, 16);
            this.chbFromDate.Name = "chbFromDate";
            this.chbFromDate.Size = new System.Drawing.Size(15, 14);
            this.chbFromDate.TabIndex = 10;
            this.chbFromDate.UseVisualStyleBackColor = true;
            this.chbFromDate.CheckedChanged += new System.EventHandler(this.chbDay_CheckedChanged);
            // 
            // chbBillingCountry
            // 
            this.chbBillingCountry.AutoSize = true;
            this.chbBillingCountry.Location = new System.Drawing.Point(311, 17);
            this.chbBillingCountry.Name = "chbBillingCountry";
            this.chbBillingCountry.Size = new System.Drawing.Size(15, 14);
            this.chbBillingCountry.TabIndex = 9;
            this.chbBillingCountry.UseVisualStyleBackColor = true;
            this.chbBillingCountry.CheckedChanged += new System.EventHandler(this.chbBillingCity_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "~";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Enabled = false;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(667, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(101, 21);
            this.dtpToDate.TabIndex = 7;
            this.dtpToDate.Value = new System.DateTime(2019, 6, 11, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(806, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색(&s)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Enter += new System.EventHandler(this.btnSearch_Enter);
            this.btnSearch.Leave += new System.EventHandler(this.btnSearch_Leave);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Enabled = false;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(521, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(101, 21);
            this.dtpFromDate.TabIndex = 5;
            this.dtpFromDate.Value = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "구매 날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "구매 국가 :";
            // 
            // cbbCountry
            // 
            this.cbbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCountry.Enabled = false;
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(332, 14);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(100, 20);
            this.cbbCountry.TabIndex = 2;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(61, 14);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(173, 21);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmail_KeyPress);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이메일 :";
            // 
            // InvoiceSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "InvoiceSearchControl";
            this.Size = new System.Drawing.Size(887, 51);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCountry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbBillingCountry;
        private System.Windows.Forms.CheckBox chbFromDate;
        private System.Windows.Forms.CheckBox chbToDate;
    }
}

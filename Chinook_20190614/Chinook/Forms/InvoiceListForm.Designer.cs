using Chinook.Controls;

namespace Chinook.Forms
{
    partial class InvoiceListForm
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
            this.uscList = new Chinook.Controls.InvoiceListControl();
            this.uscSearch2 = new Chinook.Controls.InvoiceSearchControl();
            this.SuspendLayout();
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(5, 56);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(809, 272);
            this.uscList.TabIndex = 3;
            this.uscList.RowDoubleClicked += new System.EventHandler<Chinook.Controls.InvoiceListControl.RowDoubleClickedEventArgs>(this.uscList_RowDoubleClicked);
            // 
            // uscSearch
            // 

            // 
            // uscSearch2
            // 
            this.uscSearch2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch2.Location = new System.Drawing.Point(5, 5);
            this.uscSearch2.Name = "uscSearch2";
            this.uscSearch2.Size = new System.Drawing.Size(809, 51);
            this.uscSearch2.TabIndex = 5;
            this.uscSearch2.SearchButtonClicked += new System.EventHandler<Chinook.Controls.InvoiceSearchControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            this.uscSearch2.EmailTextBoxKeyPressed += new System.EventHandler<Chinook.Controls.InvoiceSearchControl.EmailTextBoxKeyPressedEventArgs>(this.uscSearch_EmailTextBoxKeyPressed);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 333);
            this.Controls.Add(this.uscList);
            this.Controls.Add(this.uscSearch2);
            this.Name = "InvoiceListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "InvoiceListForm";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private InvoiceSearchControl uscSearch;
        private InvoiceListControl uscList;
        private InvoiceSearchControl uscSearch2;
    }
}
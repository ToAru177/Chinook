using Chinook.Controls;

namespace Chinook.Forms
{
    partial class TrackListForm
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
            this.uscList = new Chinook.Controls.TrackListControl();
            this.uscSearch = new Chinook.Controls.TrackSearchControl();
            this.SuspendLayout();
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(5, 53);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(659, 301);
            this.uscList.TabIndex = 3;
            this.uscList.RowDoubleClicked += new System.EventHandler<Chinook.Controls.TrackListControl.RowDoubleClickedEventArgs>(this.uscList_RowDoubleClicked);
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(5, 5);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(659, 48);
            this.uscSearch.TabIndex = 2;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.TrackSearchControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            // 
            // TrackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 359);
            this.Controls.Add(this.uscList);
            this.Controls.Add(this.uscSearch);
            this.Name = "TrackListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "TrackListForm";
            this.Load += new System.EventHandler(this.TrackListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private TrackSearchControl uscSearch;
        private TrackListControl uscList;
    }
}
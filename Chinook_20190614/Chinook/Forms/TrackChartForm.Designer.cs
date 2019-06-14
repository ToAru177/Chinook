using Chinook.Controls;

namespace Chinook.Forms
{
    partial class TrackChartForm
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
            this.trackListControl1 = new Chinook.Controls.TrackSearchControl();
            this.SuspendLayout();
            // 
            // trackListControl1
            // 
            this.trackListControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackListControl1.Location = new System.Drawing.Point(0, 0);
            this.trackListControl1.Name = "trackListControl1";
            this.trackListControl1.Size = new System.Drawing.Size(626, 48);
            this.trackListControl1.TabIndex = 0;
            // 
            // TrackChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.trackListControl1);
            this.Name = "TrackChartForm";
            this.Text = "TrackChartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TrackSearchControl trackListControl1;
    }
}
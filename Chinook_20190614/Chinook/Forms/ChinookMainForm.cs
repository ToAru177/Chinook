using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class ChinookMainForm : Form
    {
        public ChinookMainForm()
        {
            InitializeComponent();
            _buttons.Add(tsbAlbum);
            _buttons.Add(tsbArtist);
            _buttons.Add(tsbTrack);
            _buttons.Add(tsbInvoice);
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MniArtist_Click(object sender, EventArgs e)
        {
            ArtistListForm form = new ArtistListForm();
            form.Show();
        }

        private void MniAlbum_Click(object sender, EventArgs e)
        {
            AlbumListForm form = new AlbumListForm();
            form.Show();
        }

        private void MniTrack_Click(object sender, EventArgs e)
        {
            TrackListForm form = new TrackListForm();
            form.Show();
        }

        private void MniCustomer_Click(object sender, EventArgs e)
        {
            CustomerListForm form = new CustomerListForm();
            form.Show();
        }

        private void MniInvoice_Click(object sender, EventArgs e)
        {
            InvoiceListForm form = new InvoiceListForm();
            form.Show();
        }

        private void TsbArtist_Click(object sender, EventArgs e)
        {
            mniArtist.PerformClick();
        }

        private void TsbAlbum_Click(object sender, EventArgs e)
        {
            mniAlbum.PerformClick();
        }

        private void TsbTrack_Click(object sender, EventArgs e)
        {
            mniTrack.PerformClick();
        }

        private void TsbInvoice_Click(object sender, EventArgs e)
        {
            mniInvoice.PerformClick();
        }

        private List<ToolStripButton> _buttons = new List<ToolStripButton>();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (var button in _buttons)
                    button.Enabled = true;
            }

            else
            {
                foreach (var button in _buttons)
                    button.Enabled = false;
            }
        }

        private void MniAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("호기심에 눌러서 어쩌라고?");
        }
    }
}

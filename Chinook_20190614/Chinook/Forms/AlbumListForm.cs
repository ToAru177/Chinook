using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class AlbumListForm : Form
    {
        public AlbumListForm()
        {
            InitializeComponent();
        }

        // Form이 메모리에 로딩 되었다...
        private void AlbumListForm_Load(object sender, EventArgs e)
        {
            //int count1 = DB.
            bdsArtist.DataSource = DB.Artist.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // code coverage
            string title = txbAlbumTitle.Text;
            int artistId = (int)cbbArtistId.SelectedValue;

            bdsAlbum.DataSource = DB.Album.Search2(title, artistId);
        }


        private void txbAlbumTitle_Enter(object sender, EventArgs e)
        {
            txbAlbumTitle.BackColor = Color.Beige;
        }

        private void txbAlbumTitle_Leave(object sender, EventArgs e)
        {
            txbAlbumTitle.BackColor = Color.White;
        }

        private void cbbArtistId_Enter(object sender, EventArgs e)
        {
            cbbArtistId.BackColor = Color.Beige;
        }

        private void cbbArtistId_Leave(object sender, EventArgs e)
        {
            cbbArtistId.BackColor = Color.White;
        }
    }
}

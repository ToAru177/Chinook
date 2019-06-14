using Chinook.Controls;
using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class TrackListForm : Form
    {
        public TrackListForm()
        {
            InitializeComponent();

            List<Genre> L1 = DB.Genre.GetAll();
            List<Genre> L2 = DB.Genre.GetAll();
        }

        private void TrackListForm_Load(object sender, EventArgs e)
        {
            uscSearch.LoadAlbums();
            uscSearch.LoadGenres();
        }

        private void uscSearch_SearchButtonClicked(object sender, TrackSearchControl.SearchButtonClickedEventArgs e)
        {
            // var => List<Track>
            var tracks = DB.Track.Search(e.Name, e.AlbumId, e.GenreId);
            uscList.SetDataSource(tracks);
        }

        private void uscList_RowDoubleClicked(object sender, TrackListControl.RowDoubleClickedEventArgs e)
        {
            MessageBox.Show($"{e.Track.TrackId} / {e.Track.Name}");
        }
    }
}
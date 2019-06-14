using Chinook.Controls;
using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class ArtistListForm : Form
    {
        public ArtistListForm()
        {
            InitializeComponent();
        }

        private void uscSearcg_SearchButtonClicked(object sender, ArtistSearchControl.SearchButtonClickedEventArgs e)
        {
            var artists = DB.Artist.Search(e.Name);
            uscList.SetDataSource(artists);
        }
    }
}

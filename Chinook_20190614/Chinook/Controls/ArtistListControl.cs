using Chinook.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class ArtistListControl : UserControl
    {
        public ArtistListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Artist> artists)
        {
            bdsArtist.DataSource = artists;
        }
    }
}

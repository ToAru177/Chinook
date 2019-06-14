using Chinook.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class TrackSearchControl : UserControl
    {
        public TrackSearchControl()
        {
            InitializeComponent();
        }

        # region Button and TextBox Color Setting
        private void btnSearch_Enter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Beige;
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.White;
        }

        private void txbName_Enter(object sender, EventArgs e)
        {
            txbName.BackColor = Color.Beige;
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            txbName.BackColor = Color.White;
        }

        #endregion

        /// <summary>
        /// 검색 버튼을 Click하는 이벤트 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string name = txbName.Text;
            int? albumId = cbbAlbumId.Enabled ?
                (int?)cbbAlbumId.SelectedValue : null;
            int? genreId = cbbGenreId.Enabled ?
                (int?)cbbGenreId.SelectedValue : null;

            // 코드 생성기로 만든 함수 - SearchbuttonClicked event things for C# 3.0
            OnSearchButtonClicked(name, albumId, genreId);

            //bdsTrack.DataSource = DB.Track.Search(name, albumId, genreId);
        }

        public void LoadAlbums()
        {
            bdsAlbum.DataSource = DB.Album.GetAll();
        }

        public void LoadGenres()
        {
            bdsGenre.DataSource = DB.Genre.GetAll();
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string name, int? albumId, int? genreId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(name, albumId, genreId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string Name { get; set; }
            public int? AlbumId { get; set; }
            public int? GenreId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string name, int? albumId, int? genreId)
            {
                Name = name;
                AlbumId = albumId;
                GenreId = genreId;
            }
        }
        #endregion

        private void cbxAlbumId_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox를 체크 여부에 따른 콤보박스의 활성화 
            cbbAlbumId.Enabled = chbAlbumId.Checked;
        }

        private void chbGenreId_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox를 체크 여부에 따른 콤보박스의 활성화 
            cbbGenreId.Enabled = chbGenreId.Checked;
        }
    }
}

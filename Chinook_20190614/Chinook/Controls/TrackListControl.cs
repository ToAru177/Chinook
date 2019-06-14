using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.Controls
{
    public partial class TrackListControl : UserControl
    {
        public TrackListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Track> tracks)
        {
            bdsTrack.DataSource = tracks;

            lblCount.Text = $"총 {tracks.Count} 건 있다능";
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            Track track = dgvList.CurrentRow.DataBoundItem as Track;

            if (track == null)
                return;

            // TrackForm 띄우기
            OnRowDoubleClicked(track);

            //if (item is Track)
            //    track = (Track)item;

            //track = item as Track;  // 참조 타입에만 사용 가능. 캐스팅 실패시 null.

            //if (track != null)
            //    ;
        }

        #region RowDoubleClicked event things for C# 3.0
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(Track track)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(track);
            OnRowDoubleClicked(args);

            return args;
        }

        private RowDoubleClickedEventArgs OnRowDoubleClickedForOut()
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs();
            OnRowDoubleClicked(args);

            return args;
        }

        public class RowDoubleClickedEventArgs : EventArgs
        {
            public Track Track { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(Track track)
            {
                Track = track;
            }
        }
        #endregion
    }
}

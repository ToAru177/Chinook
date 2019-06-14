using Chinook.Data;
using Chinook.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Chinook.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _buttons.Add(tsbAlbum);
            _buttons.Add(tsbArtist);
            _buttons.Add(tsbTrack);
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // form을 닫음
            Close();
        }

        private void MniHelp_Click(object sender, EventArgs e)
        {
            // 네이버 홈페이지로 이동
            Process.Start("http://www.naver.com");
            // notepad 실행
            //Process.Start("notepad.exe");

        }

        private void MniAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이것은 정보 대화 상자");
        }

        private void MniArtist_Click(object sender, EventArgs e)
        {

        }

        private void MniAlbum_Click(object sender, EventArgs e)
        {
            //ALF => AlbumListForm 
            AlbumListForm form = new AlbumListForm();
            form.ShowDialog();  //modal : form을 띄우고 다른 form으로 포커스 이동 불가
                                //          modal이 실행되면 code 자체가 멈춤
            MessageBox.Show("AlbumList 닫힘");
        }

        private void MniTrack_Click(object sender, EventArgs e)
        {
            TrackListForm form = new TrackListForm();
            form.Show();    // modeless : form을 띄운 상태에서 다른 form으로 포커스 이동 가능.
                            //              modeless가 실행되더라도 code는 계속 진행 된다.
            //MessageBox.Show("TrackList 닫힘");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ptbImage.Image = Image.FromFile(@"D:\IoT\C#\20190610\Artist_icon.png");
            // 프로젝트에 이미지를 내장하여 불러움...(Project의 속성에서 Resource에 image 추가 후 저장)
            //ptbImage.Image = Resources.Track_icon;

            //tmrNotification.Enabled = true; // tmrNotification.Enabled = false;
            int count = DB.Genre.GetCount();
            MessageBox.Show(count.ToString());
            tmrNotification.Start();    // tmrNotification.Stop();
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

        private List<ToolStripButton> _buttons = new List<ToolStripButton>();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void TsbNontification_Click(object sender, EventArgs e)
        {
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "이것은 타이틀이다.";
            popupNotifier.ContentText = "여기는 컨텐츠다.";
            popupNotifier.Image = Resources.Artist;
            popupNotifier.Click += PopupNotifier_Click;
            popupNotifier.Popup();

        }

        private void PopupNotifier_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
        }

        private void TmrNotification_Tick(object sender, EventArgs e)
        {
            tsbNontification.PerformClick();
        }

        // mdi 사용하기 위해서는 IsMdiContain 설정 값을 True로 바꿔야 사용 가능
        //private void MniMdi_Click(object sender, EventArgs e)
        //{
        //    TrackListForm form = new TrackListForm();
        //    form.MdiParent = this;      // 부모 폼의 자식 폼으로 폼이 만들어 진다.
        //                                // mdi contain 내에서 벗어나지 못함...
        //    form.Show();
        //}
    }
}

using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class InvoiceSearchControl : UserControl
    {
        public InvoiceSearchControl()
        {
            InitializeComponent();
            //ComboBoxDuplicateRemoval(cbbCountry);
        }

        /// <summary>
        /// ComboBox의 중복을 제거하는 함수
        /// </summary>
        /// <param name="comboBoxItem"></param>
        private void ComboBoxDuplicateRemoval(ComboBox comboBoxItem)
        {
            List<string> list = DB.Customer.GetCountry();
            // list의 중복 제거
            list = list.Distinct().ToList();

            comboBoxItem.Items.Clear();
            comboBoxItem.Items.AddRange(list.ToArray());
        }

        #region TextBox 와 SearchBotton 색깔 설정
        private void txbEmail_Enter(object sender, EventArgs e)
        {
            txbEmail.BackColor = Color.Beige;
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            txbEmail.BackColor = Color.White;
        }

        private void btnSearch_Enter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Beige;
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.White;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            // string은 참조형이고 항상 nullable 이다.
            string country = cbbCountry.Text;
            DateTime fromDate = dtpFromDate.Value;//.ToString("yyyy-MM-dd");
            DateTime toDate = dtpToDate.Value;
            
            OnSearchButtonClicked(email, country, fromDate, toDate);            
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string email, string city, DateTime date1, DateTime date2)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(email, city, date1, date2);
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
            public string Email { get; set; }
            public string Country { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string email, string country, DateTime fromDate, DateTime toDate)
            {
                Email = email;
                Country = country;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion

        public void LoadCustomers()
        {
            //bdsCountry.DataSource = DB.Customer.GetALL();
            ComboBoxDuplicateRemoval(cbbCountry);
        }

        #region CheckBox 설정에 따른 combobox, dateTimePicker 활성화
        private void chbBillingCity_CheckedChanged(object sender, EventArgs e)
        {
            cbbCountry.Enabled = chbBillingCountry.Checked;
        }

        private void chbDay_CheckedChanged(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = chbFromDate.Checked;
        }

        private void chbToDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpToDate.Enabled = chbToDate.Checked;
        }
        #endregion

        private void txbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string email = txbEmail.Text;
            string country = cbbCountry.Text;
            DateTime fromDate = dtpFromDate.Value;//.ToString("yyyy-MM-dd");
            DateTime toDate = dtpToDate.Value;

            OnEmailTextBoxKeyPressed(email, country, fromDate, toDate);
        }

        #region EmailTextBoxKeyPressed event things for C# 3.0
        public event EventHandler<EmailTextBoxKeyPressedEventArgs> EmailTextBoxKeyPressed;

        protected virtual void OnEmailTextBoxKeyPressed(EmailTextBoxKeyPressedEventArgs e)
        {
            if (EmailTextBoxKeyPressed != null)
                EmailTextBoxKeyPressed(this, e);
        }

        private EmailTextBoxKeyPressedEventArgs OnEmailTextBoxKeyPressed(string email, string country, DateTime fromDate, DateTime toDate)
        {
            EmailTextBoxKeyPressedEventArgs args = new EmailTextBoxKeyPressedEventArgs(email, country, fromDate, toDate);
            OnEmailTextBoxKeyPressed(args);

            return args;
        }

        private EmailTextBoxKeyPressedEventArgs OnEmailTextBoxEnterKeyPressedForOut()
        {
            EmailTextBoxKeyPressedEventArgs args = new EmailTextBoxKeyPressedEventArgs();
            OnEmailTextBoxKeyPressed(args);

            return args;
        }

        public class EmailTextBoxKeyPressedEventArgs : EventArgs
        {
            public string Email { get; set; }
            public string Country { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public EmailTextBoxKeyPressedEventArgs()
            {
            }

            public EmailTextBoxKeyPressedEventArgs(string email, string country, DateTime fromDate, DateTime toDate)
            {
                Email = email;
                Country = country;
                FromDate = fromDate;
                ToDate = toDate;
            }
        }
        #endregion
    }
}

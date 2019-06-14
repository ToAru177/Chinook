using Chinook.Controls;
using Chinook.Data;
using System;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class InvoiceListForm : Form
    {
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            uscSearch2.LoadCustomers();
        }

        private void uscSearch_SearchButtonClicked(object sender, InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
            var invoices = DB.Invoice.Search(e.Email, e.Country, e.FromDate, e.ToDate);
           // MessageBox.Show($"{e.Email} / {e.City} / {e.Date1} / {e.Date2}");
            uscList.SetDataSource(invoices);
        }

        private void uscSearch_EmailTextBoxKeyPressed(object sender, InvoiceSearchControl.EmailTextBoxKeyPressedEventArgs e)
        {
            var invoices = DB.Invoice.Search(e.Email, e.Country, e.FromDate, e.ToDate);
            // MessageBox.Show($"{e.Email} / {e.City} / {e.Date1} / {e.Date2}");
            uscList.SetDataSource(invoices);
        }

        private void uscList_RowDoubleClicked(object sender, InvoiceListControl.RowDoubleClickedEventArgs e)
        {
            MessageBox.Show($"{e.Invoice.CustomerEmail} / {e.Invoice.BillingCity}");
        }
    }
}

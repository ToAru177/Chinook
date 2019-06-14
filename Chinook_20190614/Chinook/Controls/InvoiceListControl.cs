using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class InvoiceListControl : UserControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Invoice> invoices)
        {
            bdsInvoice.DataSource = invoices;

            lblCount.Text = $"총 {invoices.Count} 건 있다능";
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Invoice invoice = dgvList.CurrentRow.DataBoundItem as Invoice;
            Invoice invoice = (dgvList.CurrentRow.DataBoundItem as Invoice);
            

            if (invoice == null)
                return;

            // TrackForm 띄우기
            OnRowDoubleClicked(invoice);
        }

        #region RowDoubleClicked event things for C# 3.0
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(Invoice invoice)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(invoice);
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
            public Invoice Invoice { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(Invoice invoice)
            {
                Invoice = invoice;
            }
        }
        #endregion
    }
}

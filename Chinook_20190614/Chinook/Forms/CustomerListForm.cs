using Chinook.Controls;
using Chinook.Data;
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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void uscSearch_SearchButtonClicked(object sender, CustomerSearchControl.SearchButtonClickedEventArgs e)
        {
            // var => List<Track>
            var customers = DB.Customer.Search(e.Email);
            uscList.SetDataSource(customers);
        }
    }
}

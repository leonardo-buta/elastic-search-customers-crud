using ElasticSearch.Customers.CRUD.Forms;
using System;
using System.Windows.Forms;

namespace ElasticSearch.Customers.CRUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void NewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += new FormClosedEventHandler(CustomerForm_Closed);
            customerForm.ShowDialog(this);
        }

        private void CustomerForm_Closed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

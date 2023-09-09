using labNetPractica3.EF.Logic.Customer;
using labNetPractica3.EF.UI.Presentations.Customers;
using labNetPractica3.EF.UI.Presentations.Orders;
using System;
using System.Windows.Forms;

namespace labNetPractica3.EF.UI
{
    public partial class Principal : Form
    {
        private CustomerServicio customerServicio = new CustomerServicio();
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripBtnCustomers_Click(object sender, EventArgs e)
        {
            var fCustomersConsulta = new CustomersConsulta();
            fCustomersConsulta.ShowDialog();
        }

        private void toolStripBtnOrders_Click(object sender, EventArgs e)
        {
            var fOrdersConsulta = new OrdersConsulta();
            fOrdersConsulta.ShowDialog();
        }
    }
}

using labNetPractica3.EF.Logic.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica3.EF.UI.Presentations.Orders
{
    public partial class OrdersConsulta : Form
    {
        private OrderServicio ordersServicio = new OrderServicio();
        public OrdersConsulta()
        {
            InitializeComponent();
        }
        private void OrdersConsulta_Load(object sender, EventArgs e)
        {
            dgvOrders.DataSource = ordersServicio.GetAll();
        }
        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {

        }
        private void toolStripBtnDel_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

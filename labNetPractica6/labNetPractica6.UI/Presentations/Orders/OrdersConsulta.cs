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
        private int SelectEntity = 0;
        private string EntityName;
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
            var fNewOrder = new AltaOrder();
            fNewOrder.ShowDialog();
            dgvOrders.CurrentCell = null;
        }
        private void toolStripBtnDel_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idSeleccionado = int.Parse(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            var shipSeleccionado = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            var citySeleccionado = dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
            var regionSeleccionado = dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString();

            var fOrderUpdate = new ModificarOrder(idSeleccionado, shipSeleccionado, citySeleccionado, regionSeleccionado);
        }
    }
}

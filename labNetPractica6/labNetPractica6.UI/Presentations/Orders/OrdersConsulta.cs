using labNetPractica3.EF.Logic.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
            DataUpdate();
        }
        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            var fNewOrder = new AltaOrder();
            fNewOrder.ShowDialog();
            DataUpdate();
            dgvOrders.CurrentCell = null;
        }
        private void toolStripBtnDel_Click(object sender, EventArgs e)
        {
           if (SelectEntity == 0)
            {
                MessageBox.Show("Por favor seleccione un registro");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show($"Esta seguro que desea eliminar la orden ${EntityName} de forma permanente?"
                    , "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ordersServicio.Delete(SelectEntity);
                    DataUpdate();
                    SelectEntity = 0;
                    dgvOrders.CurrentCell = null;
                }
                else
                {
                    return;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("No tiene permisos para eliminar ese registro");
            }
            catch (Exception)
            {

                MessageBox.Show("Ya elimino ese registro, seleccione otro");
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idSeleccionado = int.Parse(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            var shipSeleccionado = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            var citySeleccionado = dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
            var regionSeleccionado = dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString();

            var fOrderUpdate = new ModificarOrder(idSeleccionado, shipSeleccionado, citySeleccionado, regionSeleccionado);

            fOrderUpdate.ShowDialog();
            DataUpdate();
            SelectEntity = 0;
            dgvOrders.CurrentCell = null;
        }

        private void DataUpdate()
        {
            dgvOrders.DataSource = ordersServicio.GetAll();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idSelec = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["ID"].Value);
                var shipName = dgvOrders.Rows[e.RowIndex].Cells["Ship"].Value.ToString();

                this.SelectEntity = idSelec;
                this.EntityName = shipName;
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una celda que contenga un registro");
                dgvOrders.CurrentCell = null;
            }
        }
    }
}

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
    public partial class ModificarOrder : Form
    {
        private OrderServicio orderServicio = new OrderServicio();
        public ModificarOrder(long id, string ship, string city, string region)
        {
            InitializeComponent();

            nudOrderUpdate.Value = id;
            nudOrderUpdate.Enabled = false;

            txtNombreShip.Text = ship;
            txtCityShip.Text = city;
            txtRegionShip.Text = region;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var OrderUpdate = new OrderDto()
                {
                    Id = (long)nudOrderUpdate.Value,
                    Ship = txtNombreShip.Text,
                    City = txtCityShip.Text,
                    Region = txtRegionShip.Text
                };

                orderServicio.Update(OrderUpdate);

                MessageBox.Show("La modificacion se realizo con exito");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor llene todos los campos");
            }
        }

        private void txtNombreShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCityShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtRegionShip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}

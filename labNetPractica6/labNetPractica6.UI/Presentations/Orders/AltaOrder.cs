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
    public partial class AltaOrder : Form
    {
        private OrderServicio orderServicio = new OrderServicio();
        public AltaOrder()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var newOrder = new OrderDto
                {
                    Ship = txtNombreShip.Text,
                    City = txtCityShip.Text,
                    Region = txtRegionShip.Text
                };

                orderServicio.Insert(newOrder);

                MessageBox.Show("Nueva orden agregado con exito");
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
        private void AltaOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

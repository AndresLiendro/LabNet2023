using labNetPractica3.EF.Logic.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labNetPractica3.EF.UI.Presentations.Customers
{
    public partial class ModificarCustomer : Form
    {
        private CustomerServicio customerServicio = new CustomerServicio();
        public ModificarCustomer(long id, string company, string contactName, string contactTitle)
        {
            InitializeComponent();

            nudCustomerUpdate.Value = id;
            nudCustomerUpdate.Enabled = false;

            txtCompanyName.Text = company;
            txtCompanyName.Text = contactName;
            txtContactTitle.Text = contactTitle;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var CustomerUpdate = new CustomerDto()
                {
                    Id = nudCustomerUpdate.ToString(),
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtCompanyName.Text,
                    ContactTitle = txtContactTitle.Text
                };

                customerServicio.Update(CustomerUpdate);
                MessageBox.Show("La modificacion se realizo con exito");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor llene todos los campos");
            }
        }

        private void txtCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContactTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}

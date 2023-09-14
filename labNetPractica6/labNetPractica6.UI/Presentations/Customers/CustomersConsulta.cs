using labNetPractica3.EF.Logic.Customer;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace labNetPractica3.EF.UI.Presentations.Customers
{
    public partial class CustomersConsulta : Form
    {
        private int EntidadId = 0;
        private string EntidadNombnre;
        private CustomerServicio customersServicio = new CustomerServicio();
        public CustomersConsulta()
        {
            InitializeComponent();
        }

        private void CustomersConsulta_Load(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            var fNuevoCustomer = new AltaCustomer();
            fNuevoCustomer.ShowDialog();
            DataUpdate();
            dgvCustomers.CurrentCell = null;

        }

        private void DataUpdate()
        {
            dgvCustomers.DataSource = customersServicio.GetAll();
        }

        private void toolStripBtnDel_Click(object sender, EventArgs e)
        {
            if (EntidadId == 0)
            {
                MessageBox.Show("Por favor seleccione un registro para eliminar.");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show($"Esta seguro que desea eliminar el cliente ${EntidadNombnre} de forma permanente?"
                    , "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customersServicio.Delete(EntidadId);
                    DataUpdate();
                    EntidadId = 0;
                    dgvCustomers.CurrentCell = null;
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

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dgvCustomers.Rows[e.RowIndex].Cells["ID"].Value;

            if (cellValue != null && int.TryParse(cellValue.ToString(), out int idSelec))
            {
                var companyName = dgvCustomers.Rows[e.RowIndex].Cells["Company Name"].Value.ToString();

                this.EntidadId = idSelec;
                this.EntidadNombnre = companyName;
            }
        }
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dgvCustomers.Rows[e.RowIndex].Cells["ID"].Value;

            if ((cellValue != null) && int.TryParse(cellValue.ToString(), out int idSelec))
            {
                var companyNameSeleccionado = dgvCustomers.Rows[e.RowIndex].Cells["Company Name"].Value.ToString();
                var contactNameSeleccionado = dgvCustomers.Rows[e.RowIndex].Cells["Contact Name"].Value.ToString();
                var contactTitleSeleccionado = dgvCustomers.Rows[e.RowIndex].Cells["Contact Title"].Value.ToString();

                var fModificarCustomer = new ModificarCustomer(idSelec, companyNameSeleccionado, contactNameSeleccionado, contactTitleSeleccionado);

                fModificarCustomer.ShowDialog();
                DataUpdate();
                EntidadId = 0;

                dgvCustomers.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("Seleccione un registro para poder modificarlo");
            }
        }
    }
}

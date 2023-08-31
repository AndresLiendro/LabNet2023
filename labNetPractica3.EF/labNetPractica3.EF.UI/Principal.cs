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

namespace labNetPractica3.EF.UI
{
    public partial class Principal : Form
    {
        private CustomersServicio customerServicio = new CustomersServicio();
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
    }
}

﻿using labNetPractica3.EF.Logic.Customer;
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
    public partial class CustomersConsulta : Form
    {
        private CustomerServicio customersServicio = new CustomerServicio();
        public CustomersConsulta()
        {
            InitializeComponent();
        }

        private void CustomersConsulta_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = customersServicio.GetAll();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

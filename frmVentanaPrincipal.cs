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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void estructurasNoLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador datoDesarrollador = new frmDatosDesarrollador();
            this.Hide();
            datoDesarrollador.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCola Cola = new frmCola();
            this.Hide();
            Cola.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEstucturaListaSimple ListaSimple = new frmEstucturaListaSimple();
            this.Hide();
            ListaSimple.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraPila Pila = new frmEstructuraPila();
            this.Hide();
            Pila.Show();
        }
    }
}
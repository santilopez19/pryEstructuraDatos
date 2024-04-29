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
            datoDesarrollador.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmArbolBinario Arbol = new frmArbolBinario();
            Arbol.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCola Cola = new frmCola();
            Cola.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraPila Pila = new frmEstructuraPila();
            Pila.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble Doble = new frmListaDoble();
            Doble.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstucturaListaSimple Simple = new frmEstucturaListaSimple();
            Simple.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
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
    public partial class frmEstucturaListaSimple : Form
    {
        public frmEstucturaListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer();


            lblCodigoNuevo.Text = "";
            lblNombreNuevo.Text = "";
            lblTramiteNuevo.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cmbLista);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia.");

            }
            btnEliminar.Enabled = false;
        }
    }
}

using System;
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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonas = new clsCola();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvLista);
            FilaDePersonas.Recorrer(lstCola);
            FilaDePersonas.Recorrer();
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtCodigoEliminado.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtNombreEliminado.Text = FilaDePersonas.Primero.Nombre;
                txtTramiteEliminado.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvLista);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                txtCodigoEliminado.Text = "";
                txtNombreEliminado.Text = "";
                txtTramiteEliminado.Text = "";
            }
        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
        }
    }
}

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
    public partial class frmEstructuraPila : Form
    {
        public frmEstructuraPila()
        {
            InitializeComponent();
        }

        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            Pila.Agregar(ObjNodo);
            Pila.Recorrer(dgvLista);
            Pila.Recorrer(lstPila);
            Pila.Recorrer();
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (Pila.Primero != null)
            {
                txtCodigoEliminado.Text = Pila.Primero.Codigo.ToString();
                txtNombreEliminado.Text = Pila.Primero.Nombre;
                txtTramiteEliminado.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvLista);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
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

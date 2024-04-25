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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }
        clsListaDoble filaListaDoble = new clsListaDoble();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (chkAscendente.Checked)
            {
                if (filaListaDoble.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cmbListaDoble.Text);
                    filaListaDoble.Eliminar(x);
                    filaListaDoble.Recorrer(dgvListaDoble);
                    filaListaDoble.Recorrer(lstListaDoble);
                    filaListaDoble.Recorrer(cmbListaDoble);
                    filaListaDoble.Recorrer();
                    cmbListaDoble.Text = "";
                }
                else
                {
                    MessageBox.Show("La lista esta vacia");
                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                if (filaListaDoble.Ultimo != null)
                {
                    Int32 x = Convert.ToInt32(cmbListaDoble.Text);
                    filaListaDoble.Eliminar(x);
                    filaListaDoble.RecorrerDes(dgvListaDoble);
                    filaListaDoble.RecorrerDes(lstListaDoble);
                    filaListaDoble.RecorrerDes(cmbListaDoble);
                    filaListaDoble.RecorrerDes();
                    cmbListaDoble.Text = "";
                }
                else
                {
                    MessageBox.Show("La lista esta vacia");
                    btnEliminar.Enabled = false;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            objNodo.Nombre = txtNombreNuevo.Text;
            objNodo.Tramite = txtTramiteNuevo.Text;
            filaListaDoble.Agregar(objNodo);
            filaListaDoble.Recorrer(dgvListaDoble);
            filaListaDoble.Recorrer(lstListaDoble);
            filaListaDoble.Recorrer(cmbListaDoble);
            filaListaDoble.Recorrer();
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }
    }
}

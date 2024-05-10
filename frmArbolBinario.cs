using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        private clsArbolBinario arbol = new clsArbolBinario(); // Declaración e inicialización del árbol binario
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramiteNuevo.Text;
            Arbol.AgregarArbolBinario(ObjNodo);
            Arbol.RecorrerArbolBinario(dgvLista);
            Arbol.RecorrerArbolBinario(cmbCodigo);
            Arbol.RecorrerArbolBinario(trvArbol);
            Arbol.RecorrerArbolBinario(lstArbolBinario);
            //Arbol.RecorrerListaDoble();//Falta programar crear el csv
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramiteNuevo.Text = "";
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            
                Arbol.Equilibrar();
                Arbol.RecorrerArbolBinario(trvArbol);
            
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerArbolBinario(dgvLista);
                Arbol.RecorrerArbolBinario(cmbCodigo);
                Arbol.RecorrerArbolBinario(lstArbolBinario);
                Arbol.RecorrerArbolBinario(trvArbol);
            }
            else
            {
                MessageBox.Show("El árbol esta vacío.");
            }
            cmbCodigo.Text = "";
            btnEliminar.Enabled = false;
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {

            Arbol.RecorrerArbolPostOrden(dgvLista);
            Arbol.RecorrerArbolPostOrden(lstArbolBinario);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolPreOrden(dgvLista);
            Arbol.RecorrerArbolPreOrden(lstArbolBinario);
        }

        private void optInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolDesc(dgvLista);
            Arbol.RecorrerArbolDesc(cmbCodigo);
            Arbol.RecorrerArbolDesc(lstArbolBinario);
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolBinario(dgvLista);
            Arbol.RecorrerArbolBinario(cmbCodigo);
            Arbol.RecorrerArbolBinario(lstArbolBinario);
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void txtTramiteNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigoNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != "" && txtNombreNuevo.Text != "" && txtTramiteNuevo.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
        }
    }
}

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = null;
                while (aux != null && aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux != null)
                {
                    if (ant == null)
                    {
                        Primero = Primero.Siguiente;
                        Primero.Anterior = null;
                    }
                    else
                    {
                        ant.Siguiente = aux.Siguiente;
                        if (aux.Siguiente != null)
                        {
                            aux.Siguiente.Anterior = ant;
                        }
                    }
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = ant;
                    }
                }
            }
        }
    }
}

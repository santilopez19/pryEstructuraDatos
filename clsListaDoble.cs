using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        { 
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if(Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;

            }
            else
            {
                if(Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;

                }
                else
                {
                    if(Nvo.Codigo>Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else 
                    {
                        clsNodo Sig = Primero;
                        clsNodo Ant = Primero;

                        while(Sig.Codigo<Nvo.Codigo)
                        {
                            Ant = Sig; 
                            Sig = Sig.Siguiente;
                            
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente= Sig;
                        Sig.Anterior = Nvo;
                        Nvo.Anterior = Ant;
                    }
                }
            }
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while(aux!=null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
    }
}

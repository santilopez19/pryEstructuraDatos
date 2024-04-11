﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        //Campos del Nodo
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;

        //Propiedades del Nodo

        public Int32 Codigo
            { get { return cod; } 
            set { cod = value; } }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

    }
}

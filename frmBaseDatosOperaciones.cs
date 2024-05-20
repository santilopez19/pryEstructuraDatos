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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void button3_Click(object sender, EventArgs e)
        {
            //Multiatributo
            String varSQL = "SELECT TITULO, IDAUTOR, CANTIDAD " + "FROM LIBRO " + "ORDER BY 1 DESC"; 


            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //JUNTAR
            String varSQL = "SELECT * " + "FROM LIBRO, AUTOR";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " + "FROM LIBRO " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void frmBaseDatosOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CONVOLUCION
            String varSQL = "SELECT * " +
                "FROM (SELECT * FROM LIBRO AS T1 WHERE T1.IDIDIOMA >5) "+
                "AS T2 WHERE T2.IDAUTOR >10";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SELECCION SIMPLE
            String varSQL = "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 2";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SELECCION MULTIATRIBUTO
            String varSQL = "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR > 2 AND IDPAIS < 8 ";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //UNUION
            String varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 "+
                             "UNION SELECT* FROM Libro WHERE IdAutor = 5 "+
                             "UNION SELECT* FROM Libro WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * "+
                            "FROM Libro " +" WHERE IdIdioma "+
                            "IN(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //DIFERENCIA
            String varSQL = "SELECT * " +
                            "FROM Libro " + " WHERE IdIdioma " +
                            "NOT IN(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }
    }
}

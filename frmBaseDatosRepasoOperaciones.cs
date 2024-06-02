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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {

        private clsBaseDatos objBaseDatos = new clsBaseDatos();
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[]
            {
                "SELECT * FROM LIBRO ORDER BY TITULO DESC",
                "SELECT * FROM LIBRO, AUTOR",
                "SELECT TITULO FROM LIBRO ORDER BY TITULO DESC",
                "SELECT * FROM (SELECT * FROM LIBRO AS T1 WHERE T1.IDIDIOMA > 5) AS T2 WHERE T2.IDAUTOR > 10",
                "SELECT * FROM LIBRO WHERE IDAUTOR = 2",
                "SELECT * FROM LIBRO WHERE IDAUTOR > 2 AND IDPAIS < 8",
                "SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3",
                "SELECT * FROM Libro WHERE IdIdioma IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)",
                "SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)",
                "SELECT * FROM Libro WHERE IdAutor BETWEEN 2 AND 5",
                "SELECT * FROM Libro WHERE Titulo LIKE '%aventura%'",
                "SELECT COUNT(*) FROM Libro",
                "SELECT AVG(Precio) FROM Libro",
                "SELECT * FROM Libro WHERE FechaPublicacion >= '2020-01-01'",
                "SELECT * FROM Libro WHERE Idioma = 'Español'",
                "SELECT DISTINCT Idioma FROM Libro",
                "SELECT Titulo, Autor FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.Id",
                "SELECT * FROM Libro ORDER BY Precio DESC LIMIT 10",
                "SELECT * FROM Libro WHERE Precio BETWEEN 10 AND 20"
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la consulta SQL seleccionada
            string consultaSQL = comboBox1.SelectedItem.ToString();

            // Actualizar el label con una breve explicación de la operación
            ActualizarExplicacion(consultaSQL);

            // Ejecutar la consulta y mostrar los resultados en el DataGridView
            objBaseDatos.Listar(dvgOperacion, consultaSQL);
        }

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }
        private void ActualizarExplicacion(string consultaSQL)
        {
            // Breve explicación de cada operación
            string explicacion = "";
            switch (consultaSQL)
            {
                case "SELECT * FROM LIBRO ORDER BY TITULO DESC":
                    explicacion = "Mostrar todos los libros ordenados por título de forma descendente.";
                    break;
                case "SELECT * FROM LIBRO, AUTOR":
                    explicacion = "Mostrar todos los libros con sus respectivos autores.";
                    break;
                case "SELECT TITULO FROM LIBRO ORDER BY TITULO DESC":
                    explicacion = "Mostrar los títulos de todos los libros ordenados por título de forma descendente.";
                    break;
                case "SELECT * FROM (SELECT * FROM LIBRO AS T1 WHERE T1.IDIDIOMA > 5) AS T2 WHERE T2.IDAUTOR > 10":
                    explicacion = "Mostrar los libros cuyo ID de idioma sea mayor que 5 y cuyo ID de autor sea mayor que 10.";
                    break;
                case "SELECT * FROM LIBRO WHERE IDAUTOR = 2":
                    explicacion = "Mostrar todos los libros escritos por el autor con ID 2.";
                    break;
                case "SELECT * FROM LIBRO WHERE IDAUTOR > 2 AND IDPAIS < 8":
                    explicacion = "Mostrar todos los libros cuyo ID de autor sea mayor que 2 y cuyo ID de país sea menor que 8.";
                    break;
                case "SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3":
                    explicacion = "Mostrar todos los libros escritos por los autores con ID 2, 5 y 3.";
                    break;
                case "SELECT * FROM Libro WHERE IdIdioma IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)":
                    explicacion = "Mostrar todos los libros cuyo ID de idioma esté incluido en los ID de idioma menores que 5.";
                    break;
                case "SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)":
                    explicacion = "Mostrar todos los libros cuyo ID de idioma no esté incluido en los ID de idioma menores que 5.";
                    break;
                case "SELECT * FROM Libro WHERE IdAutor BETWEEN 2 AND 5":
                    explicacion = "Mostrar todos los libros escritos por autores cuyos ID estén entre 2 y 5.";
                    break;
                case "SELECT * FROM Libro WHERE Titulo LIKE '%aventura%'":
                    explicacion = "Mostrar todos los libros cuyo título contenga la palabra 'aventura'.";
                    break;
                case "SELECT COUNT(*) FROM Libro":
                    explicacion = "Contar el número total de libros en la base de datos.";
                    break;
                case "SELECT AVG(Precio) FROM Libro":
                    explicacion = "Calcular el precio promedio de todos los libros.";
                    break;
                case "SELECT * FROM Libro WHERE FechaPublicacion >= '2020-01-01'":
                    explicacion = "Mostrar todos los libros publicados a partir del 1 de enero de 2020.";
                    break;
                case "SELECT * FROM Libro WHERE Idioma = 'Español'":
                    explicacion = "Mostrar todos los libros escritos en español.";
                    break;
                case "SELECT DISTINCT Idioma FROM Libro":
                    explicacion = "Mostrar todos los idiomas únicos disponibles en los libros.";
                    break;
                case "SELECT Titulo, Autor FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.Id":
                    explicacion = "Mostrar los títulos de los libros junto con los nombres de los autores.";
                    break;
                case "SELECT * FROM Libro ORDER BY Precio DESC LIMIT 10":
                    explicacion = "Mostrar los 10 libros con el precio más alto.";
                    break;
                case "SELECT * FROM Libro WHERE Precio BETWEEN 10 AND 20":
                    explicacion = "Mostrar todos los libros con un precio entre 10 y 20.";
                    break;
                default:
                    explicacion = "Explicación no disponible.";
                    break;
            }
            lblOperacion.Text = explicacion;
        }
    }
}

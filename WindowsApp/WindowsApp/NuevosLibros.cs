using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO.CLASES;

namespace WindowsApp
{
    public partial class NuevosLibros : Form
    {

        private bool alta;
        public Libros Libros { get; set; }
        public NuevosLibros(bool alta = true, Libros libros = null)
        {
            InitializeComponent();

            this.alta = alta;
            if (alta)
            {
                this.Text = "Nuevo Libro";
            }
            else
            {
                this.Text = "Modificar Libro";
            }
            Libros = libros;
            if (libros != null)
            {
                txtAutor.Text = libros.Autor;
                txtGenero.Text = libros.Genero;
                txtTitulo.Text = libros.Titulo;
                calFecha.SelectionStart= libros.AñoPublicacion;
                cmbLectura.Text = libros.Lectura;
                cmbPuntaje.Text = libros.Puntaje.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)

        {

            if (String.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("El Titulo no puede estar vacio, Agregue el titulo de su libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("El Autor no puede estar vacio, Agregue el nombre de el autor del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtGenero.Text))
            {
                MessageBox.Show("El Genero no puede estar vacio, Agregue el genero de su libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (alta)
            {

                Libros = new Libros();
                Libros.Titulo = txtTitulo.Text;
                Libros.Autor = txtAutor.Text;
                Libros.Genero = txtGenero.Text;
                Libros.AñoPublicacion = calFecha.SelectionStart;
                Libros.Lectura = cmbLectura.Text;
                Libros.Puntaje = Convert.ToInt32(cmbPuntaje.SelectedItem);



            }
            else
            {
                Libros.Titulo = txtTitulo.Text;
                Libros.Autor = txtAutor.Text;
                Libros.Genero = txtGenero.Text;
                Libros.AñoPublicacion = calFecha.SelectionStart;
                Libros.Lectura = cmbLectura.Text;
                Libros.Puntaje = Convert.ToInt32(cmbPuntaje.SelectedItem);


            }



                DialogResult = DialogResult.OK;
            
            Close();    
        }

        private void NuevosLibros_Load(object sender, EventArgs e)
        {
            cmbLectura.Items.Add("Leido");
            cmbLectura.Items.Add("No Leido");

            int numero = 1;
            while (numero <= 10)
            {
                cmbPuntaje.Items.Add(numero);
                numero++;
            }
            
            cmbLectura.SelectedIndex = 0;


           


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Puntaje_Click(object sender, EventArgs e)
        {

        }
    }
}

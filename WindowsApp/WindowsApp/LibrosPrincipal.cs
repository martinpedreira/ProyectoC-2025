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
using POO.IMPLEMENTACIONES;
using POO.INTERFACES;

namespace WindowsApp
{
    public partial class LibrosPrincipal : Form

    {
        private ILibrosDao daoLibros = new LibrosSqlServerDao();
        public LibrosPrincipal()
        {
            InitializeComponent();
        }

        

        

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = daoLibros.ObtenerTodos();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevosLibros nuevoslibros = new NuevosLibros();


            if (nuevoslibros.ShowDialog() == DialogResult.OK)
            {
                Libros librosNuevos = nuevoslibros.Libros;
                daoLibros.Agregar(librosNuevos);
                if (librosNuevos.Id > 0)
                {
                    MessageBox.Show("Libro Agregado correctamente");
                }
                

                
            }
            else
                MessageBox.Show("Operacion Cancelada");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 1)
            {
                Libros libros = dgvLibros.SelectedRows[0].DataBoundItem as Libros;
                NuevosLibros nuevoslibros = new NuevosLibros(false, libros);


                if(nuevoslibros.ShowDialog() == DialogResult.OK)
                {
                    daoLibros.Modificar(nuevoslibros.Libros);

                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una sola fila");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 1)
            {
                Libros libros = dgvLibros.SelectedRows[0].DataBoundItem as Libros;
                if (MessageBox.Show($"¿Desea eliminar el libro {libros.Titulo}?", "Confirmacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (daoLibros.Eliminar(libros.Id) == 1)
                    {
                        MessageBox.Show("Libro eliminado correctamente");
                        RefrescarGrilla();


                    }

                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion");
                }
            }
        }

        private void btnObtenerPorId_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                Libros libros = daoLibros.ObtenerPorId(id);
                if (libros != null)
                {
                    MessageBox.Show($" El Libro {libros} fue encontrado!");
                }
                else
                {
                    MessageBox.Show("No encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID valido", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }

        private void btnObtenerPorAutor_Click(object sender, EventArgs e)
        {
            List<Libros> libros= new List<Libros>();
            libros = daoLibros.ObtenerPorAutor(txtAutor.Text);

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;


        }

        private void btnObtenerPorLectura_Click(object sender, EventArgs e)
        {
            List<Libros> libros = new List<Libros>();
            libros = daoLibros.ObtenerPorLectura(cmbObtenerPorLectura.Text);

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
        }

        private void dgvLibros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLibros.Columns[e.ColumnIndex].Name == "Puntaje" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int puntaje))
                {
                    if (puntaje >= 6)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    else if (puntaje >= 4 && puntaje <= 5)
                    {
                        e.CellStyle.BackColor = Color.Khaki;
                    }
                    else if (puntaje >= 1 && puntaje <= 3)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void LibrosPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;

            btnNuevo.BackColor = Color.LightSteelBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnTraerTodo.BackColor = Color.LightSteelBlue;
            btnTraerTodo.FlatStyle = FlatStyle.Flat;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnModificar.BackColor = Color.LightSteelBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;

            btnObtenerPorAutor.BackColor = Color.Khaki;
            btnObtenerPorAutor.FlatStyle = FlatStyle.Flat;
            btnObtenerPorId.BackColor = Color.Khaki;
            btnObtenerPorId.FlatStyle = FlatStyle.Flat;
            btnObtenerPorLectura.BackColor = Color.Khaki;
            btnObtenerPorLectura.FlatStyle = FlatStyle.Flat;
        }
    }
}

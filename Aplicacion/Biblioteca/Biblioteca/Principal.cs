using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Principal : Form
    {
        bibliotecaEntities biblioteca = new bibliotecaEntities();
        public void settearNombre(string usuario)
        {
            lbUser.Text = usuario;
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public int recursivo()
        {
            txtDNI.Text = biblioteca.tbClientes.Find(int.Parse(txtCodCli.Text)).tbPersona.dni.ToString();
            txtNomCli.Text = biblioteca.tbClientes.Find(int.Parse(txtCodCli.Text)).tbPersona.nombre;
            txtApeCli.Text = biblioteca.tbClientes.Find(int.Parse(txtCodCli.Text)).tbPersona.apellidoPaterno + " " + biblioteca.tbClientes.Find(int.Parse(txtCodCli.Text)).tbPersona.apellidoMaterno;
            txtDirCli.Text = biblioteca.tbClientes.Find(int.Parse(txtCodCli.Text)).tbPersona.direccion;
            listaLibros.Items.Clear();
            DataTable dt = new DataTable();
            dt.Columns.Add("Libro");
            dt.Columns.Add("Fecha Prestamo");
            dt.Columns.Add("Fecha Devolucion");
            dGVCliente.DataSource = dt;
            dGVCliente.Columns[0].Width = 300;
            int devolucion = 0;

            DataRow row = dt.NewRow();

            dt.Rows.Clear();
            foreach (var item in biblioteca.tbHistoricoes)
            {
                if (item.idCliente.ToString() == txtCodCli.Text)
                {
                    dt.Rows.Add(biblioteca.tbLibroes.Find(item.idLibro).nombre, item.fechaPrestamo, item.fechaDevolucion);
                    if (item.fechaDevolucion == null)
                    {
                        listaLibros.Items.Add(biblioteca.tbLibroes.Find(item.idLibro).nombre);
                        devolucion++;
                    }                   
                }

            }
            if (devolucion != 0)
            {
                panelLibro.Visible = false;
            }
            else
            {
                panelLibro.Visible = true;
            }
            return devolucion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recursivo() != 0)
                {
                    MessageBox.Show("Debe libros!! No se puede prestar", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {                
                if (MessageBox.Show("Codigo de usuario no registrado ingrese nuevamente, o ¿Desea ingresar un nuevo usuario?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    AddUser addUser = new AddUser();
                    addUser.Show();
                    this.Hide();
                }
            }            
        }
        private void btnBuscarLi_Click(object sender, EventArgs e)
        {
            try
            {
                txtNomLi.Text = biblioteca.tbLibroes.Find(int.Parse(txtCodLi.Text)).nombre;
                txtAutLi.Text = biblioteca.tbLibroes.Find(int.Parse(txtCodLi.Text)).autor;
                txtCatLi.Text = biblioteca.tbLibroes.Find(int.Parse(txtCodLi.Text)).tbCategoria.descCategoria;

                if (biblioteca.tbLibroes.Find(int.Parse(txtCodLi.Text)).estado)
                {
                    btnPrestar.Visible = true;
                    errorProvider1.SetError(txtNomLi,"");
                }
                else
                {
                    btnPrestar.Visible = false;
                    errorProvider1.SetError(txtNomLi, "LIBRO NO DISPONIBLE");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Codigo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimpiarPrestarLibro()
        {
            txtAutLi.Clear();
            txtCatLi.Clear();
            txtCodLi.Clear();
            txtDNI.Clear();
            txtNomLi.Clear();
        }
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregando el registro del alquiler de libro
                tbHistorico tbHistorico = new tbHistorico { idCliente = int.Parse(txtCodCli.Text), idLibro = int.Parse(txtCodLi.Text), fechaPrestamo = DateTime.Now };
                biblioteca.tbHistoricoes.Add(tbHistorico);

                //Actualizando libro para ponerlo no disponible
                tbLibro tbLibro = biblioteca.tbLibroes.Find(int.Parse(txtCodLi.Text));
                tbLibro.estado = false;

                //Guardando cambios en la base de datos
                biblioteca.SaveChanges();
                //limpiar todos los campos
                LimpiarPrestarLibro();
                recursivo();
                MessageBox.Show("Se creo el prestamo, entregue el libro", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error en el codigo de libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in biblioteca.tbLibroes)
                {
                    if(listaLibros.SelectedItem.ToString() == item.nombre)
                    {
                        //cambiamos el estado a "disponible"
                        tbLibro tbLibro = biblioteca.tbLibroes.Find(item.id);
                        tbLibro.estado = true;
                        foreach (var item2 in biblioteca.tbHistoricoes)
                        {
                            if (item.id == item2.idLibro)
                            {
                                //modificamos el historico agregando la fecha de devolucion
                                tbHistorico tbHistorico = biblioteca.tbHistoricoes.Find(item2.id);
                                tbHistorico.fechaDevolucion = DateTime.Now;
                            }
                        }                        
                    }

                }
                MessageBox.Show("Devolucion agregada con exito, ya puede sacar otro libro", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recursivo();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono ningun libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }
    }
}

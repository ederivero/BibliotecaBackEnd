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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        bibliotecaEntities biblioteca = new bibliotecaEntities();
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de crear nuevo cliente", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    //Agregamos primero a la tabla persona
                    tbPersona tbPersona = new tbPersona { dni = int.Parse(txtDNI.Text), nombre = txtNombre.Text, apellidoPaterno = txtApePa.Text, apellidoMaterno = txtApeMa.Text, direccion = txtDir.Text };
                    biblioteca.tbPersonas.Add(tbPersona);
                    //biblioteca.SaveChanges();
                    //Y ahora lo asignamos como un cliente agregando su dni en la tabla tbCliente
                    tbCliente tbCliente = new tbCliente { dni = tbPersona.dni };
                    biblioteca.tbClientes.Add(tbCliente);
                    biblioteca.SaveChanges();
                    foreach (var item in biblioteca.tbClientes)
                    {
                        if (item.dni == tbCliente.dni)
                            MessageBox.Show("Cliente creado con exito con Codigo: " + item.id, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Principal p = new Principal();
                    p.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error desconocido, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

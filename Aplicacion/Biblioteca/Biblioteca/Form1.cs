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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bibliotecaEntities biblioteca = new bibliotecaEntities();
        private void btnLoggin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == biblioteca.tbUsuarios.Find(int.Parse(txtUser.Text)).tbPersona.password)
                {                 
                    Principal p = new Principal();
                    p.settearNombre(biblioteca.tbUsuarios.Find(int.Parse(txtUser.Text)).tbPersona.nombre);
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoParcial
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMensaje_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario1.Text.Trim();
            string clave = textBoxContraseña1.Text;

            using (var connection = new SqlConnection(@"Data Source=LAPTOP-0I8HCQGL\SQLEXPRESS;Initial Catalog=Parcial02;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Clave = @Clave";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario);
                    command.Parameters.AddWithValue("@Clave", clave);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        labelMensaje.Text = "Usuario o clave incorrectos";
                        labelMensaje.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}

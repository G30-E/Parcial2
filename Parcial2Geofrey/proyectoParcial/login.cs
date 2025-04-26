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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario1.Text.Trim(); // Fixed missing parentheses for Trim()  
            string clave = textBoxContra1.Text;

            using (var connection = new SqlConnection(@"Data Source=LAPTOP-0I8HCQGL\SQLEXPRESS;Initial Catalog=Parcial02;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @Nombre AND clave = @Clave"; // Fixed query syntax  

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario); // Fixed method name to AddWithValue  
                    command.Parameters.AddWithValue("@Clave", clave); // Fixed method name to AddWithValue  

                    int count = (int)command.ExecuteScalar(); // Execute query and get result  

                    if (count > 0)
                    {
                        this.Hide();
                        new Form1().Show();
                        //MessageBox.Show("Inicio de sesión exitoso.");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
        }

        private void textBoxUsuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContra1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using MinecraftManager.Models;
using MinecraftManager.Services;
using proyectoParcial.Utils;
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
    public partial class Form2Jugadores : Form
    {
        private Form1 formPrincipal;
        private readonly JugadorService jugadorService;
        public Form2Jugadores(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            jugadorService = new JugadorService(new DatabaseManager());
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            dataGridView1.DataSource = jugadorService.ObtenerTodos();
        }

        private void buttonRegresarM_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();

        }    

        private void LimpiarCampos()
        {
            textBoxIDjugador.Clear();
            textBoxNombreJugadores.Clear();
            textBoxNivelJugadores.Clear();
        }

        private void textBoxIDjugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2Jugadores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                textBoxIDjugador.Text = row.Cells["Id"].Value.ToString();
                textBoxNombreJugadores.Text = row.Cells["Nombre"].Value.ToString();
                textBoxNivelJugadores.Text = row.Cells["Nivel"].Value.ToString();

            }

        }

        private void buttonEliminarJ_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxIDjugador.Text);
                jugadorService.Eliminar(id);
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar jugador: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarJ_Click_1(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador
                {
                    Nombre = textBoxNombreJugadores.Text,
                    Nivel = int.Parse(textBoxNivelJugadores.Text)
                };

                jugadorService.Crear(jugador);
                MessageBox.Show("Jugador agregado con éxito.");
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar jugador: " + ex.Message);
            }
        }

        private void buttonModificarJ_Click_1(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador
                {
                    Id = int.Parse(textBoxIDjugador.Text),
                    Nombre = textBoxNombreJugadores.Text,
                    Nivel = int.Parse(textBoxNivelJugadores.Text)
                };

                jugadorService.Actualizar(jugador);
                MessageBox.Show("Jugador actualizado.");
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar jugador: " + ex.Message);
            }
        }
    }
}
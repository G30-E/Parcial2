using Microsoft.Data.SqlClient;
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
using ClosedXML.Excel;
using MinecraftManager.Models;

namespace proyectoParcial
{
    public partial class Inventario1 : Form
    {
        private Form1 formPrincipal;
        private InventarioService ges_inventarioService;
        private BloqueService ges_bloqueService;
        private JugadorService ges_jugadorService;

        public Inventario1(Form1 formPrincipal)

        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            var db = new DatabaseManager();
            ges_jugadorService = new JugadorService(db);
            ges_bloqueService = new BloqueService(db);
            ges_inventarioService = new InventarioService(db, ges_jugadorService, ges_bloqueService);

            comboBoxInventario.Items.AddRange(new string[] { "Todos", "Común", "Raro", "Épico" });
            comboBoxInventario.SelectedIndex = 0;
            comboBoxInventario.SelectedIndexChanged += Filtrar;

            MostrarInventario("Todos");
        }

        private void Filtrar(object sender, EventArgs e)
        {
            string seleccion = comboBoxInventario.SelectedItem.ToString();
            MostrarInventario(seleccion);
        }

        private void MostrarInventario(string rareza)
        {
            var inventario = ges_inventarioService.ObtenerTodos();
            if (rareza != "Todos")
            {
                var bloques = ges_bloqueService.BuscarPorRareza(rareza).Select(b => b.Id).ToList();
                inventario = inventario.Where(i => bloques.Contains(i.BloqueId)).ToList();
            }
             var vista = inventario.Select(i =>
            { 
            var bloque = ges_bloqueService.ObtenerPorId(i.BloqueId);
            var jugador = ges_jugadorService.ObtenerPorId(i.JugadorId);
            return new
            {
                Jugador = jugador?.Nombre ?? "Desconocido",
                Nivel = jugador?.Nivel ?? 0,
                Bloque = bloque?.Nombre ?? "Desconocido",
                tipo = bloque?.Tipo ?? "Desconocido",
                Rareza = bloque?.Rareza ?? "Desconocido",
                Cantidad = i.Cantidad
            };
        }).ToList();
        dataGridViewInventario.DataSource = vista;
    }






        private void Inventario1_Load(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labelTexto_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {

            var confirmacion = MessageBox.Show("¿confirmar que si desea exportar el inventario a Excel","confirmar exportacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            using (var connection = new SqlConnection(@"Data Source=LAPTOP-0I8HCQGL\SQLEXPRESS;Initial Catalog=Parcial02;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Bloques", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "Bloques");

                    var guardar = new SaveFileDialog();
                    guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                    guardar.FileName = "TablaBloques.xlsx";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(guardar.FileName);
                        MessageBox.Show("¡Tabla de bloques exportada con exito");
                    }


                }




            }




        }
    }
}

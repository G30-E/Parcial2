namespace proyectoParcial
{
    partial class Inventario1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxInventario = new ComboBox();
            labelTitulo = new Label();
            buttonExportar = new Button();
            dataGridViewInventario = new DataGridView();
            labelTexto = new Label();
            buttonRegresarMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            SuspendLayout();
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(27, 145);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(207, 28);
            comboBoxInventario.TabIndex = 0;
            comboBoxInventario.SelectedIndexChanged += comboBoxInventario_SelectedIndexChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(50, 20);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "label1";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // buttonExportar
            // 
            buttonExportar.Location = new Point(618, 362);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(109, 48);
            buttonExportar.TabIndex = 2;
            buttonExportar.Text = "Exportar a Excel ";
            buttonExportar.UseVisualStyleBackColor = true;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(379, 30);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.RowHeadersWidth = 51;
            dataGridViewInventario.Size = new Size(366, 313);
            dataGridViewInventario.TabIndex = 3;
            dataGridViewInventario.CellContentClick += dataGridViewInventario_CellContentClick;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Location = new Point(27, 112);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(207, 20);
            labelTexto.TabIndex = 4;
            labelTexto.Text = "Selecciona Por Tipo O Rareza ";
            labelTexto.Click += labelTexto_Click;
            // 
            // buttonRegresarMenu
            // 
            buttonRegresarMenu.Location = new Point(12, 403);
            buttonRegresarMenu.Name = "buttonRegresarMenu";
            buttonRegresarMenu.Size = new Size(202, 35);
            buttonRegresarMenu.TabIndex = 5;
            buttonRegresarMenu.Text = "Regresar al menu principal ";
            buttonRegresarMenu.UseVisualStyleBackColor = true;
            buttonRegresarMenu.Click += buttonRegresarMenu_Click;
            // 
            // Inventario1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresarMenu);
            Controls.Add(labelTexto);
            Controls.Add(dataGridViewInventario);
            Controls.Add(buttonExportar);
            Controls.Add(labelTitulo);
            Controls.Add(comboBoxInventario);
            Name = "Inventario1";
            Text = "Inventario1";
            Load += Inventario1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxInventario;
        private Label labelTitulo;
        private Button buttonExportar;
        private DataGridView dataGridViewInventario;
        private Label labelTexto;
        private Button buttonRegresarMenu;
    }
}
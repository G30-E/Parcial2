namespace proyectoParcial
{
    partial class Form2Jugadores
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
            label1 = new Label();
            label2 = new Label();
            textBoxIDjugador = new TextBox();
            label3 = new Label();
            textBoxNombreJugadores = new TextBox();
            label4 = new Label();
            textBoxNivelJugadores = new TextBox();
            buttonAgregarJ = new Button();
            buttonModificarJ = new Button();
            buttonEliminarJ = new Button();
            buttonRegresarM = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Jugadores";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // textBoxIDjugador
            // 
            textBoxIDjugador.Location = new Point(91, 113);
            textBoxIDjugador.Margin = new Padding(3, 4, 3, 4);
            textBoxIDjugador.Name = "textBoxIDjugador";
            textBoxIDjugador.Size = new Size(266, 27);
            textBoxIDjugador.TabIndex = 2;
            textBoxIDjugador.TextChanged += textBoxIDjugador_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // textBoxNombreJugadores
            // 
            textBoxNombreJugadores.Location = new Point(91, 165);
            textBoxNombreJugadores.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreJugadores.Name = "textBoxNombreJugadores";
            textBoxNombreJugadores.Size = new Size(266, 27);
            textBoxNombreJugadores.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 227);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Nivel";
            // 
            // textBoxNivelJugadores
            // 
            textBoxNivelJugadores.Location = new Point(91, 227);
            textBoxNivelJugadores.Margin = new Padding(3, 4, 3, 4);
            textBoxNivelJugadores.Name = "textBoxNivelJugadores";
            textBoxNivelJugadores.Size = new Size(266, 27);
            textBoxNivelJugadores.TabIndex = 6;
            // 
            // buttonAgregarJ
            // 
            buttonAgregarJ.Location = new Point(27, 318);
            buttonAgregarJ.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarJ.Name = "buttonAgregarJ";
            buttonAgregarJ.Size = new Size(86, 31);
            buttonAgregarJ.TabIndex = 7;
            buttonAgregarJ.Text = "Agregar";
            buttonAgregarJ.UseVisualStyleBackColor = true;
            buttonAgregarJ.Click += buttonAgregarJ_Click_1;
            // 
            // buttonModificarJ
            // 
            buttonModificarJ.Location = new Point(253, 318);
            buttonModificarJ.Margin = new Padding(3, 4, 3, 4);
            buttonModificarJ.Name = "buttonModificarJ";
            buttonModificarJ.Size = new Size(104, 31);
            buttonModificarJ.TabIndex = 8;
            buttonModificarJ.Text = "Modificar";
            buttonModificarJ.UseVisualStyleBackColor = true;
            buttonModificarJ.Click += buttonModificarJ_Click_1;
            // 
            // buttonEliminarJ
            // 
            buttonEliminarJ.Location = new Point(137, 318);
            buttonEliminarJ.Margin = new Padding(3, 4, 3, 4);
            buttonEliminarJ.Name = "buttonEliminarJ";
            buttonEliminarJ.Size = new Size(94, 31);
            buttonEliminarJ.TabIndex = 9;
            buttonEliminarJ.Text = "Eliminar";
            buttonEliminarJ.UseVisualStyleBackColor = true;
            buttonEliminarJ.Click += buttonEliminarJ_Click_1;
            // 
            // buttonRegresarM
            // 
            buttonRegresarM.Location = new Point(12, 538);
            buttonRegresarM.Margin = new Padding(3, 4, 3, 4);
            buttonRegresarM.Name = "buttonRegresarM";
            buttonRegresarM.Size = new Size(118, 49);
            buttonRegresarM.TabIndex = 11;
            buttonRegresarM.Text = "Menú Principal";
            buttonRegresarM.UseVisualStyleBackColor = true;
            buttonRegresarM.Click += buttonRegresarM_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(503, 500);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form2Jugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRegresarM);
            Controls.Add(buttonEliminarJ);
            Controls.Add(buttonModificarJ);
            Controls.Add(buttonAgregarJ);
            Controls.Add(textBoxNivelJugadores);
            Controls.Add(label4);
            Controls.Add(textBoxNombreJugadores);
            Controls.Add(label3);
            Controls.Add(textBoxIDjugador);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2Jugadores";
            Text = "Form2Jugadores";
            Load += Form2Jugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIDjugador;
        private Label label3;
        private TextBox textBoxNombreJugadores;
        private Label label4;
        private TextBox textBoxNivelJugadores;
        private Button buttonAgregarJ;
        private Button buttonModificarJ;
        private Button buttonEliminarJ;
        private Button buttonRegresarM;
        private DataGridView dataGridView1;
    }
}
namespace proyectoParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonJugadores = new Button();
            buttonInventario = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // buttonJugadores
            // 
            buttonJugadores.Location = new Point(303, 206);
            buttonJugadores.Margin = new Padding(3, 4, 3, 4);
            buttonJugadores.Name = "buttonJugadores";
            buttonJugadores.Size = new Size(360, 107);
            buttonJugadores.TabIndex = 0;
            buttonJugadores.Text = "GESTIÓN DE JUGADORES";
            buttonJugadores.UseVisualStyleBackColor = true;
            buttonJugadores.Click += buttonJugadores_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.Location = new Point(303, 330);
            buttonInventario.Margin = new Padding(3, 4, 3, 4);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(360, 107);
            buttonInventario.TabIndex = 2;
            buttonInventario.Text = "GESTIÓN DE INVENTARIO";
            buttonInventario.UseVisualStyleBackColor = true;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(866, 573);
            buttonSalir.Margin = new Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(110, 48);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 689);
            Controls.Add(buttonSalir);
            Controls.Add(buttonInventario);
            Controls.Add(buttonJugadores);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJugadores;
        private Button buttonInventario;
        private Button buttonSalir;
    }
}

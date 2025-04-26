namespace proyectoParcial
{
    partial class login1
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
            textBoxUsuario1 = new TextBox();
            textBoxContraseña1 = new TextBox();
            buttonIniciar = new Button();
            labelMensaje = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario1
            // 
            textBoxUsuario1.Location = new Point(186, 38);
            textBoxUsuario1.Name = "textBoxUsuario1";
            textBoxUsuario1.Size = new Size(364, 27);
            textBoxUsuario1.TabIndex = 0;
            textBoxUsuario1.TextChanged += textBoxUsuario1_TextChanged;
            // 
            // textBoxContraseña1
            // 
            textBoxContraseña1.Location = new Point(186, 91);
            textBoxContraseña1.Name = "textBoxContraseña1";
            textBoxContraseña1.Size = new Size(364, 27);
            textBoxContraseña1.TabIndex = 1;
            textBoxContraseña1.TextChanged += textBoxContraseña1_TextChanged;
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(186, 168);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(364, 80);
            buttonIniciar.TabIndex = 2;
            buttonIniciar.Text = "Iniciar ";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.Location = new Point(348, 145);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(27, 20);
            labelMensaje.TabIndex = 3;
            labelMensaje.Text = "......";
            labelMensaje.Click += labelMensaje_Click;
            // 
            // login1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMensaje);
            Controls.Add(buttonIniciar);
            Controls.Add(textBoxContraseña1);
            Controls.Add(textBoxUsuario1);
            Name = "login1";
            Text = "login1";
            Load += login1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario1;
        private TextBox textBoxContraseña1;
        private Button buttonIniciar;
        private Label labelMensaje;
    }
}
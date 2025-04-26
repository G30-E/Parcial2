namespace proyectoParcial
{
    partial class login
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
            buttonLogin = new Button();
            textBoxUsuario1 = new TextBox();
            textBoxContra1 = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(198, 244);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(298, 121);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Entrar ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsuario1
            // 
            textBoxUsuario1.Location = new Point(251, 54);
            textBoxUsuario1.Name = "textBoxUsuario1";
            textBoxUsuario1.Size = new Size(182, 27);
            textBoxUsuario1.TabIndex = 1;
            textBoxUsuario1.TextChanged += textBoxUsuario1_TextChanged;
            // 
            // textBoxContra1
            // 
            textBoxContra1.Location = new Point(238, 105);
            textBoxContra1.Name = "textBoxContra1";
            textBoxContra1.Size = new Size(264, 27);
            textBoxContra1.TabIndex = 2;
            textBoxContra1.TextChanged += textBoxContra1_TextChanged;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxContra1);
            Controls.Add(textBoxUsuario1);
            Controls.Add(buttonLogin);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUsuario1;
        private TextBox textBoxContra1;
    }
}
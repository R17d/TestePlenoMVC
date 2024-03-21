namespace TestePlenoMVC.View
{
    partial class loginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginView));
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtCode = new TextBox();
            btnEntrar = new Button();
            linkInscreva = new LinkLabel();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(236, 236, 236);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(131, 161);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Usuário";
            txtNome.Size = new Size(228, 26);
            txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(236, 236, 236);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Location = new Point(131, 270);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(228, 26);
            txtSenha.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.FromArgb(236, 236, 236);
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.ForeColor = Color.Black;
            txtCode.Location = new Point(131, 375);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(228, 26);
            txtCode.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(8, 188, 100);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 14F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(95, 445);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(299, 70);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkInscreva
            // 
            linkInscreva.AutoSize = true;
            linkInscreva.Location = new Point(215, 521);
            linkInscreva.Name = "linkInscreva";
            linkInscreva.Size = new Size(66, 15);
            linkInscreva.TabIndex = 4;
            linkInscreva.TabStop = true;
            linkInscreva.Text = "Inscreva-se";
            linkInscreva.LinkClicked += linkInscreva_LinkClicked;
            // 
            // loginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(977, 569);
            Controls.Add(linkInscreva);
            Controls.Add(btnEntrar);
            Controls.Add(txtCode);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtCode;
        private Button btnEntrar;
        private LinkLabel linkInscreva;
    }
}
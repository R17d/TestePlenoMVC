namespace TestePlenoMVC.View
{
    partial class cadastroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroView));
            picQrCode = new PictureBox();
            lb_user2 = new Label();
            lb_password2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGerarQr = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtCode = new TextBox();
            bntAtivar = new Button();
            ((System.ComponentModel.ISupportInitialize)picQrCode).BeginInit();
            SuspendLayout();
            // 
            // picQrCode
            // 
            picQrCode.Location = new Point(85, 142);
            picQrCode.Name = "picQrCode";
            picQrCode.Size = new Size(332, 311);
            picQrCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQrCode.TabIndex = 2;
            picQrCode.TabStop = false;
            // 
            // lb_user2
            // 
            lb_user2.AutoSize = true;
            lb_user2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_user2.Location = new Point(631, 53);
            lb_user2.Name = "lb_user2";
            lb_user2.Size = new Size(100, 20);
            lb_user2.TabIndex = 12;
            lb_user2.Text = "Novo usuário:";
            // 
            // lb_password2
            // 
            lb_password2.AutoSize = true;
            lb_password2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_password2.Location = new Point(633, 152);
            lb_password2.Name = "lb_password2";
            lb_password2.Size = new Size(89, 20);
            lb_password2.TabIndex = 13;
            lb_password2.Text = "Nova senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(562, 9);
            label4.Name = "label4";
            label4.Size = new Size(230, 39);
            label4.TabIndex = 14;
            label4.Text = "Novo usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(162, 22);
            label3.Name = "label3";
            label3.Size = new Size(180, 22);
            label3.TabIndex = 15;
            label3.Text = "Digitalize o código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(413, 20);
            label1.TabIndex = 16;
            label1.Text = "Digitalize o código abaixo com seu aplicativo autenticador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 85);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 17;
            label2.Text = " para adicionar essa conta. ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(519, 275);
            label8.Name = "label8";
            label8.Size = new Size(318, 20);
            label8.TabIndex = 18;
            label8.Text = "Digite o código de seu aplicativo autenticador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(529, 295);
            label6.Name = "label6";
            label6.Size = new Size(303, 20);
            label6.TabIndex = 19;
            label6.Text = " abaixo para verificar e ativar a autenticação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(564, 315);
            label7.Name = "label7";
            label7.Size = new Size(221, 20);
            label7.TabIndex = 20;
            label7.Text = " de dois fatores para esta conta.";
            // 
            // btnGerarQr
            // 
            btnGerarQr.BackColor = Color.FromArgb(192, 0, 0);
            btnGerarQr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarQr.ForeColor = Color.White;
            btnGerarQr.Location = new Point(562, 237);
            btnGerarQr.Name = "btnGerarQr";
            btnGerarQr.Size = new Size(239, 32);
            btnGerarQr.TabIndex = 2;
            btnGerarQr.Text = "Gerar QR Code";
            btnGerarQr.UseVisualStyleBackColor = false;
            btnGerarQr.Click += btnGerarQr_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(562, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 29);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(562, 191);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(239, 29);
            txtSenha.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(560, 347);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(239, 29);
            txtCode.TabIndex = 3;
            // 
            // bntAtivar
            // 
            bntAtivar.BackColor = Color.FromArgb(192, 0, 0);
            bntAtivar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAtivar.ForeColor = Color.White;
            bntAtivar.Location = new Point(628, 382);
            bntAtivar.Name = "bntAtivar";
            bntAtivar.Size = new Size(94, 32);
            bntAtivar.TabIndex = 4;
            bntAtivar.Text = "Ativar";
            bntAtivar.UseVisualStyleBackColor = false;
            bntAtivar.Click += bntAtivar_Click;
            // 
            // cadastroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 532);
            Controls.Add(bntAtivar);
            Controls.Add(txtCode);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnGerarQr);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lb_password2);
            Controls.Add(lb_user2);
            Controls.Add(picQrCode);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadastroView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)picQrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picQrCode;
        private Label lb_user2;
        private Label lb_password2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label6;
        private Label label7;
        private Button btnGerarQr;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtCode;
        private Button bntAtivar;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePlenoMVC.View
{
    public partial class cadastroView : Form
    {
       Controller.Controller controller;
        public cadastroView(Controller.Controller controll)
        {
            controller = controll;
            InitializeComponent();
        }

        private void btnGerarQr_Click(object sender, EventArgs e)
        {
            if (!controller.SaveUser(txtUsuario.Text, txtSenha.Text))
            { MessageBox.Show("Insira as novas credencias para gerar o QR-Code."); return; }

            picQrCode.Image = controller.GenerateQRCode();

        }

        private void bntAtivar_Click(object sender, EventArgs e)
        {
            if (!controller.ValidateSecretKey(txtCode.Text)) 
            { MessageBox.Show("Código informado inválido."); return; }

            MessageBox.Show("Usuário cadastrado com sucesso.");
            this.Close();
        }
    }
}

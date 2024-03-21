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
    public partial class loginView : Form
    {
        Controller.Controller controller = new Controller.Controller();
        public loginView()
        {
            InitializeComponent();
        }

        private void linkInscreva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastroView cadastroView = new cadastroView(controller);
            cadastroView.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(!controller.ValidateUser(txtNome.Text, txtSenha.Text, txtCode.Text)) 
            { MessageBox.Show("Dados incorretos."); txtCode.Text = ""; return; }

            MessageBox.Show("Login autorizado com sucesso.");
        }
    }
}

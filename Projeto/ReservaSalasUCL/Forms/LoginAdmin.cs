using ReservaSalasUCL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalasUCL.Forms
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();

            this.Load += LoginAdmin_Load;
            this.Resize += LoginAdmin_Resize;

            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void LoginAdmin_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelLoginAdmin.Left = (this.ClientSize.Width - panelLoginAdmin.Width) / 2;
            panelLoginAdmin.Top = (this.ClientSize.Height - panelLoginAdmin.Height) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (AdminService.LoginAdmin(email, senha, out string mensagem))
            {
                this.Hide();
                var telaadmin = new TelaAdmin();
                telaadmin.Show();
            }
            else
            {
                MessageBox.Show(mensagem, "Email ou senha incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}

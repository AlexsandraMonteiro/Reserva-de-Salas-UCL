using ReservaSalasUCL.Forms;
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
    public partial class LoginAdminGeral : Form
    {
        private const string EMAIL_ADMIN_GERAL = "alexsandramonteiro@ucl.br";
        private const string SENHA_ADMIN_GERAL = "ucl2028";

        public LoginAdminGeral()
        {
            InitializeComponent();

            // Garante que os enventos de Load e Resize estão conectados aos seus respectivos manipuladores
            this.Load += LoginAdminGeral_Load;
            this.Resize += LoginAdminGeral_Resize;

            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void LoginAdminGeral_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void LoginAdminGeral_Resize(object sender, EventArgs e)
        {
           CenterToParent();
        }

        // Adicione a palavra-chave 'new' para indicar que você está ocultando intencionalmente o método herdado
        private new void CenterToParent()
        {
            // Centralizar o panelLoginAdminGeral dentro do formulário
            panelLoginAdminGeral.Left = (this.ClientSize.Width - panelLoginAdminGeral.Width) / 2;
            panelLoginAdminGeral.Top = (this.ClientSize.Height - panelLoginAdminGeral.Height) / 2;
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

            if (email == EMAIL_ADMIN_GERAL && senha == SENHA_ADMIN_GERAL)
            {
                this.Hide();
                var telaadmingeral = new TelaAdminGeral();  
                telaadmingeral.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using ReservaSalasUCL.Models;
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
    public partial class CadastroAdmin : Form
    {
        public CadastroAdmin()
        {
            InitializeComponent();

            this.Load += CadastroAdmin_Load;
            this.Resize += CadastroAdmin_Resize;

            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }

        private void CadastroAdmin_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void CadastroAdmin_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelCadastroAdmin.Left = (this.ClientSize.Width - panelCadastroAdmin.Width) / 2;
            panelCadastroAdmin.Top = (this.ClientSize.Height - panelCadastroAdmin.Height) / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nomecompleto = txtNome.Text.Trim();
            string funcao = txtFuncao.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string mensagem;
            bool sucesso = ReservaSalasUCL.Services.AdminService.CadastrarAdmin(nomecompleto, funcao, email, senha, out mensagem);
            MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro", MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (sucesso)
            {
                // Limpa os campos ou fecha o formulário
                txtNome.Text = "";
                txtFuncao.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginAdmin = new LoginAdminGeral();
            loginAdmin.Show();
        }

        private void CadastroAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}

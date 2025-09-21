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
    public partial class LoginAluno : Form
    {
        public LoginAluno()
        {
            InitializeComponent();

            this.Load += LoginAluno_Load;
            this.Resize += LoginAluno_Resize;

            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
        }

        private void LoginAluno_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void LoginAluno_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelLoginAluno.Left = (this.ClientSize.Width - panelLoginAluno.Width) / 2;
            panelLoginAluno.Top = (this.ClientSize.Height - panelLoginAluno.Height) / 2;
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

            if (AlunoService.LoginAluno(email, senha, out string mensagem))
            {
                Aluno NomeCompleto = AlunoService.ObterAlunoPorEmail(email);
                this.Tag = NomeCompleto; // Armazena o aluno logado na propriedade Tag

                this.Hide();
                var telaAluno = new TelaAluno(NomeCompleto);
                telaAluno.Show();
            }
            else
            {
                MessageBox.Show(mensagem, "Email ou senha incorretos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastroAluno = new CadastroAluno();
            cadastroAluno.Show();
        }
    }
}

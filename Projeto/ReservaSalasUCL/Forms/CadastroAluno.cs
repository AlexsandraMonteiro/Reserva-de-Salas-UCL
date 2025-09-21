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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();

            this.Load += CadastroAluno_Load;
            this.Resize += CadastroAluno_Resize;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnLogin.Click += new System.EventHandler(this.btnVoltar_Click);
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void CadastroAluno_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelCadastroAluno.Left = (this.ClientSize.Width - panelCadastroAluno.Width) / 2;
            panelCadastroAluno.Top = (this.ClientSize.Height - panelCadastroAluno.Height) / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCurso.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var aluno = new Aluno
            {
                // Lógica para cadastrar o aluno
                NomeCompleto = txtNome.Text.Trim(),
                Curso = txtCurso.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Senha = txtSenha.Text.Trim(),
            };

            if (AlunoService.CadastrarAluno(aluno, out string mensagem))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirecionar para o login
                this.Hide();
                var login = new ReservaSalasUCL.Forms.LoginAluno();
                login.Show();
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new ReservaSalasUCL.Forms.LoginAluno();
            login.Show();
        }
    }
}

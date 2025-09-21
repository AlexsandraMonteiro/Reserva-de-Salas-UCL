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
    public partial class CadastrarSalas : Form
    {
        public CadastrarSalas()
        {
            InitializeComponent();

            this.Load += CadastrarSalas_Load;
            this.Resize += CadastrarSalas_Resize;

            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
        }

        private void CadastrarSalas_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void CadastrarSalas_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }
        private new void CenterToParent()
        {
            panelCadastrarSalas.Left = (this.ClientSize.Width - panelCadastrarSalas.Width) / 2;
            panelCadastrarSalas.Top = (this.ClientSize.Height - panelCadastrarSalas.Height) / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // LÓGICA PARA CADASTRAR SALA
            string nomeSala = txtNome.Text.Trim();
            int capacidade = txtCapacidade.Text.Trim() == "" ? 0 : int.TryParse(txtCapacidade.Text.Trim(), out capacidade) ? capacidade : -1;
            string mensagem;

            if (nomeSala == "" || capacidade <= 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool sucesso = Services.AdminService.CadastrarSalas(nomeSala, capacidade, out mensagem);

            if (sucesso)
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtCapacidade.Text = "";
            }
            else
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var admin = new TelaAdmin();
            admin.Show();
        }
    }
}

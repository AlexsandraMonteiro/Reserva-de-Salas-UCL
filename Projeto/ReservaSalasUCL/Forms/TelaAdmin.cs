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
    public partial class TelaAdmin : Form
    {
        public TelaAdmin()
        {
            InitializeComponent();

            this.Load += TelaAdmin_Load;
            this.Resize += TelaAdmin_Resize;

            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            this.btnCadastrarSalas.Click += new System.EventHandler(this.btnCadastrarSalas_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }
         
        private void TelaAdmin_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void TelaAdmin_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelTelaAdmin.Left = (this.ClientSize.Width - panelTelaAdmin.Width) / 2;
            panelTelaAdmin.Top = (this.ClientSize.Height - panelTelaAdmin.Height) / 2;
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gerenciar = new GerenciarReservas();
            gerenciar.Show();
        }

        private void btnCadastrarSalas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastrar = new CadastrarSalas();
            cadastrar.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LoginAdmin();
            login.Show();
        }
    }
}

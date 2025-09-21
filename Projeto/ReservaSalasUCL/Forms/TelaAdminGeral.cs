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
    public partial class TelaAdminGeral : Form
    {
        public TelaAdminGeral()
        {
            InitializeComponent();

            this.Load += TelaAdminGeral_Load;
            this.Resize += TelaAdminGeral_Resize;

            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }
        private void TelaAdminGeral_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void TelaAdminGeral_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelTelaAdminGeral.Left = (this.ClientSize.Width - panelTelaAdminGeral.Width) / 2;
            panelTelaAdminGeral.Top = (this.ClientSize.Height - panelTelaAdminGeral.Height) / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastro = new CadastroAdmin();
            cadastro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sair = new LoginAdminGeral();
            sair.Show();
        }


    }
}

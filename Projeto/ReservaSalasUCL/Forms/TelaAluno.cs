using ReservaSalasUCL.Models;
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
    public partial class TelaAluno : Form
    {
        private Aluno alunologado => (Aluno)this.Tag;
        public TelaAluno(Aluno alunologado)
        {
            InitializeComponent();
            this.Tag = alunologado;

            this.Load += TelaAluno_Load;
            this.Resize += TelaAluno_Resize;

            this.btnAgendarSalas.Click += new System.EventHandler(this.btnAgendarSalas_Click);
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
        }

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void TelaAluno_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelTelaAluno.Left = (this.ClientSize.Width - panelTelaAluno.Width) / 2;
            panelTelaAluno.Top = (this.ClientSize.Height - panelTelaAluno.Height) / 2;
        }

        private void btnAgendarSalas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var agendamentoSala = new AgendarSala(alunologado);
            agendamentoSala.Show();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var agendamentos = new VerificarAgendamento(alunologado);
            agendamentos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginAluno = new LoginAluno();
            loginAluno.Show();
        }
    }
}

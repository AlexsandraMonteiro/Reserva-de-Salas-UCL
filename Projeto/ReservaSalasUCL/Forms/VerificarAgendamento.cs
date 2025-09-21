using System;
using ReservaSalasUCL.Models;
using ReservaSalasUCL.Services;
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
    public partial class VerificarAgendamento : Form
    {
        private Aluno alunologado;
        public VerificarAgendamento(Aluno alunologado)
        {
            InitializeComponent();
            this.alunologado = alunologado;

            this.Load += VerificarAgendamento_Load;
            this.Resize += VerificarAgendamento_Resize;

            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
        }

        private void VerificarAgendamento_Load(object sender, EventArgs e)
        {
            CenterToParent();
            CarregarAgendamentos();
        }

        private void VerificarAgendamento_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelVerificar.Left = (this.ClientSize.Width - panelVerificar.Width) / 2;
            panelVerificar.Top = (this.ClientSize.Height - panelVerificar.Height) / 2;
        }
        private void CarregarAgendamentos()
        {
            // Pega o nome do aluno da sessão
            string nomeAluno = alunologado.NomeCompleto;

            // Chama o serviço para obter os agendamentos
            DataTable agendamentos = AlunoService.AgendamentosDoAluno(nomeAluno);

            // Define a fonte de dados do DataGridView
            dgvAgendamentos.DataSource = agendamentos;
        }

        private void AtualizarStatusReserva(int reservaId, string status)
        {
            string mensagem;
            bool sucesso = AdminService.AtualizarStatusReserva(reservaId, status, out mensagem);
            MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro", MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (sucesso)
            {
                CarregarAgendamentos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Lógica para cancelar a reserva
            if (dgvAgendamentos.SelectedRows.Count > 0)
            {
                // Obter o ID da reserva selecionada
                int reservaId = Convert.ToInt32(dgvAgendamentos.SelectedRows[0].Cells["Id"].Value);
                AtualizarStatusReserva(reservaId, "Cancelada");

                string mensagem;
                bool sucesso = AdminService.ApagarReserva(reservaId, out mensagem);
                MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro", MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para cancelar.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var telaAluno = new TelaAluno(alunologado);
            telaAluno.Show();
        }
    }
}

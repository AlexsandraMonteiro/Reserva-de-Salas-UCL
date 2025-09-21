using System;
using ReservaSalasUCL.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalasUCL.Forms
{
    
    public partial class GerenciarReservas : Form
    {
        // Adicione este campo no início da classe
        private static readonly string connectionString = "Data Source=Database/reserva.db";
        public GerenciarReservas()
        {
            InitializeComponent();

            this.Load += GerenciarReservas_Load;
            this.Resize += GerenciarReservas_Resize;

            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
        }

        private void GerenciarReservas_Load(object sender, EventArgs e)
        {
            CenterToParent();
            CarregarAgendamentos();
        }

        private void GerenciarReservas_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelGerenciarReservas.Left = (this.ClientSize.Width - panelGerenciarReservas.Width) / 2;
            panelGerenciarReservas.Top = (this.ClientSize.Height - panelGerenciarReservas.Height) / 2;
        }

        private void CarregarAgendamentos()
        {
            string query = "SELECT Id, Sala, Dia, Hora, QuantidadePessoas, NomeAluno, Status FROM Agendamentos";

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvReservas.DataSource = dt;
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar se uma linha está selecionada
            if (dgvReservas.SelectedRows.Count > 0)
            {
                // Obter o ID da reserva selecionada
                // Supondo que a primeira coluna seja o ID
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);

                AtualizarStatusReserva(reservaId, "Confirmada");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para confirmar.");
            }
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

        private void ApagarReserva(int reservaId)
        {
            string mensagem;
            bool sucesso = AdminService.ApagarReserva(reservaId, out mensagem);
            MessageBox.Show(mensagem, sucesso ? "Sucesso" : "Erro", MessageBoxButtons.OK, sucesso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (sucesso)
            {
                CarregarAgendamentos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Lógica para cancelar a reserva
            if (dgvReservas.SelectedRows.Count > 0)
            {
                // Obter o ID da reserva selecionada
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);
                AtualizarStatusReserva(reservaId, "Cancelada");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para cancelar.");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Lógica para apagar a reserva
            if (dgvReservas.SelectedRows.Count > 0)
            {
                // Obter o ID da reserva selecionada
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);
                ApagarReserva(reservaId);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma reserva para apagar.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var telaadmin = new TelaAdmin();
            telaadmin.Show();
        }
    }
}

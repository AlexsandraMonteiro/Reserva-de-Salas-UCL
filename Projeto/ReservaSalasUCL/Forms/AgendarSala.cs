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
    public partial class AgendarSala : Form
    {
        private Aluno alunologado;
        public AgendarSala(Aluno alunologado)
        {
            InitializeComponent();
            this.alunologado = alunologado;

            this.Load += AgendarSala_Load;
            this.Resize += AgendarSala_Resize;

            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
        }

        private void AgendarSala_Load(object sender, EventArgs e)
        {
            CenterToParent();
            CarregarSalas();
            CarregarHoras();
        }

        private void AgendarSala_Resize(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private new void CenterToParent()
        {
            panelAgendarSala.Left = (this.ClientSize.Width - panelAgendarSala.Width) / 2;
            panelAgendarSala.Top = (this.ClientSize.Height - panelAgendarSala.Height) / 2;
        }

        private void CarregarSalas()
        {
            // Chama todas as salas do banco de dados
            List<Sala> salas = AlunoService.ObterSalas();

            // Limpa o ComboBox antes de adicionar novos itens
            cmbSala.Items.Clear();

            // Adiciona as salas ao ComboBox
            foreach (var sala in salas)
            {
                cmbSala.Items.Add(sala.NomeSala);
            }

            // Seleciona o primeiro item por padrão, se houver salas
            if (cmbSala.Items.Count > 0)
            {
                cmbSala.SelectedIndex = 0;
            }
        }

        private void CarregarHoras()
        {
            cmbHora.Items.Clear();

            // Exemplo: das 10:00 às 21:30 a cada 1 hora
            TimeSpan inicio = new TimeSpan(10, 0, 0);
            TimeSpan fim = new TimeSpan(21, 30, 0);
            TimeSpan passo = new TimeSpan(1, 0, 0);

            for (TimeSpan t = inicio; t <= fim; t = t.Add(passo))
            {
                cmbHora.Items.Add(t.ToString(@"hh\:mm"));
            }

            if (cmbHora.Items.Count > 0)
                cmbHora.SelectedIndex = 0;

            // Recomendo no Designer setar DropDownStyle = DropDownList
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSala.Text) ||
                string.IsNullOrWhiteSpace(dtpDia.Text) ||
                string.IsNullOrWhiteSpace(cmbHora.Text) ||
                string.IsNullOrWhiteSpace(txtPessoas.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter os dados da interface
            string sala = cmbSala.SelectedItem.ToString();
            string dia = dtpDia.Value.ToString("dd-MM-yyyy");
            string hora = cmbHora.SelectedItem.ToString();
            int pessoas = txtPessoas.Text.Trim() == "" ? 0 : int.TryParse(txtPessoas.Text.Trim(), out pessoas) ? pessoas : -1;

            string nomeAluno = alunologado.NomeCompleto;

            // Chamar o serviço para agendar
            string mensagem;
            if (AlunoService.AgendarSala(nomeAluno, sala, dia, hora, pessoas, out mensagem))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensagem, "Erro de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


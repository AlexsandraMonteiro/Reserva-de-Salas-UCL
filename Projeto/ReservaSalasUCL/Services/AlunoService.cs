using ReservaSalasUCL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalasUCL.Services
{
    internal class AlunoService
    {
        // LÓGICA PARA CADASTRO DE ALUNOS
        public static bool CadastrarAluno(Aluno aluno, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();

                    // Verifica se já existe email ou nome completo
                    using (var checkCmd = conn.CreateCommand())
                    {
                        checkCmd.CommandText = @"SELECT COUNT(*) FROM Alunos 
                                             WHERE Email = @Email OR NomeCompleto = @Nome";
                        checkCmd.Parameters.AddWithValue("@Email", aluno.Email);
                        checkCmd.Parameters.AddWithValue("@Nome", aluno.NomeCompleto);

                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            mensagem = "Já existe um aluno com este nome ou email.";
                            return false;
                        }
                    }
                    // Inserir aluno no banco
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO Alunos (NomeCompleto, Curso, Email, Senha)
                                        VALUES (@Nome, @Curso, @Email, @Senha)";
                        cmd.Parameters.AddWithValue("@Nome", aluno.NomeCompleto);
                        cmd.Parameters.AddWithValue("@Curso", aluno.Curso);
                        cmd.Parameters.AddWithValue("@Email", aluno.Email);
                        cmd.Parameters.AddWithValue("@Senha", aluno.Senha);
                        cmd.ExecuteNonQuery();
                    }
                    mensagem = "Aluno cadastrado com sucesso!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar aluno: " + ex.Message;
                return false;
            }
        }
        // LÓGICA PARA LOGIN DE ALUNOS
        public static bool LoginAluno(string email, string senha, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();

                    // Verifica se a senha e email conferem
                    using (var checkCmd = conn.CreateCommand())
                    {
                        checkCmd.CommandText = @"SELECT COUNT(*) FROM Alunos 
                                             WHERE Email = @Email AND Senha = @Senha";
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        checkCmd.Parameters.AddWithValue("@Senha", senha);

                        long count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            mensagem = "Login realizado com sucesso!";
                            return true;
                        }
                        else
                        {
                            mensagem = "Email ou senha incorretos.";
                            return false;
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao realizar login: " + ex.Message;
                return false;
            }
        }
        /* LÓGICA PARA TELA DO ALUNO
         * 1) AGENDAR SALA
         * 2) VERIFICAR AGENDAMENTOS
         */

        // AGENDAR SALA
        public static List<Sala> ObterSalas()
        {
            var salas = new List<Sala>();
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Id, NomeSala, Capacidade FROM Salas";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                salas.Add(new Sala
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    NomeSala = reader["NomeSala"].ToString(),
                                    Capacidade = Convert.ToInt32(reader["Capacidade"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar salas: {ex.Message}"); 
            }
            return salas;
        }

        public static bool AgendarSala(string nomeAluno, string sala, string dia, string hora, int pessoas, out string mensagem)
        {
            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Verificar se a sala já está agendada neste dia e horário
                    string checkQuery = "SELECT COUNT(*) FROM Agendamentos WHERE Sala = @sala AND Dia = @dia AND Hora = @hora AND Status = 'Confirmada'";
                    using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@sala", sala);
                        checkCmd.Parameters.AddWithValue("@dia", dia);
                        checkCmd.Parameters.AddWithValue("@hora", hora);

                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            mensagem = "Esta sala já está reservada para este horário. Por favor, escolha outro.";
                            return false; // Retorna false se a sala estiver ocupada
                        }
                    }

                    //  Se não houver conflito, insere o novo agendamento
                    string insertQuery = "INSERT INTO Agendamentos (NomeAluno, Sala, Dia, Hora, QuantidadePessoas, Status) VALUES (@nome, @sala, @dia, @hora, @QuantidadePessoas, 'Pendente')";
                    using (var insertCmd = new SQLiteCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@nome", nomeAluno);
                        insertCmd.Parameters.AddWithValue("@sala", sala);
                        insertCmd.Parameters.AddWithValue("@dia", dia);
                        insertCmd.Parameters.AddWithValue("@hora", hora);
                        insertCmd.Parameters.AddWithValue("@QuantidadePessoas", pessoas); 

                        insertCmd.ExecuteNonQuery();
                        mensagem = "Agendamento enviado para aprovação! Aguarde a confirmação do administrador.";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    mensagem = $"Ocorreu um erro: {ex.Message}";
                    return false;
                }
            }
        }

        public static Aluno ObterAlunoPorEmail(string email)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, NomeCompleto, Curso, Email FROM Alunos WHERE Email = @Email LIMIT 1";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Aluno
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NomeCompleto = reader["NomeCompleto"].ToString(),
                                Curso = reader["Curso"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
        // VERIFICAR AGENDAMENTOS
        public static DataTable AgendamentosDoAluno(string nomeAluno)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Id, Sala, Dia, Hora, Status FROM Agendamentos WHERE NomeAluno = @nomeAluno";

            using (var conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var adapter = new SQLiteDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Trate a exceção de forma adequada (log, por exemplo)
                    Console.WriteLine($"Erro ao carregar agendamentos: {ex.Message}");
                }
            }
            return dt;
        }

    }
}
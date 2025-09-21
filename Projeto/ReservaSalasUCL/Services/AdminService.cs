using ReservaSalasUCL.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaSalasUCL.Services
{
    internal class AdminService
    {
        // LÓGICA PARA CADASTRO DE ADMINISTRADORES
        public static bool CadastrarAdmin(string nomecompleto, string funcao, string email, string senha, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();

                    // Verifica se já existe email ou nome completo
                    using (var checkCmd = conn.CreateCommand())
                    {
                        checkCmd.CommandText = @"SELECT COUNT(*) FROM Administradores 
                                             WHERE Email = @Email OR NomeCompleto = @Nome";
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        checkCmd.Parameters.AddWithValue("@Nome", nomecompleto);

                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            mensagem = "Já existe um admin com este nome ou email.";
                            return false;
                        }
                    }
                    // Inserir administrador no banco
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO Administradores (NomeCompleto, Funcao, Email, Senha)
                                        VALUES (@Nome, @Funcao, @Email, @Senha)";
                        cmd.Parameters.AddWithValue("@Nome", nomecompleto);
                        cmd.Parameters.AddWithValue("@Funcao", funcao);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senha);
                        cmd.ExecuteNonQuery();
                    }
                    mensagem = "Administrador cadastrado com sucesso!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar administrador: " + ex.Message;
                return false;
            }
        }
        // LÓGICA PARA LOGIN DE ADMINISTRADORES
        public static bool LoginAdmin(string email, string senha, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();

                    // Verifica se a senha e email conferem
                    using (var checkCmd = conn.CreateCommand())
                    {
                        checkCmd.CommandText = @"SELECT COUNT(*) FROM Administradores 
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
        /*LÓGICA PARA TELA DO ADMINISTRADOR
         * 1) GERENCIAR RESERVAS
         * 2) CADASTRAR SALAS
         */

        // GERENCIAR RESERVAS
        public static bool AtualizarStatusReserva(int id, string status, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE Agendamentos 
                                            SET Status = @Status 
                                            WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            mensagem = "Status atualizado com sucesso!";
                            return true;
                        }
                        else
                        {
                            mensagem = "Nenhuma reserva encontrada com o ID fornecido.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar status: " + ex.Message;
                return false;
            }
        }

        public static bool ApagarReserva(int id, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"DELETE FROM Agendamentos 
                                            WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            mensagem = "Reserva apagada com sucesso!";
                            return true;
                        }
                        else
                        {
                            mensagem = "Nenhuma reserva encontrada com o ID fornecido.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao apagar reserva: " + ex.Message;
                return false;
            }
        }

        // CADASTRO DE SALAS
        public static bool CadastrarSalas(string nomesala, int capacidade, out string mensagem)
        {
            try
            {
                using (var conn = Database.GetConnection()) // usa a conexão centralizada
                {
                    conn.Open();
                    // Verifica se já existe sala com o mesmo nome
                    using (var checkCmd = conn.CreateCommand())
                    {
                        checkCmd.CommandText = @"SELECT COUNT(*) FROM Salas 
                                             WHERE NomeSala = @NomeSala";
                        checkCmd.Parameters.AddWithValue("@NomeSala", nomesala);
                        long count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            mensagem = "Já existe uma sala com este nome.";
                            return false;
                        }
                    }
                    // Inserir sala no banco
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO Salas (NomeSala, Capacidade)
                                        VALUES (@NomeSala, @Capacidade)";
                        cmd.Parameters.AddWithValue("@NomeSala", nomesala);
                        cmd.Parameters.AddWithValue("@Capacidade", capacidade);
                        cmd.ExecuteNonQuery();
                    }
                    mensagem = "Sala cadastrada com sucesso!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar sala: " + ex.Message;
                return false;
            }
        }
    }
}
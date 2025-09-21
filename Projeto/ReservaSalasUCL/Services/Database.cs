using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasUCL.Services
{
    public static class Database
    {
        private readonly static string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "reserva.db");
        private readonly static string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void Initialize()
        {
            string dbDirectory = Path.GetDirectoryName(dbFile);

            // cria a pasta se não existir
            if (!Directory.Exists(dbDirectory))
                Directory.CreateDirectory(dbDirectory);

            // cria o arquivo se não existir
            if (!File.Exists(dbFile))
                SQLiteConnection.CreateFile(dbFile);

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Alunos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NomeCompleto TEXT NOT NULL,
                    Curso TEXT NOT NULL,
                    Email TEXT UNIQUE NOT NULL,
                    Senha TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Administradores (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NomeCompleto TEXT NOT NULL,
                    Funcao TEXT NOT NULL,
                    Email TEXT UNIQUE NOT NULL,
                    Senha TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Salas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NomeSala TEXT UNIQUE NOT NULL,
                    Capacidade INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Agendamentos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sala TEXT NOT NULL,
                    Dia TEXT NOT NULL,
                    Hora TEXT NOT NULL,
                    QuantidadePessoas INTEGER NOT NULL,
                    NomeAluno TEXT NOT NULL,
                    Status TEXT NOT NULL
                );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

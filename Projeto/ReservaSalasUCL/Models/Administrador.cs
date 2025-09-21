using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasUCL.Models
{
    internal class Administrador
    {
        public int Id { get; set; } // Chave primária
        public string NomeCompleto { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; } // Em um sistema real, a senha deve ser armazenada de forma segura (hash)
    }
}

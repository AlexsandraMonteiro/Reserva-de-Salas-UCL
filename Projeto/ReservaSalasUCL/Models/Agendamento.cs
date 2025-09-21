using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasUCL.Models
{
    internal class Agendamento
    {
        public int Id { get; set; } // Chave primária
        public string Sala { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; } 
        public int QuantidadePessoas { get; set; }
        public string NomeAluno { get; set; }
        public string Status { get; set; } // Pendente, Confirmada, Cancelada
    }
}

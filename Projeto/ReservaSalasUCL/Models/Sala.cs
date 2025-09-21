using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasUCL.Models
{
    internal class Sala
    {
        public int Id { get; set; } // Chave primária
        public string NomeSala { get; set; }
        public int Capacidade { get; set; }
    }
}

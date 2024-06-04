using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }

        public Menu(DateTime dataHora, int quantidadeDisponivel, decimal precoEstudante, decimal precoProfessor)
        {
            DataHora = dataHora;
            QuantidadeDisponivel = quantidadeDisponivel;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
        }
    }
}

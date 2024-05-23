using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Multa
    {
        public decimal Valor { get; set; }
        public int NumHoras { get; set; }

        public Multa(decimal valor, int numHoras)
        {
            Valor = valor;
            NumHoras = numHoras;
        }
    }
}

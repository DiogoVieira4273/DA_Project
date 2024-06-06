using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Fatura
    {
        public int ID { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }

        public Fatura(decimal total, DateTime dataHora)
        {
            Total = total;
            DataHora = dataHora;
        }
    }
}

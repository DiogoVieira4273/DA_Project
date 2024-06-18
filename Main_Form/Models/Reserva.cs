using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Prato Prato { get; set; }
        public BindingList<Extra> Extras { get; set; }
        public Menu Menu { get; set; }
        public decimal TotalGasto { get; set; }
        public Multa Multa { get; set; }

        public Reserva()
        {
            Extras = new BindingList<Extra>();
        }
    }
}

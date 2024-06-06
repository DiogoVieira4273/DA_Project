using System;
using System.Collections.Generic;
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
        public List<Extra> Extra { get; set; }
        public Menu Menu { get; set; }
        public Multa Multa { get; set; }
    }
}

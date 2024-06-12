using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Quantidade
    {
        public int Id { get; set; }
        public Menu Menu { get; set; }
        public Prato Prato { get; set; }
        public Extra Extra { get; set; }
        public int quantidade { get; set; }
    }
}

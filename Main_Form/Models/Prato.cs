using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iCantina.Models
{
    public class Prato
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }
        public BindingList<Menu> Menus { get; set; } // Many-to-Many relationship

        public Prato()
        {
            Menus = new BindingList<Menu>();
        }
        public override string ToString()
        {
            return $"{Descricao}, {Tipo}, {Ativo}";
        }
    }
}

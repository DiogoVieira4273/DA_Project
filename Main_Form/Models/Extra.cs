using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Extra
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco {  get; set; }
        public bool Ativo { get; set; }
        public BindingList<Menu> Menus { get; set; } // Many-to-Many relationship

        public Extra()
        {
            Menus = new BindingList<Menu>();
        }
        public override string ToString()
        {
            return $"{Descricao}, {Preco}€, {Ativo}";
        }
    }
}

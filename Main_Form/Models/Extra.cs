using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Extra
    {
        public string Descricao { get; set; }
        public decimal Preco {  get; set; }
        public bool Ativo { get; set; }

        public Extra(string descricao, decimal preco, bool ativo)
        { 
            Descricao = descricao;
            Preco = preco;
            Ativo = ativo;
        }
    }
}

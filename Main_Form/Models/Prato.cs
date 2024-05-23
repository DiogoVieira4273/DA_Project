using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Prato
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }

        public Prato(string descricao, string tipo, bool ativo)
        {
            Descricao = descricao;
            Tipo = tipo;
            Ativo = ativo;
        }
    }
}

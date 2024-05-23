using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Cliente : Utilizador
    {
        public decimal Saldo { get; set; }

        public Cliente(string name, int nif, decimal saldo) : base(name,nif) 
        {
            Saldo = saldo;
        }
    }
}

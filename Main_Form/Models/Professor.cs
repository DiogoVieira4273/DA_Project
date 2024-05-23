using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Professor : Cliente
    {
        public string Email { get; set; }

        public Professor(string name, int nif, decimal saldo, string email) : base(name, nif, saldo)
        {
            Email = email;
        }
    }
}

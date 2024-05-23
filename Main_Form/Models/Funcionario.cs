using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Funcionario : Utilizador
    {
        public string Username { get; set; }

        public Funcionario(string name, int nif, string username) : base(name,nif)
        {
            Username = username;
        }
    }
}

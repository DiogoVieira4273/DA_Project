using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Estudante : Cliente
    {
        public int NumEstudante {  get; set; }
        
        public Estudante(string name, int nif, decimal saldo, int numEstudante) : base(name, nif, saldo)
        {
            NumEstudante = numEstudante;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public BindingList<Extra> Extras { get; set; }
        public decimal TotalGasto { get; set; }
        public Multa Multa { get; set; }

        public Reserva()
        {
            Extras = new BindingList<Extra>();
        }

        public override string ToString()
        {
            //return $"Reserva #{Id}, Cliente: {Cliente.Name}, Prato: {Prato.Tipo} Multa: {Multa.Valor}";
            // Formatação básica dos atributos da reserva
            StringBuilder sb = new StringBuilder();
            sb.Append($"Reserva #{Id}, Cliente: {Cliente.Name}, Prato: {Prato.Descricao},Total Gasto: {TotalGasto:C2}");

            // Verifica se há extras selecionados e adiciona seus nomes à string
            if (Extras.Count > 0)
            {
                sb.Append(", Extras: ");
                for (int i = 0; i < Extras.Count; i++)
                {
                    if (i > 0)
                        sb.Append(", ");
                    sb.Append(Extras[i].Descricao);
                }
            }

            return sb.ToString();
        }
    }
}

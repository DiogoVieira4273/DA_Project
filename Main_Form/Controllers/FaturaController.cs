using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class FaturaController
    {
        private CantinaContext db;
        public FaturaController(CantinaContext db) 
        { 
            this.db = db;
        }

        public List<Fatura> GetFaturas()
        {
            return db.Faturas.ToList();
        }

        public Fatura AddFatura(decimal total, DateTime dataHora, Reserva reserva, List<ItemFatura> itemFaturas)
        {
            var fatura = new Fatura { Total = total, DataHora = dataHora, Reserva = reserva, ItemFatura = itemFaturas };
            db.Faturas.Add(fatura);
            db.SaveChanges();

            return fatura;
        }
    }
}

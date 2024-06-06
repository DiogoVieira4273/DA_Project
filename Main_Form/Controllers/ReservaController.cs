using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class ReservaController
    {
        public CantinaContext db;

        public ReservaController(CantinaContext db)
        {
            this.db = db;
        }

        public List<Reserva> GetReservas()
        {
            return db.Reservas.ToList();
        }

        public Reserva AddReserva(Cliente cliente, Prato prato, List<Extra> extras, Menu menu, Multa multa)
        {
            var reserva = new Reserva {Cliente = cliente, Prato = prato, Extra = extras, Menu = menu, Multa = multa};
            db.Reservas.Add(reserva);
            db.SaveChanges();

            return reserva;
        }
    }
}

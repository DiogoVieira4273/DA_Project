using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Reserva> GetReservas()
        {
            var listaReservas = db.Reservas.ToList();
            return new BindingList<Reserva>(listaReservas);
        }

        public Reserva AddReserva(Cliente cliente, Prato prato, BindingList<Extra> extras, /*Menu menu, decimal TotalGasto,*/ Multa multa)
        {
            //var reserva = new Reserva {Cliente = cliente, Prato = prato, Extras = extras, Menu = menu, TotalGasto=TotalGasto,Multa = multa};
            var reserva = new Reserva { Cliente = cliente, Prato = prato, Extras = extras, Multa = multa };
            db.Reservas.Add(reserva);
            db.SaveChanges();

            return reserva;
        }
    }
}

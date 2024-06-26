﻿using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Fatura> GetFaturas()
        {
            var faturas = db.Faturas.ToList();
            return new BindingList<Fatura>(faturas);
        }

        public Fatura AddFatura(Reserva reserva, DateTime dataPagamento)
        {
            var fatura = new Fatura
            {
                Reserva = reserva,
                DataHora = dataPagamento
            };

            db.Faturas.Add(fatura);
            db.SaveChanges();

            return fatura;
        }
    }
}

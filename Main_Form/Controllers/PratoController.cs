using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iCantina.Controllers
{
    public class PratoController
    {
        public CantinaContext db;

        public PratoController(CantinaContext db)
        {
            this.db = db;
        }
        public BindingList<Prato> GetPratos()
        {
            var listaPrato = db.Pratos.ToList();
            return new BindingList<Prato>(listaPrato);
        }

        public bool VerificarPrato(string tipo)
        {
            tipo = tipo.ToLower();
            var tiposValidos = new List<string> { "carne", "peixe", "vegetariano" };

            if (!tiposValidos.Contains(tipo))
            {
                throw new Exception("Tipo indisponível (Carne, Peixe, Vegetariano)!");
            }

            return db.Pratos.Any(p => p.Tipo.ToLower() == tipo);
        }

        public Prato AddPrato(string descricao, string tipo, bool ativo)
        {
            VerificarPrato(tipo);

            var prato = new Prato { Descricao = descricao, Tipo = tipo, Ativo = ativo };
            db.Pratos.Add(prato);
            db.SaveChanges();

            return prato;
        }

        public void UpdatePrato(int id, string descricao, string tipo, bool ativo)
        {
            VerificarPrato(tipo);
            var prato = db.Pratos.Where(p => p.ID == id).FirstOrDefault();
            prato.Descricao = descricao;
            prato.Tipo = tipo;
            prato.Ativo = ativo;
            db.SaveChanges();

        }

        public void DeletePrato(int id)
        {
            var prato = db.Pratos.Where(p => p.ID == id).FirstOrDefault();
            db.Pratos.Remove(prato);
            db.SaveChanges();
        }
    }
}

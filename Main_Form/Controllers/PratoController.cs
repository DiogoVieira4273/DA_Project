using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class PratoController
    {
        public CantinaContext db;

        public PratoController(CantinaContext db)
        {
            this.db = db;
        }
        public List<Prato> GetPrato()
        {
           
                return db.Pratos.ToList();
            
        }

        public  bool VerificarPrato(string descricao)
        {
            descricao = descricao.ToLower();
            return db.Pratos.Any(p => p.Descricao == descricao);
            
        }

        public Prato AddPrato(string descricao, string tipo, bool ativo)
        {
            if (VerificarPrato(descricao))
            {
                throw new Exception("Esse prato já foi criado!");
            }
            
            var prato = new Prato(descricao, tipo, ativo);
            db.Pratos.Add(prato);
            db.SaveChanges();

            return prato;
        }

        public void UpdatePrato(int id, string descricao, string tipo, bool ativo)
        {
            if (VerificarPrato(descricao))
            {
                throw new Exception("Esse prato já foi criado!");

            }

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

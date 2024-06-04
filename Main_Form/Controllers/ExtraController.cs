using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class ExtraController
    {
        public CantinaContext db;

        public ExtraController(CantinaContext db)
        {
            this.db = db;
        }

        public List<Extra> GetExtra()
        {
            return db.Extras.ToList();
        }

        public bool VerificarExtra(string descricao)
        {
            descricao = descricao.ToLower();
            return db.Extras.Any(p => p.Descricao == descricao);

        }

        public Extra AddExtra(string descricao, decimal preco, bool ativo)
        {
            if (VerificarExtra(descricao))
            {
                throw new Exception("Esse Extra já foi criado!");
            }

            var extra = new Extra(descricao, preco, ativo);
            db.Extras.Add(extra);
            db.SaveChanges();

            return extra;

        }

        public void UpdateExtra(int id, string descricao, decimal preco, bool ativo)
        {
            if (VerificarExtra(descricao))
            {
                throw new Exception("Esse Extra já foi criado!");
            }

            var extra = db.Extras.Where(ex => ex.ID == id).FirstOrDefault();
            extra.Descricao = descricao;
            extra.Preco = preco;
            extra.Ativo = ativo;
            db.SaveChanges();

        }

        public void DeleteExtra(int id)
        {
            var extra = db.Extras.Where(p => p.ID == id).FirstOrDefault();
            db.Extras.Remove(extra);
            db.SaveChanges();
        }
    }
}


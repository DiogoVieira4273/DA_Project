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
        public static List<Extra> GetExtra()
        {
            using (var db = new CantinaContext())
            {
                return db.Extras.ToList();
            }
        }

        public static bool VerificarExtra(string descricao)
        {
            descricao = descricao.ToLower();
            using (var db = new CantinaContext())
            {
                return db.Extras.Any(p => p.Descricao == descricao);
            }
        }

        public static void AddExtra(string descricao, decimal preco, bool ativo)
        {
            if (VerificarExtra(descricao))
            {
                MessageBox.Show("Esse Extra já foi criado!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var extra = new Extra(descricao, preco, ativo);
                db.Extras.Add(extra);
                db.SaveChanges();
            }
        }

        public static void UpdateExtra(int id, string descricao, decimal preco, bool ativo)
        {
            if (VerificarExtra(descricao))
            {
                MessageBox.Show("Esse Extra já foi criado!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var extra = db.Extras.Find(id);
                extra.Descricao = descricao;
                extra.Preco = preco;
                extra.Ativo = ativo;
                db.SaveChanges();
            }
        }

        public static void DeleteExtra(int id)
        {
            using (var db = new CantinaContext())
            {
                var extra = db.Extras.Find(id);
                db.Extras.Remove(extra);
                db.SaveChanges();
            }
        }
    }
}

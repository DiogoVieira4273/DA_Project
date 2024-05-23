using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class PratoController
    {
        public static List<Prato> GetPrato()
        {
            using (var db = new CantinaContext())
            {
                return db.Pratos.ToList();
            }
        }

        public static bool VerificarPrato(string descricao)
        {
            descricao = descricao.ToLower();
            using (var db = new CantinaContext())
            {
                return db.Pratos.Any(p => p.Descricao == descricao);
            }
        }

        public static void AddPrato(string descricao, string tipo, bool ativo)
        {
            if (VerificarPrato(descricao))
            {
                MessageBox.Show("Esse prato já foi criado!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var prato = new Prato(descricao, tipo, ativo);
                db.Pratos.Add(prato);
                db.SaveChanges();
            }
        }

        public static void UpdatePrato(int id, string descricao, string tipo, bool ativo)
        {
            if (VerificarPrato(descricao))
            {
                MessageBox.Show("Esse prato já foi criado!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var prato = db.Pratos.Find(id);
                prato.Descricao = descricao;
                prato.Tipo = tipo;
                prato.Ativo = ativo;
                db.SaveChanges();
            }
        }

        public static void DeletePrato(int id)
        {
            using (var db = new CantinaContext())
            {
                var prato = db.Pratos.Find(id);
                db.Pratos.Remove(prato);
                db.SaveChanges();
            }
        }
    }
}

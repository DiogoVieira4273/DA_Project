using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class MenuController
    {
        public CantinaContext db;

        public MenuController(CantinaContext db)
        {
            this.db = db;
        }

        public List<Menu> GetMenus()
        {
            return db.Menus.ToList();
        }

        public bool VerificarMenu(int quantidadeDisponivel)
        {
            return db.Menus.Any(m => m.QuantidadeDisponivel == quantidadeDisponivel);
        }

        public Menu AddMenu(DateTime dataHora, int quantidadeDisponivel, decimal precoEstudante, decimal precoProfessor)
        {
            if (VerificarMenu(quantidadeDisponivel))
            {
                throw new Exception("Esse menu já foi criado!");
            }

            var menu = new Menu(dataHora, quantidadeDisponivel, precoEstudante, precoProfessor);
            db.Menus.Add(menu);
            db.SaveChanges();

            return menu;

        }

        public void UpdateMenu(int id, DateTime dataHora, int quantidadeDisponivel, decimal precoEstudante, decimal precoProfessor)
        {
            if (VerificarMenu(quantidadeDisponivel))
            {
                throw new Exception("Esse menu já foi criado!");
            }

            var menu = db.Menus.Where(m => m.Id == id).FirstOrDefault();
            menu.DataHora = dataHora;
            menu.QuantidadeDisponivel = quantidadeDisponivel;
            menu.PrecoEstudante = precoEstudante;
            menu.PrecoProfessor = precoProfessor;
            db.SaveChanges();

        }

        public void DeleteMenu(int id)
        {
            var menu = db.Menus.Where(m => m.Id == id).FirstOrDefault();
            db.Menus.Remove(menu);
            db.SaveChanges();
        }
    }
}
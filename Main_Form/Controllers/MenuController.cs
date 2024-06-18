using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<Menu> GetMenus()
        {
            var listaMenu = db.Menus.ToList();
            return new BindingList<Menu>(listaMenu);
        }

        public Menu GetMenuById(int menuId)
        {
            return db.Menus.FirstOrDefault(m => m.Id == menuId);
        }


        public Menu AddMenu(DateTime dataHora,decimal precoEstudante, decimal precoProfessor, BindingList<Prato> pratos, BindingList<Extra> extras)
        {
            var menu = new Menu { DataHora = dataHora, PrecoEstudante = precoEstudante, PrecoProfessor = precoProfessor, Pratos = pratos, Extras = extras };
            db.Menus.Add(menu);
            db.SaveChanges();

            return menu;

        }

        public void DeleteMenu(int id)
        {
            var menu = db.Menus.Where(m => m.Id == id).FirstOrDefault();
            db.Menus.Remove(menu);
            db.SaveChanges();
        }
    }
}
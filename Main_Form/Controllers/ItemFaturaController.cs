using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class ItemFaturaController
    {
        private CantinaContext db;
        public ItemFaturaController(CantinaContext db) 
        {
            this.db = db;
        }

        public List<ItemFatura> GetItemFaturas()
        {
            return db.ItemFaturas.ToList();
        }

        public ItemFatura AddItemFatura(string descricao, decimal preco)
        {
            var itemFatura = new ItemFatura(descricao, preco);
            db.ItemFaturas.Add(itemFatura);
            db.SaveChanges();

            return itemFatura;
        }
    }
}

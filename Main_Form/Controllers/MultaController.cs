using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class MultaController
    {

        public CantinaContext db;

        public MultaController(CantinaContext db)
        {
            this.db = db;
        }
        public List<Multa> GetMulta()
        {
                return db.Multas.ToList();
        }

        public bool VerificarMulta(decimal valor, int numHoras)
        {
                return db.Multas.Any(m => m.NumHoras == numHoras);
        }

        public Multa AddMulta(decimal valor, int numHoras)
        {
            if (VerificarMulta(valor, numHoras))
            {
                throw new Exception ("Essa multa já foi criada com esse número de horas!");
            }
          
            var multa = new Multa(valor, numHoras);
            db.Multas.Add(multa);
            db.SaveChanges();

            return multa;

        }

        public void UpdateMulta(int id, decimal valor, int numHoras)
        {
            if (VerificarMulta(valor, numHoras))
            {
                throw new Exception("Essa multa já foi criada com esse número de horas!");
            }

            var multa = db.Multas.Where(m => m.ID == id).FirstOrDefault();
            multa.Valor = valor;
            multa.NumHoras = numHoras;
            db.SaveChanges();

        }

        public void DeleteMulta(int id)
        { 
            var multa = db.Multas.Where(m => m.ID == id).FirstOrDefault();
            db.Multas.Remove(multa);
            db.SaveChanges(); 
        }
    }
}

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
        public static List<Multa> GetMulta()
        {
            using (var db = new CantinaContext())
            {
                return db.Multas.ToList();
            }
        }

        public static bool VerificarMulta(decimal valor, int numHoras)
        {
            using (var db = new CantinaContext())
            {
                return db.Multas.Any(m => m.NumHoras == numHoras);
            }
        }

        public static void AddPrato(decimal valor, int numHoras)
        {
            if (VerificarMulta(valor, numHoras))
            {
                MessageBox.Show("Essa multa já foi criada com esse número de horas!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var multa = new Multa(valor, numHoras);
                db.Multas.Add(multa);
                db.SaveChanges();
            }
        }

        public static void UpdatePrato(int id, decimal valor, int numHoras)
        {
            if (VerificarMulta(valor, numHoras))
            {
                MessageBox.Show("Essa multa já foi criada com esse número de horas!");
                return;
            }
            using (var db = new CantinaContext())
            {
                var multa = db.Multas.Find(id);
                multa.Valor = valor;
                multa.NumHoras = numHoras;
                db.SaveChanges();
            }
        }

        public static void DeleteMulta(int id)
        {
            using (var db = new CantinaContext())
            {
                var multa = db.Multas.Find(id);
                db.Multas.Remove(multa);
                db.SaveChanges();
            }
        }
    }
}

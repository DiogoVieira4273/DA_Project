using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class EstudanteController
    {
        public CantinaContext db;

        public EstudanteController(CantinaContext db)
        {
            this.db = db;
        }

        public BindingList<Estudante> GetEstudantes()
        {
            //return db.Estudantes.ToList();
            var listaEstudante = db.Estudantes.ToList();
            return new BindingList<Estudante>(listaEstudante);
        }

        public Estudante AddEstudante(string nome, int nif, decimal saldo, int numEstudante)
        {
            validarEstudante(nome, nif, saldo, numEstudante);
            UtilizadorController.VerificarNIF(nif, db);
            var estudante = new Estudante { Name = nome,NIF = nif, Saldo = saldo, NumEstudante = numEstudante };
            db.Estudantes.Add(estudante);
            db.SaveChanges();

            return estudante;
        }

        public void UpdateEstudante(int id, string nome, int nif, decimal saldo, int numEstudante)
        {
            validarEstudante(nome, nif, saldo, numEstudante);
            UtilizadorController.VerificarNIF(nif, db);

            var estudante = db.Estudantes.Where(p => p.Id == id).FirstOrDefault();
            estudante.Name = nome;
            estudante.NIF = nif;
            estudante.Saldo = saldo;
            estudante.NumEstudante = numEstudante;
            db.SaveChanges();
        }

        public void DeleteEstudante(int id)
        {
            var estudante = db.Estudantes.Where(p => p.Id == id).FirstOrDefault();
            db.Estudantes.Remove(estudante);
            db.SaveChanges();
        }


        private bool validarEstudante(string nome, int nif, decimal saldo, int numEstudante)
        {
            if (nome == "")
            {
                throw new Exception("Nome inválido");
            }

            if (nif.ToString().Length != 9)
            {
                throw new Exception("NIF inválido. Deve conter exatamente 9 dígitos.");
            }

            if (saldo < 0)
            {
                throw new Exception("Saldo inválido");
            }

            if (numEstudante.ToString().Length != 7)
            {
                throw new Exception("Numero do estudante inválido");
            }

            return true;

        }

        public void UpdateEstudante(Estudante estudante)
        {
            db.Entry(estudante).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

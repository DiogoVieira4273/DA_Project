using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class ProfessorController
    {
        public CantinaContext db;
        public ProfessorController(CantinaContext db)
        {
            this.db = db;
        }

        public List<Professor> GetProfessor()
        {
            return db.Professores.ToList();
        }

        public Professor AddProfessor(string nome, int nif, decimal saldo, string email)
        {
            validarProfessor(nome, nif, saldo, email);
            UtilizadorController.VerificarNIF(nif, db);

            var professor = new Professor(nome, nif, saldo, email);
            db.Professores.Add(professor);
            db.SaveChanges();

            return professor;
        }

        public void UpdateProfessor(int id, string nome, int nif, decimal saldo, string email)
        {
            validarProfessor(nome, nif, saldo, email);
            UtilizadorController.VerificarNIF(nif, db);
            var professor = db.Professores.Where(p => p.Id == id).FirstOrDefault();

            professor.Name = nome;
            professor.NIF = nif;
            professor.Saldo = saldo;
            professor.Email = email;
            db.SaveChanges();
        }

        public void DeleteProfessor(int id)
        {
            var professor = db.Professores.Where(p => p.Id == id).FirstOrDefault();
            db.Professores.Remove(professor);
            db.SaveChanges();
        }

        private bool validarProfessor(string nome, int nif, decimal saldo, string email)
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

            if (email == "")
            {
                throw new Exception("Email inválido");
            }

            return true;
        }
    }
}

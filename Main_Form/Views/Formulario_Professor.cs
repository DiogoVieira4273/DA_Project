using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Formulario_Professor : Form
    {
        private BindingList<Professor> listaProfessor = new BindingList<Professor>();
        public CantinaContext db;
        private ProfessorController profController;
        public Formulario_Professor(CantinaContext db)
        {
            this.db = db;
            this.profController = new ProfessorController(this.db);
            InitializeComponent();
        }

        private void button_registarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = this.profController.AddProfessor(textBox_nomeProf.Text, int.Parse(textBox_nifProf.Text), decimal.Parse(textBox_saldoProf.Text), textBox_emailProf.Text);

                listaProfessor.Add(professor);
                listBox_Professor.Items.Clear();
                foreach (Professor p in listaProfessor)
                {
                    listBox_Professor.Items.Add(p);
                    listBox_Professor.DataSource = professor;
                }

                MessageBox.Show("Professor registrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_editarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = (Professor)listBox_Professor.SelectedItem;

                if (professor != null)
                {
                    professor.Name = textBox_nomeProf.Text;
                    professor.NIF = int.Parse(textBox_nifProf.Text);
                    professor.Saldo = decimal.Parse(textBox_saldoProf.Text);
                    professor.Email = textBox_emailProf.Text;
                    profController.UpdateProfessor(professor.Id, professor.Name, professor.NIF, professor.Saldo, professor.Email);
                }
                else
                {
                    MessageBox.Show("Selecione um professor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apagarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = (Professor)listBox_Professor.SelectedItem;

                if (professor != null)
                {
                    profController.DeleteProfessor(professor.Id);
                    listaProfessor.Remove(professor);
                }
                else
                {
                    MessageBox.Show("Selecione um professor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

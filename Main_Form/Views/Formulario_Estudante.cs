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
    public partial class Formulario_Estudante : Form
    {
        private BindingList<Estudante> listaEstudante = new BindingList<Estudante>();
        public CantinaContext db;
        private EstudanteController estudController;
        public Formulario_Estudante(CantinaContext db)
        {
            this.db = db;
            this.estudController = new EstudanteController(this.db);
            InitializeComponent();
            ObterEstudantes();
        }

        private void button_addEstudante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudante estudante = this.estudController.AddEstudante(textBox_nomeEstudante.Text, int.Parse(textBox_nifEstudante.Text), decimal.Parse(textBox_saldoEstudante.Text), int.Parse(textBox_nEstudante.Text));

                listaEstudante.Add(estudante);
                AtualizarListBoxEstudantes();

                MessageBox.Show("Estudante registado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_editarEstudante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudante estudante = (Estudante)listBox_estudante.SelectedItem;

                if (estudante != null)
                {
                    estudante.Name = textBox_nomeEstudante.Text;
                    estudante.NIF = int.Parse(textBox_nifEstudante.Text);
                    estudante.Saldo = decimal.Parse(textBox_saldoEstudante.Text);
                    estudante.NumEstudante = int.Parse(textBox_nEstudante.Text);
                    estudController.UpdateEstudante(estudante.Id, estudante.Name, estudante.NIF, estudante.Saldo, estudante.NumEstudante);
                    AtualizarListBoxEstudantes();
                }
                else
                {
                    MessageBox.Show("Selecione um estudante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apagarEstudante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudante estudante = (Estudante)listBox_estudante.SelectedItem;

                if (estudante != null)
                {
                    estudController.DeleteEstudante(estudante.Id);
                    listaEstudante.Remove(estudante);
                    AtualizarListBoxEstudantes();
                }
                else
                {
                    MessageBox.Show("Selecione um estudante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterEstudantes()
        {
            listaEstudante = estudController.GetEstudantes();
            AtualizarListBoxEstudantes();
        }

        private void AtualizarListBoxEstudantes()
        {
            listBox_estudante.Items.Clear();

            foreach (Estudante es in listaEstudante)
            {
                listBox_estudante.Items.Add(es);
            }
        }
    }
}
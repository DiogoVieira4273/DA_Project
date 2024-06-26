﻿using iCantina.Controllers;
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
    public partial class Formulario_Multa : Form
    {
        private BindingList<Multa> listaMulta = new BindingList<Multa>();
        public CantinaContext db;
        private MultaController multaController;

        public Formulario_Multa(CantinaContext db)
        {
            this.db = db;
            this.multaController = new MultaController(this.db);
            InitializeComponent();
            ObterMultas();
        }

        private void button_registarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = decimal.Parse(textBox_valorMulta.Text);
                int numHoras = int.Parse(textBox_horasMulta.Text);

                Multa multa = this.multaController.AddMulta(valor, numHoras);

                listaMulta.Add(multa);
                AtualizarListBoxMultas();

                MessageBox.Show("Multa registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_editarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                Multa multa = (Multa)listBox_Multas.SelectedItem;

                if (multa != null)
                {
                    multa.Valor = decimal.Parse(textBox_valorMulta.Text);
                    multa.NumHoras = int.Parse(textBox_horasMulta.Text);
                    multaController.UpdateMulta(multa.ID, multa.Valor, multa.NumHoras);

                    AtualizarListBoxMultas();
                }
                else
                {
                    MessageBox.Show("Selecione uma multa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apagarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                Multa multa = (Multa)listBox_Multas.SelectedItem;

                if (multa != null)
                {
                    multaController.DeleteMulta(multa.ID);
                    listaMulta.Remove(multa);

                    AtualizarListBoxMultas();
                }
                else
                {
                    MessageBox.Show("Selecione uma multa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxMultas()
        {
            listBox_Multas.Items.Clear();
            foreach (Multa mu in listaMulta)
            {
                listBox_Multas.Items.Add(mu);
            }
        }

        private void ObterMultas()
        {
            try
            {
                listaMulta = new BindingList<Multa>(multaController.GetMultas().ToList());
                AtualizarListBoxMultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter as multas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

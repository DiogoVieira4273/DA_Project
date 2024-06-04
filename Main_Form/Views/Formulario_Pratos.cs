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
    public partial class Formulario_Pratos : Form
    {
        private BindingList<Prato> listaPratos = new BindingList<Prato>();
        public CantinaContext db;
        private PratoController pratoController;
        public Formulario_Pratos(CantinaContext db)
        {
            this.db = db;
            this.pratoController = new PratoController(this.db);
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Este prato está ativo");
            }
            else
            {
                MessageBox.Show("Este prato não está ativo");
            }
        }

        private void button_registarPrato_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = this.pratoController.AddPrato(textBox_descricaoPrato.Text, textBox_tipoPrato.Text, checkBox1.Checked);

                listaPratos.Add(prato);
                listBox_Pratos.Items.Clear();
                foreach (Prato pr in listaPratos)
                {
                    listBox_Pratos.Items.Add(pr);
                    listBox_Pratos.DataSource = prato;
                }

                MessageBox.Show("Prato registado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_editarPrato_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = (Prato)listBox_Pratos.SelectedItem;

                if (prato != null)
                {
                    prato.Descricao = textBox_descricaoPrato.Text;
                    prato.Tipo = textBox_tipoPrato.Text;
                    prato.Ativo = checkBox1.Checked;
                    pratoController.UpdatePrato(prato.ID, prato.Descricao, prato.Tipo, prato.Ativo);
                }
                else
                {
                    MessageBox.Show("Selecione um prato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apagarPrato_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = (Prato)listBox_Pratos.SelectedItem;

                if (prato != null)
                {
                    pratoController.DeletePrato(prato.ID);
                    listaPratos.Remove(prato);
                }
                else
                {
                    MessageBox.Show("Selecione um prato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
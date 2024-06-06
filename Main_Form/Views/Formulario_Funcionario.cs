using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Formulario_Funcionario : Form
    {
        private List<Funcionario> listaFuncionario = new List<Funcionario>();
        public CantinaContext db;
        private FuncionarioController funcController;
        public Formulario_Funcionario(CantinaContext db)
        {
            this.db = db;
            this.funcController = new FuncionarioController(this.db);
            InitializeComponent();
         
        }

        
        private void button_Registo_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = this.funcController.AddFuncionario(textBoxNome.Text, int.Parse(textBoxNIF.Text), textBoxUsername.Text);

                listaFuncionario.Add(funcionario);
                listBoxFuncionarios.Items.Clear();
                foreach (Funcionario f in listaFuncionario)
                {
                    listBoxFuncionarios.Items.Add(f);
                }

                MessageBox.Show("Funcionário registrado com sucesso!");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_Apagar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                if (funcionario != null)
                {
                    funcController.DeleteFuncionario(funcionario.Id);
                    listaFuncionario.Remove(funcionario);
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                if (funcionario != null)
                {
                    funcionario.Name = textBoxNome.Text;
                    funcionario.NIF = int.Parse(textBoxNIF.Text);
                    funcionario.Username = textBoxUsername.Text;
                    funcController.UpdateFuncionario(funcionario.Id, funcionario.Name, funcionario.NIF, funcionario.Username);
                }
                else
                {
                    MessageBox.Show("Selecione um funcionario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

      
    }
}

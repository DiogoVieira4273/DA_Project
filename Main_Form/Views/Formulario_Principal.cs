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
    public partial class Formulario_Principal : Form
    {
        private CantinaContext db;
        private FuncionarioController funcController;
        public Formulario_Principal(CantinaContext db)
        {
            this.db = db;
            this.funcController = new FuncionarioController(this.db);
            InitializeComponent();
        }

        private void button_FormPratos_Click(object sender, EventArgs e)
        {
            Formulario_Pratos f_pr = new Formulario_Pratos(db);
            f_pr.ShowDialog();
        }

        private void button_FormExtras_Click(object sender, EventArgs e)
        {
            Formulario_Extras f_ex = new Formulario_Extras(db);
            f_ex.ShowDialog();
        }

        private void button_FormMenu_Click(object sender, EventArgs e)
        {
            Formulario_Menu f_me = new Formulario_Menu();
            f_me.ShowDialog();
        }

        private void button_FormMultas_Click(object sender, EventArgs e)
        {
            Formulario_Multa f_mu = new Formulario_Multa(db);
            f_mu.ShowDialog();
        }

        private void button_FormReservas_Click(object sender, EventArgs e)
        {
            Formulario_Reserva f_r = new Formulario_Reserva(db);
            f_r.ShowDialog();
        }

        private void button_FormFuncionarios_Click(object sender, EventArgs e)
        {
            Formulario_Funcionario f_f = new Formulario_Funcionario(db);
            f_f.ShowDialog();
        }

        private void button_FormEstudantes_Click(object sender, EventArgs e)
        {
            Formulario_Estudante f_e = new Formulario_Estudante(db);
            f_e.ShowDialog();
        }

        private void button_FormProfessores_Click(object sender, EventArgs e)
        {
            Formulario_Professor f_p = new Formulario_Professor(db);
            f_p.ShowDialog();
        }

        

        private void listBox_ListaFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
           listBox_ListaFuncionarios.DataSource = this.funcController.GetFuncionarios();

        }
    }
}

using iCantina.Controllers;
using iCantina.Models;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace iCantina.Views
{
    public partial class Formulario_Principal : Form
    {
        private BindingList<Funcionario> listaFuncionario = new BindingList<Funcionario>();
        private CantinaContext db;
        private FuncionarioController funcController;
        private Funcionario funcionarioSelecionado;

        public Formulario_Principal(CantinaContext db)
        {
            this.db = db;
            this.funcController = new FuncionarioController(this.db);
            InitializeComponent();
            ObterFuncionarios();
            // Habilita todos os botões iniciais
            HabilitarBotoes(true);
        }

        private void button_FormPratos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Pratos(db));
        }

        private void button_FormExtras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Extras(db));
        }

        private void button_FormMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Menu(db));
        }

        private void button_FormMultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Multa(db));
        }

        private void button_FormReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Reserva(db));
        }

        private void button_FormFuncionarios_Click(object sender, EventArgs e)
        {
            Formulario_Funcionario f_f = new Formulario_Funcionario(db);
            // Adicionar um evento para atualizar a lista de funcionários quando o formulário de funcionários for fechado
            f_f.FormClosed += (s, args) => ObterFuncionarios();
            f_f.ShowDialog();
        }

        private void button_FormEstudantes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Estudante(db));
        }

        private void button_FormProfessores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Professor(db));
        }

        private void listBox_ListaFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ListaFuncionarios.SelectedItem is Funcionario funcionario)
            {
                funcionarioSelecionado = funcionario;
                // Habilitar botões quando um funcionário é selecionado
                HabilitarBotoes(true);
            }
            else
            {
                funcionarioSelecionado = null;
                // Desabilitar botões se nenhum funcionário estiver selecionado
                // HabilitarBotoes(false);
            }
        }

        private void ObterFuncionarios()
        {
            listBox_ListaFuncionarios.Items.Clear();
            BindingList<Funcionario> funcionarios = funcController.GetFuncionarios();
            foreach (Funcionario funcionario in funcionarios)
            {
                listBox_ListaFuncionarios.Items.Add(funcionario);
            }
        }

        private void HabilitarBotoes(bool habilitar)
        {
            // Habilita todos os botões de acesso aos formulários
            button_FormPratos.Enabled = habilitar;
            button_FormExtras.Enabled = habilitar;
            button_FormMenu.Enabled = habilitar;
            button_FormMultas.Enabled = habilitar;
            button_FormReservas.Enabled = habilitar;
            button_Funcionarios.Enabled = true; // Sempre habilitado
            button_FormEstudantes.Enabled = habilitar;
            button_FormProfessores.Enabled = habilitar;
        }

        private void AbrirFormulario(Form form)
        {
            if (funcionarioSelecionado != null)
            {
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário antes de acessar esta funcionalidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            // Desabilitar todos os botões iniciais
            HabilitarBotoes(false);
        }
    }
}

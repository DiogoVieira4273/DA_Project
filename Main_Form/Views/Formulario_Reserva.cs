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
    public partial class Formulario_Reserva : Form
    {
        private BindingList<Reserva> listaReservas = new BindingList<Reserva>();
        private BindingList<Models.Menu> lista_menu;
        private BindingList<Multa> listaMultas = new BindingList<Multa>();
        private EstudanteController estudanteController;
        private ProfessorController professorController;
        private MenuController menuController;
        private ReservaController reservaController;
        private MultaController multaController;
        private Models.Menu menuSelecionado;
        public CantinaContext db;

        public Formulario_Reserva(CantinaContext db)
        {
            this.db = db;
            this.reservaController = new ReservaController(this.db);
            this.menuController = new MenuController(this.db);
            this.estudanteController = new EstudanteController(this.db);
            this.professorController = new ProfessorController(this.db);
            this.multaController = new MultaController(this.db);
            InitializeComponent();
            ObterMenus();
            ObterEstudante();
            ObterProfessor();
            ObterMultas();
        }

        private void ObterMenus()
        {
            lista_menu = menuController.GetMenus();
            AtualizarListBoxMenu();
        }

        private void ObterEstudante()
        {
            try
            {
                BindingList<Estudante> estudantes = estudanteController.GetEstudantes();
                listBox_estudantes.Items.Clear();
                foreach (var estudante in estudantes)
                {
                    listBox_estudantes.Items.Add(estudante);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estudantes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterProfessor()
        {
            try
            {
                BindingList<Professor> professores = professorController.GetProfessores();
                listBox_Professores.Items.Clear();
                foreach (var professor in professores)
                {
                    listBox_Professores.Items.Add(professor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterMultas()
        {
            try
            {
                listaMultas = multaController.GetMultas();
                AtualizarListBoxMultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter as multas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxMultas()
        {
            listBox_multas.Items.Clear();
            foreach (Multa multa in listaMultas)
            {
                listBox_multas.Items.Add(multa);
            }
        }

        private void AtualizarListBoxMenu()
        {
            try
            {
                lista_menu = menuController.GetMenus();
                listBox_menus.Items.Clear();
                foreach (var menu in lista_menu)
                {
                    listBox_menus.Items.Add(menu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista de menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_menus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_menus.SelectedItem is Models.Menu menu)
            {
                menuSelecionado = menu;
                AtualizarListBoxPratos(menu);
                AtualizarListBoxExtras(menu);
            }
        }

        private void AtualizarListBoxPratos(Models.Menu menu)
        {
            listBox_pratosdomenu.Items.Clear();
            foreach (var prato in menu.Pratos)
            {
                listBox_pratosdomenu.Items.Add(prato);
            }
        }

        private void AtualizarListBoxExtras(Models.Menu menu)
        {
            listBox_extrasdomenu.Items.Clear();
            foreach (var extra in menu.Extras)
            {
                listBox_extrasdomenu.Items.Add(extra);
            }
        }

        private bool ValidarReserva()
        {
            // Verificar se foi selecionado pelo menos um cliente (estudante ou professor)
            bool estudanteSelecionado = listBox_estudantes.SelectedItems.Count > 0;
            bool professorSelecionado = listBox_Professores.SelectedItems.Count > 0;

            if (!estudanteSelecionado && !professorSelecionado)
            {
                MessageBox.Show("Selecione pelo menos um cliente (estudante ou professor).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foi selecionado mais de um cliente (não pode selecionar ambos)
            if (estudanteSelecionado && professorSelecionado)
            {
                MessageBox.Show("Selecione apenas um cliente (estudante ou professor).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foi selecionado exatamente um prato
            if (listBox_pratosdomenu.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um prato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foram selecionados no máximo três extras
            if (listBox_extrasdomenu.SelectedItems.Count > 3)
            {
                MessageBox.Show("Selecione no máximo três extras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void botton_criarReserva_Click(object sender, EventArgs e)
        {
            
        }
    
    }
}

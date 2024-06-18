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
        private BindingList<Extra> extrasSelecionados = new BindingList<Extra>();
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
            ObterReservas();
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
                listBox_multas.Items.Clear();
                foreach (var multa in listaMultas)
                {
                    listBox_multas.Items.Add(multa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar multas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                menuSelecionado = menu; // Renomear para menuSelecionado (local)
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
            // Verificar se foi selecionada pelo menos uma multa
            if (listBox_multas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma multa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void botton_criarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar a reserva
                if (!ValidarReserva())
                {
                    return;
                }

                // Obter o cliente selecionado
                Cliente cliente = null;
                if (listBox_estudantes.SelectedItems.Count > 0)
                {
                    cliente = (Cliente)listBox_estudantes.SelectedItem;
                }
                else if (listBox_Professores.SelectedItems.Count > 0)
                {
                    cliente = (Cliente)listBox_Professores.SelectedItem;
                }

                // Obter o prato selecionado
                Prato pratoSelecionado = (Prato)listBox_pratosdomenu.SelectedItem;

                // Adicionar os extras selecionados à BindingList
                foreach (var extraSelecionado in listBox_extrasdomenu.SelectedItems)
                {
                    Extra extra = (Extra)extraSelecionado;
                    extrasSelecionados.Add(extra);
                }

                // Obter o menu selecionado
                // Models.Menu menuSelecionado = menuController.GetMenuById(menuSelecionado.Id);

                // Obter a multa selecionada
                Multa multaSelecionada = (Multa)listBox_multas.SelectedItem;

                // Calcula o total gasto com base no cliente, prato selecionado, extras e multa
                decimal totalGasto = CalcularTotalGasto(cliente, pratoSelecionado, extrasSelecionados, multaSelecionada);

                // Adicionar a reserva usando o método do ReservaController
                Reserva reserva = reservaController.AddReserva(cliente, pratoSelecionado, extrasSelecionados, totalGasto,multaSelecionada);
                reserva.TotalGasto = totalGasto; // Atribui o total gasto calculado à reserva

                // Adicionar a reserva à lista de reservas
                listaReservas.Add(reserva);

                // Atualiza a listBox_reserva para exibir os dados da reserva
                AtualizarListBoxReservas();

                MessageBox.Show("Reserva criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObterReservas()
        {
            try
            {
                // Chama o método GetAllReservas do ReservaController
                BindingList<Reserva> reservas = reservaController.GetReservas();

                // Limpa a lista atual de reservas
                listaReservas.Clear();

                // Adiciona todas as reservas retornadas à lista de reservas do formulário
                foreach (var reserva in reservas)
                {
                    listaReservas.Add(reserva);
                }

                // Atualiza a listBox_reserva para exibir os dados das reservas
                AtualizarListBoxReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarListBoxReservas()
        {
            listBox_reserva.Items.Clear();
            foreach (var reserva in listaReservas)
            {
                listBox_reserva.Items.Add(reserva);
            }
        }

        private decimal CalcularTotalGasto(Cliente cliente, Prato prato, BindingList<Extra> extras, Multa multa)
        {
            decimal totalGasto = 0;

            // Adiciona o preço do prato com base no tipo de cliente (estudante ou professor)
            if (cliente is Estudante)
            {
                totalGasto += prato.Menu.PrecoEstudante;
            }
            else if (cliente is Professor)
            {
                totalGasto += prato.Menu.PrecoProfessor;
            }

            // Adiciona o preço de cada extra com base no tipo de cliente (estudante ou professor)
            foreach (var extra in extras)
            {
                if (cliente is Estudante)
                {
                    totalGasto += extra.Preco;
                }
                else if (cliente is Professor)
                {
                    totalGasto += extra.Preco;
                }
            }

            // Verificar a hora atual e a hora limite para aplicação da multa
            DateTime horaAtual = DateTime.Now;
            DateTime horaLimiteMulta = prato.Menu.DataHora.AddHours(-multa.NumHoras);

            // Se estiver dentro do tempo limite para aplicar a multa
            if (horaAtual > horaLimiteMulta)
            {
                // Adiciona o valor da multa ao totalGasto
                totalGasto += multa.Valor;
            }

            return totalGasto;
        }

        private void button_apagar_reserva_Click(object sender, EventArgs e)
        {
            if (listBox_reserva.SelectedItem is Reserva reserva)
            {
                try
                {
                    // Chama o método RemoveReserva do ReservaController
                    reservaController.RemoveReserva(reserva.Id);

                    // Remove a reserva da lista de reservas do formulário
                    listaReservas.Remove(reserva);

                    // Atualiza a listBox_reserva para exibir os dados das reservas
                    AtualizarListBoxReservas();

                    MessageBox.Show("Reserva apagada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para apagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

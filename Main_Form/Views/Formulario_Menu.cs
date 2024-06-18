using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Formulario_Menu : Form
    {
        private CantinaContext db;
        private PratoController pratoController;
        private MenuController menuController;
        private ExtraController extraController;
        private BindingList<Models.Menu> lista_menu = new BindingList<Models.Menu>();
        public Formulario_Menu(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            this.pratoController = new PratoController(this.db);
            this.menuController = new MenuController(this.db);
            this.extraController = new ExtraController(this.db);
            CarregarPratosAtivos();
            CarregarExtrasAtivos();
            ObterMenus();

        }

        public void CarregarPratosAtivos()
        {
            try
            {
                BindingList<Prato> pratosAtivos = pratoController.GetPratosAtivos();
                listBox_pratos.Items.Clear();
                foreach (var prato in pratosAtivos)
                {
                    listBox_pratos.Items.Add(prato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarExtrasAtivos()
        {
            try
            {
                BindingList<Extra> extrasAtivos = extraController.GetExtrasAtivos();
                listBox_extras.Items.Clear();
                foreach (var extra in extrasAtivos)
                {
                    listBox_extras.Items.Add(extra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_criar_menu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dateTimePicker1.Value;
                DateTime hora = dateTimePicker2.Value;

                DateTime dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hour, hora.Minute, hora.Second);

                decimal precoEstudante = decimal.Parse(textBox_precoest.Text);
                decimal precoProfessor = decimal.Parse(textBox_precoprof.Text);

                List<Prato> pratosSelecionados = listBox_pratos.SelectedItems.Cast<Prato>().ToList();
                List<Extra> extrasSelecionados = listBox_extras.SelectedItems.Cast<Extra>().ToList();

                if (pratosSelecionados.Count != 3)
                {
                    MessageBox.Show("Selecione exatamente 3 pratos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool temCarne = pratosSelecionados.Any(p => p.Tipo.ToLower() == "carne");
                bool temPeixe = pratosSelecionados.Any(p => p.Tipo.ToLower() == "peixe");
                bool temVegetariano = pratosSelecionados.Any(p => p.Tipo.ToLower() == "vegetariano");

                if (!temCarne || !temPeixe || !temVegetariano)
                {
                    MessageBox.Show("Selecione um prato de cada tipo: Carne, Peixe e Vegetariano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BindingList<Prato> bindingPratosSelecionados = new BindingList<Prato>(pratosSelecionados);
                BindingList<Extra> bindingExtrasSelecionados = new BindingList<Extra>(extrasSelecionados);

                iCantina.Models.Menu menu = new iCantina.Models.Menu
                {
                    DataHora = dataHora,
                    PrecoEstudante = precoEstudante,
                    PrecoProfessor = precoProfessor,
                    Pratos = bindingPratosSelecionados,
                    Extras = bindingExtrasSelecionados
                };
                
                menuController.AddMenu(menu.DataHora, menu.PrecoEstudante, menu.PrecoProfessor, menu.Pratos, menu.Extras);

                lista_menu.Add(menu);
                AtualizarListBoxMenu();

                MessageBox.Show("Menu criado com sucesso!");
            }
            catch (DbUpdateException ex)
            {
                // Exibir a mensagem da exceção interna
                MessageBox.Show($"Erro ao salvar/atualizar no banco de dados: {ex.InnerException.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o menu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_apagar_menu_Click(object sender, EventArgs e)
        {
            try
            {
                iCantina.Models.Menu menu = (iCantina.Models.Menu)listBox_menu.SelectedItem;

                if (menu != null)
                {
                    menuController.DeleteMenu(menu.Id);
                    lista_menu.Remove(menu); // Remove da lista local

                    // Atualiza a listBox_menu
                    AtualizarListBoxMenu();

                    MessageBox.Show("Menu apagado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um menu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao apagar o menu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObterMenus()
        {
            try
            {
                lista_menu = menuController.GetMenus();
                AtualizarListBoxMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter os menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxMenu()
        {
            try
            {
               // lista_menu = menuController.GetMenus();
                listBox_menu.Items.Clear();
                foreach (var menu in lista_menu)
                {
                    listBox_menu.Items.Add(menu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista de menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
        public CantinaContext db;
        private ReservaController reservaController;
        public Formulario_Reserva(CantinaContext db)
        {
            this.db = db;
            this.reservaController = new ReservaController(this.db);
            InitializeComponent();
        }
    }
}

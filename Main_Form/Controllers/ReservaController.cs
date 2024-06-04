using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class ReservaController
    {
        public CantinaContext db;

        public ReservaController(CantinaContext db)
        {
            this.db = db;
        }

    }
}

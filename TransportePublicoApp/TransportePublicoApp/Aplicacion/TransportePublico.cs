using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublicoApp.Aplicacion
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }
        public TransportePublico(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
        public abstract string Avanzar();
        public abstract string Detener();

    }
}

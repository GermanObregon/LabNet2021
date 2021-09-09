using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublicoApp.Aplicacion
{
    public class Taxi : TransportePublico
    {
        public int NumeroTaxi { get; set; }
        public Taxi(int numeroTaxi , int cantidadPasajeros) : base(cantidadPasajeros)
        {
            this.NumeroTaxi = numeroTaxi;
        }
        public override string Avanzar()
        {
            return $"El Taxi numero {NumeroTaxi} esta en marcha con {Pasajeros} pasajeros.";
        }

        public override string Detener()
        {
            return $"El Taxi numero {NumeroTaxi} se detuvo, bajaron {Pasajeros} pasajeros en su destino.";
        }
    }
}

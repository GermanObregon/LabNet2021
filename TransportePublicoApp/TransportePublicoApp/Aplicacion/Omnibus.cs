

namespace TransportePublicoApp.Aplicacion
{
    public class Omnibus : TransportePublico
    {
        public int NumeroLinea { get; set; }
        public Omnibus(int numeroLinea , int cantidadPasajeros) : base(cantidadPasajeros)
        {
            this.NumeroLinea = numeroLinea;
        }
        public override string Avanzar()
        {
            return $"El Omnibus de la linea {NumeroLinea} esta en marcha con {Pasajeros} pasajeros.";
        }

        public override string Detener()
        {
            return $"El Omnibus de la linea {NumeroLinea} se detuvo, bajaron {Pasajeros} pasajeros en su destino.";
        }
    }
}

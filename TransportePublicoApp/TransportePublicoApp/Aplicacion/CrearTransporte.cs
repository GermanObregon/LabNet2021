

namespace TransportePublicoApp.Aplicacion
{
    public class CrearTransporte
    {
        private Taxi Taxi;
        private Omnibus Omnibus;

        public Taxi CrearTaxi(int numeroTaxi , int cantidadPasajeros)
        {
            this.Taxi = new Taxi(numeroTaxi, cantidadPasajeros);

            return Taxi;
        }

        public Omnibus CrearOmnibus(int numeroLinea, int cantidadPasajeros)
        {
            this.Omnibus = new Omnibus(numeroLinea, cantidadPasajeros);

            return Omnibus;
        }
    }
}

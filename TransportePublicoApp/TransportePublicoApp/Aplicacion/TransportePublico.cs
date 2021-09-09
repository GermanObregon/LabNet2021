

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

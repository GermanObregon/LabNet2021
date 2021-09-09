
using System.Collections.Generic;


namespace TransportePublicoApp.Aplicacion
{
    public class EnListarTransportes
    {
        private List<Omnibus> Omnibus;
        private List<Taxi> Taxis;

        public EnListarTransportes()
        {
            this.Omnibus = new List<Omnibus>();
            this.Taxis = new List<Taxi>();
        }

        public void EnlistarTaxi(Taxi taxi) {
            
            this.Taxis.Add(taxi);
               
        }

        public void EnlistarOmnibus(Omnibus omnibus) {
            
            this.Omnibus.Add(omnibus);
        }

        public List<Taxi> GetTaxis()
        {
            return this.Taxis;
        }

        public List<Omnibus> GetOmnibus() {
            return this.Omnibus;
        }
    }
}

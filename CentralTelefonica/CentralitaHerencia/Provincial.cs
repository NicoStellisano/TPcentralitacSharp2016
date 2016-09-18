using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        private float CostoLlamada
        {
            get
            {
                return CalcularCosto(); 
            }
        }

        public void Mostrar()
        {

        }

        private float CalcularCosto()
        {
            
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {

        }
    }
}

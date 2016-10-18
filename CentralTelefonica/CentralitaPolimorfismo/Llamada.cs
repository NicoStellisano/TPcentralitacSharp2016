using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        private float _duracion;

        protected float Duracion
        {
            get { return _duracion; }
        }
        private string _nroDestino;

        protected string NroDestino
        {
            get { return _nroDestino; }
        }
        private string _nroOrigen;

        protected string NroOrigen
        {
            get { return _nroOrigen; }
        }

        public float CostoLlamada
        {
            get
            {
                
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {

        }

        protected string Mostrar()
        {

        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {

        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {

        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {

        }


    }
}

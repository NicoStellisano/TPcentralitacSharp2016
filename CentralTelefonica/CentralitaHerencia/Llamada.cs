using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        protected string _nroDestino;
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        protected string _nroOrigen;
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public Llamada()
        {
            _duracion = 0;
        }
        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;

        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Origen: " + this._nroOrigen + " Destino: " + this._nroDestino + "Duracion: " + this._duracion);
            Console.WriteLine(sb.ToString());
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno._duracion.ToString().CompareTo(dos._duracion.ToString());
        }

    }
}

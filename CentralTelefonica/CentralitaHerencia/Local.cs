using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        public float CostoLamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return _costo * _duracion;
        }

        public Local(Llamada unaLlamada, float costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._nroOrigen = origen;
            this._duracion = duracion;
            this._nroDestino = destino;
            this._costo = costo;
        }

        public void Mostrar()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected double _costo;

        public double CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private double CalcularCosto()
        {
            return _costo * _duracion;
        }

        public Local(Llamada unaLlamada, float costo)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, double costo):base(origen,destino,duracion)
        {
            this._nroOrigen = origen;
            this._duracion = duracion;
            this._nroDestino = destino;
            this._costo = costo;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Costo : " + this.CostoLlamada);
            Console.WriteLine("Origen: " + this.NroOrigen + " Duracion: " + this.Duracion + " Destino: " +this.NroDestino + sb.ToString());

        }
    }
}

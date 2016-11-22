using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected double _costo;
        public double Costo
        {
            get { return this._costo; }
            set { this._costo = value; }
        }

        public override double CostoLlamada
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
        public Local()
        {

        }

        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, double costo)
            : base(origen, destino, duracion)
        {
            this._nroOrigen = origen;
            this._duracion = duracion;
            this._nroDestino = destino;
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
        
            sb.AppendLine("Origen: " + this.NroOrigen + " Duracion: " + this.Duracion + " Destino: " + this.NroDestino + " Costo : " + this.CostoLlamada);
            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}

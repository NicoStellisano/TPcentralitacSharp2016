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

        public double CostoLlamada
        {
            get
            {
                return CalcularCosto(); 
            }
        }
       
            protected string Mostrar()
            {
                StringBuilder sb = new StringBuilder();    
                 sb.AppendLine("Origen: " + this.NroOrigen + " Duracion: " + this.Duracion + " Destino: " + this.NroDestino + "Franja : " + this._franjaHoraria.ToString() + "Costo : " + this.CostoLlamada);
                 return sb.ToString();
             }

        private double CalcularCosto()
        {
            if (this._franjaHoraria == Franja.Franja_1)
                return 0.99*this.Duracion;
            else if (this._franjaHoraria == Franja.Franja_2)
                return 1.25 * this.Duracion;
            else 
                return 0.66 * this.Duracion;
           
        }

        public Provincial(Franja miFranja, Llamada unaLlamada):this(unaLlamada.NroOrigen,(Franja)miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {
            this._franjaHoraria = miFranja;
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {
            this._nroOrigen = origen;
            this._franjaHoraria = miFranja;
            this._duracion = duracion;
            this._nroDestino = destino;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;

        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}

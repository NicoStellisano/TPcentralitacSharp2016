using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private double _aux;

        public double GananciaPorLocal
        {
            get
            {
                foreach (Local item in this._listaDeLlamadas)
                {
                    this._aux +=item.CostoLlamada;
                }
                return this._aux;
            }
        }

        public double GananciaPorProvincial
        {
            get
            {
                foreach (Provincial item in this._listaDeLlamadas)
                {
                    this._aux += item.CostoLlamada;
                }
                return this._aux;
            }
        }
        public double GananciaTotal
        {
            get
            {
                foreach (Local item in this._listaDeLlamadas)
                {
                    this._aux += item.CostoLlamada;
                }

                foreach (Provincial item in this._listaDeLlamadas)
                {
                    this._aux += item.CostoLlamada;
                }
                return this._aux;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        private double CalcularGanancia(TipoLlamada tipo)
        {
            double ganancia;
            if (tipo == TipoLlamada.Local)
            {
                foreach (var item in Llamadas)
                {
                    if (item is Local)
                    {
                        ganancia = this.GananciaPorLocal;
                    }
                }
                return GananciaPorLocal;
            }else 

            if (tipo == TipoLlamada.Provincial)
            {
                foreach (var item in Llamadas)
                {
                    if (item is Provincial)
                    {
                        ganancia = this.GananciaPorProvincial;
                    }
                }
                return GananciaPorProvincial;
            }

            else 
            {
                foreach (var item in Llamadas)
                {
                    if (item is Provincial)
                    {
                        ganancia = this.GananciaTotal;
                    }
                }
                return GananciaTotal;
            }

            
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public void Mostrar()
        {
            Console.WriteLine("RS: " + this._razonSocial + " Gan Tot: " + this.GananciaTotal + " Gan Local: " + this.GananciaPorLocal + " Gan Prov: " + this.GananciaPorProvincial);
            foreach (Llamada item in this._listaDeLlamadas)
            {
                item.Mostrar();
            }
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
            this.Mostrar();
        }

        private bool agregarLlamada(Llamada unaLlamada)
        {
            this._listaDeLlamadas.Add(unaLlamada);
            return true;
        }

        public static Centralita operator +(Centralita central, Llamada unaLlamada)
        {
            central.agregarLlamada(unaLlamada);
            return central;
        }
    
    }
}

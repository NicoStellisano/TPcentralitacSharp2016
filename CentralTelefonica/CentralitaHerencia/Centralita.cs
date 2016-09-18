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

        public float GananciaPorLocal
        {
            get
            {

            }
        }

        public float GananciaPorProvincial
        {
            get
            {

            }
        }
        public float GananciaTotal
        {
            get
            {

            }
        }
        public List<Llamada> Llamadas
        {
            get
            {

            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            if (tipo == TipoLlamada.Local)
            {

            }

            if (tipo == TipoLlamada.Provincial)
            {

            }

            if (tipo == TipoLlamada.Todas)
            {

            }
        }

        public Centralita()
        {
            
        }

        public Centralita(string nombreEmpresa)
        {

        }

        public void Mostrar()
        {
            Console.WriteLine("RS: " + this._razonSocial + " Gan Tot: " + this.GananciaTotal + " Gan Local: " + this.GananciaPorLocal + " Gan Prov: " + this.GananciaPorProvincial);
            Console.WriteLine();
        }

        public void OrdenarLlamadas()
        {

        }
    
    }
}

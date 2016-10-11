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


    }
}

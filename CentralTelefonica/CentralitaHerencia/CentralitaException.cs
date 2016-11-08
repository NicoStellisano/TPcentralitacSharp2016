using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException:Exception
    {
        private Exception _excepcionInterna;

        public Exception Excepcion
        {
            get { return _excepcionInterna; }
            set { _excepcionInterna = value; }
        }

        private string _nombreClase;

        public string NombreClase
        {
            get { return _nombreClase; }
            set { _nombreClase = value; }
        }
        private string _nombreMetodo;

        public string NombreMetodo
        {
            get { return _nombreMetodo; }
            set { _nombreMetodo = value; }
        }

        private string _mensaje;
        public CentralitaException(string mensaje,string clase,string metodo)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
            this._mensaje = mensaje;
        }

        public CentralitaException(string mensaje, string clase, string metodo,Exception innerException):this(mensaje,clase,metodo)
        {
            this._excepcionInterna = innerException;
        }

    }
}

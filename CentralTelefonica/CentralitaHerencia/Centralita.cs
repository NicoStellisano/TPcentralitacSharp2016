using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace CentralitaHerencia
{
    [XmlInclude(typeof(Llamada))]
    [XmlInclude(typeof(Provincial))]
    [XmlInclude(typeof(Local))]

    public class Centralita:ISerializable
    {
        private List<Llamada> _listaDeLlamadas;
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }

        }

        protected string _razonSocial;
        public string RazonSocial
        {
            get { return this._razonSocial; }
            set { this._razonSocial = value; }
        }

        private double _aux;
        public static int contador=0;

        protected string _ruta;
        public string RutaDeArchivo
        {
            get { return this._ruta; }
            set { this._ruta = value; }
        }

        public double GananciaPorLocal
        {
            get
            {
                foreach (Llamada item in this._listaDeLlamadas)
                {
                    if(item is Local)
                    this._aux +=((Local)item).CostoLlamada;
                }
                return this._aux;
            }
        }

        public double GananciaPorProvincial
        {
            get
            {
                foreach (Llamada item in this._listaDeLlamadas)
                {
                    if (item is Provincial)
                        this._aux += ((Provincial)item).CostoLlamada;
                }
                return this._aux;
            }
        }
        public double GananciaTotal
        {
            get
            {
                foreach (Llamada item in this._listaDeLlamadas)
                {
                    if (item is Local)
                        this._aux += ((Local)item).CostoLlamada;
                }

                foreach (Llamada item in this._listaDeLlamadas)
                {
                    if (item is Provincial)
                        this._aux += ((Provincial)item).CostoLlamada;
                }
                return this._aux;
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

        

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
            Console.Write(this.ToString());
        }

        private void agregarLlamada(Llamada unaLlamada)
        {
            bool escribir = true;

            try
            {
                this._listaDeLlamadas.Add(unaLlamada);
                this.GuardarEnArchivo(unaLlamada, escribir);
                Console.Write(this.ToString());
            }
            catch (Exception e)
            {
                
                throw new CentralitaException(e.Message,e.Source,e.TargetSite.ToString(),e);
            }
           
        }

        public static Centralita operator +(Centralita central, Llamada unaLlamada)
        {
            if (central != unaLlamada)
                central.agregarLlamada(unaLlamada);
            else
                Console.WriteLine("Ya existe esa llamada");
            return central;
        }

        public static bool operator !=(Centralita central, Llamada unaLlamada)
        {
            return !(central == unaLlamada);
        }

        public static bool operator ==(Centralita central, Llamada unaLlamada)
        {
            foreach (Llamada item in central._listaDeLlamadas)
            {
                if (item == unaLlamada)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RS: " + this._razonSocial + " Gan Tot: " + this.GananciaTotal + " Gan Local: " + this.GananciaPorLocal + " Gan Prov: " + this.GananciaPorProvincial);
            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine((((Local)item).ToString()));
                }

                if (item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).ToString());

                }
            }

            return sb.ToString();
        }

        protected bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            bool funciona = false;
            try
            {
                using (StreamWriter escritor = new StreamWriter("Centralita.txt",agrego))
                {
                    escritor.WriteLine();
                    escritor.WriteLine("CALL: ");
                    escritor.WriteLine(DateTime.Now.ToString());

                    if (unaLlamada.GetType() == typeof(Local))
                    {
                        escritor.WriteLine(((Local)unaLlamada).ToString());
                    }
                    else if (unaLlamada.GetType() == typeof(Provincial)) 
                    {
                        escritor.WriteLine(((Provincial)unaLlamada).ToString());
                    }
                    funciona = true;
                }
            }
            catch (Exception e)
            {
                funciona = false;
                throw new CentralitaException("Error al escribir archivo",e.Source,e.TargetSite.ToString(),e);
            }
            return funciona;
        }

        public bool Serializarse()
        {
           return Serializador.SerializarCentralita(this);

        }

        public bool DeSerializarse()
        {
            bool flag = false;
            try
            {
                Serializador.DeserializarCentral(this.RutaDeArchivo);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                Console.WriteLine(ex.Message);
            }

            return flag;
        }


    
    }
}

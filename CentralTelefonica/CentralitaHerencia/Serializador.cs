using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public static class Serializador
    {
        public static class Serializador
        {
           /* public static bool SerializarLlamada(Llamada llamada)
            {
                bool flag = false;
                try
                {
                    using (XmlTextWriter escritor = new XmlTextWriter("Llamada.xml", Encoding.UTF8))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(Llamada));
                        serializador.Serialize(escritor, llamada);
                        flag = true;
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                    throw new CentralitaException("No se pudo serializar ","Tipo: " + llamada.GetType().ToString(), " SerializarLlamada", ex);
                    // throw;
                }
                return flag;
            }

            public static Llamada DeserializarLlamada()
            {
                // bool flag = false;
                Llamada llamad = null;

                try
                {
                    using (XmlTextReader lector = new XmlTextReader("Llamada.xml"))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(Llamada));
                        llamad = (Llamada)serializador.Deserialize(lector);
                        // flag = true;
                    }
                }
                catch (Exception ex)
                {
                    //  flag = false;
                    throw new CentralitaException("No se pudo Deserializar ", "Tipo: " + llamad.GetType().ToString(), " SerializarLlamada", ex);

                }
                return llamad;
            }


            public static void SerializarListaPersonas(List<Llamada> listadoLlam)
            {
                try
                {
                    using (XmlTextWriter escritor = new XmlTextWriter("ListadoLlamadas.xml", Encoding.UTF8))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(List<Llamada>));
                        serializador.Serialize(escritor, listadoLlam);
                    }
                }
                catch (Exception ex)
                {
                    throw new CentralitaException("No se pudo serializar ", "Tipo: " + listadoLlam.GetType().ToString(), " SerializarListaPersonas", ex);

                    // throw;
                }

            }
*/
            public static bool SerializarCentralita(Centralita central)
            {
                bool flag = false;
                try
                {
                    using (XmlTextWriter escritor = new XmlTextWriter(central.RutaDeArchivo, Encoding.UTF8))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(Centralita));
                        serializador.Serialize(escritor, central);
                        flag = true;
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                    throw new CentralitaException("No se pudo serializar ", "Tipo: " + central.GetType().ToString(), " SerializarCentralita", ex);
                    
                }

                return flag;

            }

            public static Centralita DeserializarCentral(string ruta)
            {
                // bool flag = false;
                Centralita central = null;

                try
                {
                    using (XmlTextReader lector = new XmlTextReader(ruta))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(Llamada));
                        central = (Centralita)serializador.Deserialize(lector);
                        // flag = true;
                    }
                }
                catch (Exception ex)
                {
                    //  flag = false;
                    throw new CentralitaException("No se pudo Deserializar ", "Tipo: " + central.GetType().ToString(), " SerializarLlamada", ex);

                }
                return central;
            }

            public static bool SerializarGenerico(ISerializable Iseria)
            {
                return Iseria.Serializarse();
            }
        }
    }
}

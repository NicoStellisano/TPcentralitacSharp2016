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
            public static bool SerializarLlamada(Llamada llamada)
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
                catch (Exception)
                {
                    flag = false;
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
                catch (Exception)
                {
                    //  flag = false;
                    //throw;
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
                catch (Exception)
                {

                    // throw;
                }

            }

            public static void SerializarCentralita(Centralita central)
            {
                try
                {
                    using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                        serializador.Serialize(escritor, central);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

            public static bool SerializarGenerico(ISerializable Iseria)
            {
                return Iseria.Serializarse();
            }
        }
    }
}

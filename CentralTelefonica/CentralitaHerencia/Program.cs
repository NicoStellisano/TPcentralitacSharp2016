using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telef");
            Local llamada1 = new Local("425456", 30, "4656465", 2.65);
            Provincial llamada2 = new Provincial("4123456", Franja.Franja_1, 21, "56465");
            Local llamada3 = new Local("45252", 45, "45645", 1.99);
            Provincial llamada4 = new Provincial(Franja.Franja_3, llamada2);

            Telefonica += llamada1;
            Telefonica += llamada2;
            Telefonica += llamada3;
            Telefonica += llamada4;

            Telefonica.OrdenarLlamadas();
            Console.ReadKey();
        }
    }
}

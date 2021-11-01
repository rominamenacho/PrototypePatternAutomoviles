using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            FiatPrototype fiat = new FiatPrototype();
            AlfaRomeoPrototype alfa = new AlfaRomeoPrototype();
            DSPrototype ds = new DSPrototype();

            AutoPrototype PALIO = fiat.Clonar();
            PALIO.Modelo = "Palio";
            PALIO.Color = "NEgro";
            Console.WriteLine(PALIO.VerAuto());
                      

            AutoPrototype UNO = fiat.Clonar();
            UNO.Modelo = "Fiat Uno";
            UNO.Color = "Blanco";
            Console.WriteLine(UNO.VerAuto());



            AutoPrototype ds3 = ds.Clonar();
            ds3.Modelo = "3 chic";
            ds3.Color = "Blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype  ds4= ds.Clonar();
            ds4.Modelo = "DS4 ";
            ds4.Color = "NEGRO";
            Console.WriteLine(ds4.VerAuto());


            Console.ReadKey();
        }
    }
}

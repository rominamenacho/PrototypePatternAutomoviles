using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternAuto
{
   public abstract class AutoPrototype
    {
        private string color;
        private string modelo;

        public string Color { get => color; set => color = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public abstract AutoPrototype Clonar();

        public abstract string VerAuto();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternAuto
{
    class AlfaRomeoPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (AlfaRomeoPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"AlfaRomeo {Modelo} color {Color}";
        }
    }
}

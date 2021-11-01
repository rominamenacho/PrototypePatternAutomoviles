using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternAuto
{
    class DSPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (DSPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"DS {Modelo} color {Color}";
        }
    }
}

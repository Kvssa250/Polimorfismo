using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    public class Pomeranian : Perro
    {
        public override string ladrar()
        {
            return "Pomeranian está ladrando";
        }
        public override string dormir()
        {
            return "Pomeranian está durmiendo";
        }
        public override string cagar()
        {
            return "Pomeranian está cagando";
        }
        public override string mear()
        {
            return "Pomeranian está meando";
        }
        public override string comer()
        {
            return "Pomeranian está comiendo";
        }
    }
}

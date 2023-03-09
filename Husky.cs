using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    public class Husky : Perro
    {
        public override string ladrar()
        {
            return "Husky está ladrando";
        }
        public override string dormir()
        {
            return "Husky está durmiendo";
        }
        public override string cagar()
        {
            return "Husky está cagando";
        }
        public override string mear()
        {
            return "Husky está meando";
        }
        public override string comer()
        {
            return "Husky está comiendo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    public class Viralata : Perro
    {
        public override string ladrar()
        {
            return "Viralata está ladrando";
        }
        public override string dormir()
        {
            return "Viralata está durmiendo";
        }
        public override string cagar()
        {
            return "Viralata está cagando";
        }
        public override string mear()
        {
            return "Viralata está meando";
        }
        public override string comer()
        {
            return "Viralata está comiendo";
        }
    }
}

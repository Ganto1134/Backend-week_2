using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum
{
    internal class Impiego
    {
        public List<Esperienza> Esperienze { get; set; }

        public Impiego()
        {
            Esperienze = new List<Esperienza>();
        }
    }
}

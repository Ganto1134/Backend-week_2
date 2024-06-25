using System.Collections.Generic;

namespace Curriculum_visuale.Models
{
    public class Impiego
    {
        public List<Esperienza> Esperienze { get; set; }

        public Impiego()
        {
            Esperienze = new List<Esperienza>();
        }
    }
}


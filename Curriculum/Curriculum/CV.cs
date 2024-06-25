using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum
{
    internal class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public Impiego Impieghi { get; set; }

        public CV()
        {
            StudiEffettuati = new List<Studi>();
        }
    }
}

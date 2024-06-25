namespace Curriculum_visuale.Models
{
    public class CV
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


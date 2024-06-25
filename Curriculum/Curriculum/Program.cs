namespace Curriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            CV cv = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Marco",
                    Cognome = "Puccio",
                    Telefono = "+393288317446",
                    Email = "info@marcopuccio.com"
                }
            };
            cv.StudiEffettuati.Add(new Studi
            {
                Qualifica = "",
                Istituto = "UniPa",
                Tipo = "",
                Dal = new DateTime(2016, 9, 12),
                Al = new DateTime(2019, 7, 22)
            });

            cv.StudiEffettuati.Add(new Studi
            {
                Qualifica = "",
                Istituto = "Microsoft Center Milan",
                Tipo = "Specializzazione sviluppo software",
                Dal = new DateTime(2016, 9, 12),
                Al = new DateTime(2019, 7, 22)
            });
            cv.Impieghi = new Impiego();
            cv.Impieghi.Esperienze.Add(new Esperienza
            {
                Azienda = "Libero Professionista",
                JobTitle = "IT Manager",
                Dal = new DateTime(2016, 9, 12),
                Al = new DateTime(2016, 9, 12),
                Descrizione = "Sviluppatore software",
                Compiti = "Sviluppatore software"
            });

            cv.Impieghi.Esperienze.Add(new Esperienza
            {
                Azienda = "Libero Professionista",
                JobTitle = "Docente e Formatore",
                Dal = new DateTime(2016, 9, 12),
                Al = new DateTime(2016, 9, 12),
                Descrizione = "Docente e Formatore",
                Compiti = "Docenza e Formazione"
            });
            StampaDettagliCVSuSchermo(cv);
        }
        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine("++++ FINE Informazioni Personali: ++++");

            Console.WriteLine("\n++++ INIZIO Studi e Formazione: ++++");
            foreach (var studi in cv.StudiEffettuati)
            {
                Console.WriteLine($"Istituto: {studi.Istituto}");
                Console.WriteLine($"Qualifica: {studi.Qualifica}");
                Console.WriteLine($"Tipo: {studi.Tipo}");
                Console.WriteLine($"Dal: {studi.Dal} al {studi.Al}");
                Console.WriteLine();
            }
            Console.WriteLine("++++ FINE Studi e Formazione: ++++");

            Console.WriteLine("\n++++ INIZIO Esperienze professionali: ++++");
            foreach (var esperienza in cv.Impieghi.Esperienze)
            {
                Console.WriteLine($"Azienda: {esperienza.Azienda}");
                Console.WriteLine($"Job Title: {esperienza.JobTitle}");
                Console.WriteLine($"Dal: {esperienza.Dal} al {esperienza.Al}");
                Console.WriteLine($"Descrizione: {esperienza.Descrizione}");
                Console.WriteLine($"Compiti: {esperienza.Compiti}");
                Console.WriteLine();
            }
            Console.WriteLine("++++ FINE Esperienze professionali: ++++");
        }
    }
}

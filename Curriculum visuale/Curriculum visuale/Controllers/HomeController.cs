using Curriculum_visuale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Curriculum_visuale.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Create CV
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

            // Add studies
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

            // Add employment experiences
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

            return View(cv);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


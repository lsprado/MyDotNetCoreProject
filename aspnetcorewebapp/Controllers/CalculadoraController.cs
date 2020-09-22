using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetcorewebapp.Models;

namespace aspnetcorewebapp.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculadoraController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Método Index
        public IActionResult Index()
        {
            return View();
        }

        // Feature 01
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Somar(CalculadoraModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("ERROR: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subtrair(CalculadoraModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("ERROR: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dividir(CalculadoraModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("ERROR: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Multiplicar(CalculadoraModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError("ERROR: " + ex.Message);
                return View();
            }
        }

    }
}
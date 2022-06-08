using LaClinica.Dominio;
using LaClinica.Dominio.Contratos;
using LaClinica.Presentacion.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LaClinica.Presentacion.Controllers.Llamadas
{
    public class LlamadasController : Controller
    {
        private readonly IRepositorioSintomas repositorioSintomas;
        private readonly IRepositorioLlamadas repositorioLlamadas;

        public LlamadasController(IRepositorioSintomas repositorioSintomas, IRepositorioLlamadas repositorioLlamadas)
        {
            this.repositorioSintomas = repositorioSintomas;
            this.repositorioLlamadas = repositorioLlamadas;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.hora = DateTime.Now.ToString("HH:mm");
            return View();
        }

        [HttpPost]
        public IActionResult Post(LlamadaViewModel Llamada)
        {
            List<LlamadaViewModel> Llamadas = new List<LlamadaViewModel>();
            var listaLlamada = repositorioLlamadas.GetLlamada();

            foreach (Llamada llam in listaLlamada)
            {
                Llamadas()
            }

            repositorioLlamadas.CreateLlamada(Llamada);

            ViewBag.hora = DateTime.Now.ToString("HH:mm");
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using CFarma_TemplateN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using CFarma_TemplateN.Data;
using Microsoft.EntityFrameworkCore;

namespace CFarma_TemplateN.Controllers
{
    public class CarritoController : Controller
    {
        private readonly ILogger<CarritoController> _logger;

        private readonly ApplicationDbContext _context;

        public CarritoController(ILogger<CarritoController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }


        public IActionResult Listar()
        {
            var usuario = "user";
            var listarCarrito = _context.Carritos.Where(x => x.id_cliente.Equals(usuario)).ToList();

         
            ViewData["listaCarrito"] = listarCarrito;

            return View();
        }



    }
}

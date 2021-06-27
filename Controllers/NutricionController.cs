using CFarma_TemplateN.Data;
using CFarma_TemplateN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFarma_TemplateN.Controllers
{
    public class NutricionController : Controller
    {
        private readonly ILogger<NutricionController> _logger;

        private readonly ApplicationDbContext _context;
        public NutricionController(ILogger<NutricionController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hierro()
        {

            var listarProductos = _context.Productos.ToList();

            var listaTipo = listarProductos.Where(x => x.CodSubc == 4001).ToList();

 
            ViewBag.Add(listarProductos);
            return View(listarProductos);
        }
        public IActionResult Magnesio()
        {
            return View();
        }
        public IActionResult Zinc()
        {
            return View();
        }
    }
}

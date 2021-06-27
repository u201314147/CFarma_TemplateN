using Microsoft.AspNetCore.Mvc;
using CFarma_TemplateN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using CFarma_TemplateN.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CarritoPrueba1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        private readonly ApplicationDbContext _context;

        public ProductoController(ILogger<ProductoController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Listar(int id)
        {
            var listarProductos = _context.Productos.ToList();


            ArrayList listaTipo = new ArrayList();

            foreach (var item in listarProductos)
            {
                var Producto = _context.Productos.Where(x => x.CodSubc == id);
                listaTipo.Add(Producto);
            }


            
           
            


            return View(listarProductos);
        }

   


    }
}

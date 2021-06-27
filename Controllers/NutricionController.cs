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


            ViewData["listaTipo"] = listaTipo;
            return View(listarProductos);
        }
        public IActionResult Magnesio()
        {
            var listarProductos = _context.Productos.ToList();

            var listaTipo = listarProductos.Where(x => x.CodSubc == 4002).ToList();


            ViewData["listaTipo"] = listaTipo;
            return View(listarProductos);
        }
        public IActionResult Zinc()
        {
            var listarProductos = _context.Productos.ToList();

            var listaTipo = listarProductos.Where(x => x.CodSubc == 4003).ToList();


            ViewData["listaTipo"] = listaTipo;
            return View(listarProductos);
        }


        [HttpPost]
        [Route("/Nutricion/Agregar")]
        public IActionResult Agregar([FromQuery] string cliente, [FromQuery] string producto, [FromQuery] int cantidad)
        {
            Carrito objCarrito = new Carrito();

            objCarrito.id_cliente = cliente;
            objCarrito.id_producto = producto;
            objCarrito.cantidad = cantidad;
           // objCarrito.identificador = identificador;
            try
            {
                //guardar
                _context.Add(objCarrito);
                _context.SaveChanges();

            }catch(Exception e)
            {
                return Ok("ERROR");
            }
            RedirectToAction("Carrito", "Carrito");

            return Ok(objCarrito);
            //return View("Carrito");

        }
    }
}

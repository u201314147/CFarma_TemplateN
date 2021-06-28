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



        [Route("/Nutricion/%2F")]
        public IActionResult Registrar(int id_producto)
        {
            var objProduct = _context.Productos.FirstOrDefault(x=>x.idpt==id_producto);
            Carrito objCarrito = new Carrito();

            objCarrito.id_cliente = "user";
            objCarrito.id_producto = objProduct.idpt.ToString();
            objCarrito.identificador = objProduct.Nom.ToString();
            objCarrito.cantidad = 1;
            //si está todo VALIDADO, recién aparece esta wea
            if (ModelState.IsValid)
            {
                //guardar
                _context.Add(objCarrito);
                _context.SaveChanges();

                //objCliente.confirmacion = "Gracias, estamos en contacto";
            }

            // return RedirectToAction("Index", "Home");
           return View("Carrito");
        }

        [HttpPost]
        [Route("/Nutricion/Agregar2")]
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

        public IActionResult Listar()
        {
            var usuario = "user";
            var listarCarrito = _context.Carritos.Where(x => x.id_cliente.Equals(usuario)).ToList();


            ViewData["listaCarrito"] = listarCarrito;

            return View();
        }
    }
}

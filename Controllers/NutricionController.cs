using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFarma_TemplateN.Controllers
{
    public class NutricionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hierro()
        {
            return View();
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

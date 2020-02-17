using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ejercicio2MVC.Models;

namespace Ejercicio2MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Data numero)
        {
            if (ModelState.IsValid)
            {
                int _numero1 = numero.number1; int _numero4 = numero.number4; int _numero7 = numero.number7;
                int _numero2 = numero.number2; int _numero5 = numero.number5; int _numero8 = numero.number8;
                int _numero3 = numero.number3; int _numero6 = numero.number6; int _numero9 = numero.number9;
                int _numero10 = numero.number10;

                int[] numericos = new int[10];
                int[,] suma = new int[10, 10];

                numericos = new int[10]{ _numero1, _numero2, _numero3, _numero4,  _numero5, _numero6, _numero7, _numero8, _numero9, _numero10};
                ViewData["NumeroMax"] = numericos.Max();
                ViewData["NumeroMin"] = numericos.Min();
               
                for(int i=0; i <= 9; i++)
                {
                    for(int j = 0; j <= 9; j++)
                    {
                        suma[i, j] += numericos[j];
                        ViewData["Suma0"+j] = suma[0, 0]+suma[0,j];
                        ViewData["Suma1" + j] = suma[0, 1] + suma[0, j];
                        ViewData["Suma2" + j] = suma[0, 2] + suma[0, j];
                        ViewData["Suma3" + j] = suma[0, 3] + suma[0, j];
                        ViewData["Suma4" + j] = suma[0, 4] + suma[0, j];
                        ViewData["Suma5" + j] = suma[0, 5] + suma[0, j];
                        ViewData["Suma6" + j] = suma[0, 6] + suma[0, j];
                        ViewData["Suma7" + j] = suma[0, 7] + suma[0, j];
                        ViewData["Suma8" + j] = suma[0, 8] + suma[0, j];
                        ViewData["Suma9" + j] = suma[0, 9] + suma[0, j];
                        

                    }
                }
               
            }
         
            return View("Index");
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

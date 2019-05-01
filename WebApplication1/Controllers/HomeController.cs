using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult userRegistration()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
        public async Task<ActionResult> Po(DataServiceModel dataServiceModel)
        {

            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("http://localhost:53265/api/Values/Post");

                //HTTP POST
                var postTask = await client.PostAsync("http://localhost:53265/api/Values", new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(dataServiceModel), System.Text.Encoding.UTF8, "application/json"));



                if (postTask.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(dataServiceModel);
        }

       
    }
}


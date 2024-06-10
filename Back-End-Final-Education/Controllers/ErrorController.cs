using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult AppNotFound()
        {
            return View();
        }

        public IActionResult AppInternalServer()
        {
            return View();
        }

        public IActionResult BadRequest()
        {
            return View();
        }

        [Route("Error/{statusCode}")]
        public IActionResult Error(int? statusCode)
        {
            if (statusCode.HasValue)
            {
                switch (statusCode)
                {
                    case 404:
                        return View(nameof(AppNotFound));
                    case 400:
                        return View(nameof(BadRequest));
                    default:
                        break;
                }
            }

            return View(nameof(AppInternalServer));
        }
    }
}


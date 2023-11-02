using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/Prestamos")]
    public class PrestamosControllers : ControllerBase
    {

        public readonly PrestamosServices prestamosServices;
        public PrestamosControllers(PrestamosServices services)
        {
            prestamosServices = services;
        }

        [HttpGet]

        public IActionResult GetPrestamos()
        {
            List<Prestamos> prestamos = prestamosServices.GetPrestamos();
            return Ok(prestamos);
        }

        

    }
}
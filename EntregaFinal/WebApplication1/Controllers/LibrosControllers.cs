using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/api/libros")]
    public class LibrosControllers : ControllerBase
    {
        public readonly LibrosServices librosServices;
        

        public LibrosControllers(LibrosServices services)
        {
            librosServices = services;
        }

        [HttpGet]

        public IActionResult GetLibros()
        {
            List<Libros> libros = librosServices.GetLibros();
            return Ok(libros);
        }

        [HttpPost]

        public IActionResult CrearLibro(Libros libro)
        {
            if (libro.Titulo.IsNullOrEmpty())
            {
                return BadRequest("Falta titulo");
            }
            else if(libro.PrecioReposicion == null)
            {
               return BadRequest("no agrego precio");
                
            }
            Libros LibroCreado = librosServices.CrearLibros(libro);
            int Id = LibroCreado.Id;
            return CreatedAtAction(nameof(GetLibros), Id, libro);
            
        }


    }
}
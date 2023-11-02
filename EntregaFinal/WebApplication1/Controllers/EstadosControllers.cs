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
    [Route("/Api")]
    public class EstadosControllers : ControllerBase
    {
        public readonly EstadosServices estadosservices;

        public EstadosControllers(EstadosServices services)
        {
            estadosservices = services;
        }
        [HttpGet]
        public IActionResult GetEstados()
        {
            List<Estados> estados = estadosservices.GetEstados();
            return Ok(estados);
        }

        [HttpPost]

        public IActionResult CrearEstados(Estados estado)
        {
           Estados EstadosCreados = estadosservices.CrearLibros(estado);
            int Id = EstadosCreados.Id;
            return CreatedAtAction(nameof(GetEstados), Id, estado);

        }
        
    }
}
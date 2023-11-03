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
    [Route("/api/estados")]
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
            Estados EstadosCreados = estadosservices.CrearEstados(estado);
            int Id = EstadosCreados.Id;
            return CreatedAtAction(nameof(GetEstados), Id, estado);
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarEstado(int id)
        {
            var estado = estadosservices.EliminarEstados(id);

            if (estado == null)
            {
                return NotFound(); // no se encontro el estado
            }

            return NoContent(); // 204 No Content para que muestre si lo borro con exito
        }

        [HttpGet("{estadoid}")]
        public IActionResult GetEstadoPorId(int estadoid)
        {
            var estado = estadosservices.GetEstadoPorId(estadoid);

            if (estado == null)
            {
                return NotFound(); // Estado no encontrado
            }

            return Ok(estado);
        }

    }
}
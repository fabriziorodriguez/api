using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Libros
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public decimal PrecioReposicion { get; set; }

        public int EstadoId { get; set; }

        public Estados Estado { get; set; }

        public List<Prestamos> Prestamos { get; set; }
    }
}
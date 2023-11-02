using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Prestamos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int DiasPrestamo { get; set; }

        public bool FueDevuelto { get; set; }

        public int LibroId { get; set; }

        public Libros Libro { get; set; }

    }
}
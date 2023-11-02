using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Estados
    {
          public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Libros> Libro { get; set; } = new();
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.BibliotecaContextt;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class LibrosServices
    {
       
         
    
        public List<Libros> GetLibros()
        {
            return new BibliotecaContext().Libros.ToList();
        }

        public Libros CrearLibros(Libros libro)
        {
            BibliotecaContext pc = new BibliotecaContext();
            pc.Libros.Add(libro);
            pc.SaveChanges();
            return libro;
        }
       

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.BibliotecaContextt;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PrestamosServices
    {
        BibliotecaContext bc = new();

        public List<Prestamos>GetPrestamos()
        {
            return bc.Prestamos.ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.BibliotecaContextt;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EstadosServices
    {
        BibliotecaContext dbc = new();
        public List<Estados>GetEstados()
        {
            return dbc.Estados.ToList();
        }
         public Estados CrearLibros(Estados estado)
        {
            BibliotecaContext pc = new BibliotecaContext();
            pc.Estados.Add(estado);
            pc.SaveChanges();
            return estado;
        }



        
    }
}
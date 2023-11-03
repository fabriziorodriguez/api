using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Messaging;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.BibliotecaContextt;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EstadosServices
    {
        BibliotecaContext dbc = new();
        public List<Estados> GetEstados()
        {
            return dbc.Estados.ToList();
        }

        public Estados CrearEstados(Estados estado)
        {
            BibliotecaContext pc = new BibliotecaContext();
            pc.Estados.Add(estado);
            pc.SaveChanges();
            return estado;
        }
        

        public Estados EliminarEstados(int id)
        {
            BibliotecaContext bc = new BibliotecaContext();
            Estados estado = bc.Estados.Find(id);

            if (estado != null)
            {
                bc.Estados.Remove(estado);
                bc.SaveChanges();
            }

            return estado;
        }

        public Estados GetEstadoPorId(int id)
        {
            return dbc.Estados.FirstOrDefault(e => e.Id == id);
        }




    }
}
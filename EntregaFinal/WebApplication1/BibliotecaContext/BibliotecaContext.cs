using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.BibliotecaContextt
{
    public class BibliotecaContext : DbContext
    {
          public virtual DbSet<Libros> Libros { get; set; }

        public virtual DbSet<Prestamos> Prestamos { get; set; }

        public virtual DbSet<Estados> Estados { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(@"Server=DESKTOP-JB3HNU9\SQLEXPRESS;Database=BIBLIOTECA; User ID=sa; Password=156145502; Trusted_Connection=true;Encrypt=False;");
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppEjercicioFinal.Models;

namespace WebAppEjercicioFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppEjercicioFinal.Models.Persona> Persona { get; set; }
        public DbSet<WebAppEjercicioFinal.Models.Producto> Producto { get; set; }
        public DbSet<WebAppEjercicioFinal.Models.Tienda> Tienda { get; set; }
    }
}

using KDControl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDControl
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
        }

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<SupervisorS> SupervisorS { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<Autobus> Autobuss { get; set; }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
    }
}

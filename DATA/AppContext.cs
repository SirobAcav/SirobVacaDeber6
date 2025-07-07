using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SirobVacaDeber6.Models;

namespace SirobVacaDeber6.DATA
{
    public class AppContext : DbContext
    {
        public DbSet<ProductoModel> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexion = "server=localhost;database=bd_distribuidoraAlimentos;pwd=;uid=root";
            var version_mysql = new MySqlServerVersion(new Version("10.4.32"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoModel>(
                (entidad) =>
                {
                    entidad.Property(p => p.Create_At).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    entidad.Property(p => p.Update_Up).HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");
                });
        }
    }
}

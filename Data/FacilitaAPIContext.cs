using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FacilitaAPI.Models;

namespace FacilitaAPI.Data
{
    public class FacilitaAPIContext : DbContext
    {
        public FacilitaAPIContext (DbContextOptions<FacilitaAPIContext> options)
            : base(options)
        {
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=FacilitaDB;Username=postgres;Password=root");
        }

        public DbSet<Usuario> Usuario { get; set; }
        
    }
}

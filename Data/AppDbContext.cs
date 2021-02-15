using BlazorAppServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppServer.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Eleve> Eleves { get; set; }

        public DbSet<Classe> Classes { get; set; }
        
        public DbSet<Inscription> Inscriptions { get; set; }

        public DbSet<Section> Sections { get; set; }
    }
}

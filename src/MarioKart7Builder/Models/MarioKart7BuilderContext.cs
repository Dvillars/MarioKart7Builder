using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarioKart7Builder.Models
{
    public class MarioKart7BuilderContext : DbContext
    {
        public virtual DbSet<Kart> Karts { get; set; }
        public virtual DbSet<Body> Bodys { get; set; }
        public virtual DbSet<Tire> Tires { get; set; }
        public virtual DbSet<Glider> Gliders { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KartBuilder;integrated security=True");
        }
    }
}

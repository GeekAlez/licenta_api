using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Pachet> Pachet { get; set; } = default!;
        public DbSet<WebAPI.Models.Category> Category { get; set; } = default!;
        public DbSet<WebAPI.Models.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<WebAPI.Models.Rezervare> Rezervare { get; set; } = default!;
        public DbSet<WebAPI.Models.SumarRezervare> SumarRezervare { get; set; } = default!;
    }
}

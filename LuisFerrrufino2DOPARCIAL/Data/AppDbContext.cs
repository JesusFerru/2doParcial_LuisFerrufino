using LuisFerrrufino2DOPARCIAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisFerrrufino2DOPARCIAL.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Naipe> Naipes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {



        }
    }
}

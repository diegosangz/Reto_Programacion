using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reto_Programacion.Models;

namespace Reto_Programacion.Data
{
    public class Reto_ProgramacionContext : DbContext
    {
        public Reto_ProgramacionContext (DbContextOptions<Reto_ProgramacionContext> options)
            : base(options)
        {
        }

        public DbSet<Reto_Programacion.Models.Cliente> Cliente { get; set; }
    }
}

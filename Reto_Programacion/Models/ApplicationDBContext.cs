using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Clase de modelo para la utilizacion de la base de datos
namespace Reto_Programacion.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
    }
        public DbSet<Cliente> Cliente { get; set; }
    }
    }

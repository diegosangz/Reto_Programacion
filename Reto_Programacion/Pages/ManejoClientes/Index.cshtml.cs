using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reto_Programacion.Models;

namespace Reto_Programacion.Pages.ManejoClientes
{
    public class IndexModel : PageModel
    {
        private readonly Reto_Programacion.Models.ApplicationDBContext _context;

        public IndexModel(Reto_Programacion.Models.ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; }

        [TempData]
        public string Mensaje { get; set; }
        
        //LLamado de los registros de la base de datos
        public async Task OnGetAsync()
        {
            Cliente = await _context.Cliente.ToListAsync();
        }
    }
}

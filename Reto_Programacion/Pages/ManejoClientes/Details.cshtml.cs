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
    public class DetailsModel : PageModel
    {
        private readonly Reto_Programacion.Models.ApplicationDBContext _context;

        public DetailsModel(Reto_Programacion.Models.ApplicationDBContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; }

        //LLamado a la informacion dentro de los campos de la tabla en la base de datos

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.ID == id);

            if (Cliente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

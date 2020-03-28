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
    public class DeleteModel : PageModel
    {
        private readonly Reto_Programacion.Models.ApplicationDBContext _context;

        public DeleteModel(Reto_Programacion.Models.ApplicationDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        [TempData]
        public string Mensaje { get; set; }

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

        //Funcionalidad para actualizar el campo status del registro dentro de la tabla cliente
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (Cliente != null)
            {
                var clientUpdate = await _context.Cliente.FindAsync(Cliente.ID);
                clientUpdate.Status = Cliente.Status;
                Mensaje = "Cliente DESACTIVADO con exito";
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

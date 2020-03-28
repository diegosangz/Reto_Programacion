using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reto_Programacion.Models;

namespace Reto_Programacion.Pages.ManejoClientes
{
    public class EditModel : PageModel
    {
        private readonly Reto_Programacion.Models.ApplicationDBContext _context;

        public EditModel(Reto_Programacion.Models.ApplicationDBContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cliente).State = EntityState.Modified;

            try
            {
                Mensaje = "Cliente EDITADO con exito";
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(Cliente.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.ID == id);
        }
    }
}

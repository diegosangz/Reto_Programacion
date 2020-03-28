using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reto_Programacion.Models;

namespace Reto_Programacion.Pages.ManejoClientes
{
    public class CreateModel : PageModel
    {
        private readonly Reto_Programacion.Models.ApplicationDBContext _context;

        public CreateModel(Reto_Programacion.Models.ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();
            Mensaje = "Cliente CREADO con exito";

            return RedirectToPage("./Index");
        }
    }
}

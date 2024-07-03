using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlMomento.Data;
using AlMomento.Models;

namespace AlMomento.Pages.Noticias.Gestionar
{
    public class CreateModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public CreateModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Noticia Noticia { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Noticia == null || Noticia == null)
            {
                return Page();
            }

            _context.Noticia.Add(Noticia);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

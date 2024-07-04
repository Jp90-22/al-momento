using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlMomento.Data;
using AlMomento.Models;

namespace AlMomento.Pages.Noticias.Gestionar
{
    public class EditarModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public EditarModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Noticia Noticia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Noticia == null)
            {
                return NotFound();
            }

            var noticia =  await _context.Noticia.FirstOrDefaultAsync(m => m.ID == id);
            if (noticia == null)
            {
                return NotFound();
            }
            Noticia = noticia;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Noticia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticiaExists(Noticia.ID))
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

        private bool NoticiaExists(int id)
        {
          return (_context.Noticia?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

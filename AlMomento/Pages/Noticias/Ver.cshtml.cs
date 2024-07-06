using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlMomento.Data;
using AlMomento.Models;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias
{
    public class VerModel : PageModel
    {
        private readonly AlMomentoContext _context;

        public VerModel(AlMomentoContext context)
        {
            _context = context;
        }

        public Noticia Noticia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Noticia == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticia.FirstOrDefaultAsync(m => m.ID == id);
            
            if (noticia == null)
            {
                return NotFound();
            }
            else
            {
                Noticia = noticia;
            }

            return Page();
        }
    }
}

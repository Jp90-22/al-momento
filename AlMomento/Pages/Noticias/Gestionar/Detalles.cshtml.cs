using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlMomento.Data;
using AlMomento.Models;

namespace AlMomento.Pages.Noticias.Gestionar
{
    public class DetallesModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public DetallesModel(AlMomento.Data.AlMomentoContext context)
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

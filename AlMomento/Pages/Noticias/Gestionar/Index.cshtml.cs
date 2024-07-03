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
    public class IndexModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public IndexModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }

        public IList<Noticia> Noticia { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                Noticia = await _context.Noticia.ToListAsync();
            }
        }
    }
}

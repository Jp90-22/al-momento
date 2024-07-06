using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public IndexModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }

        public IList<Noticia> NoticiasDestacadas { get; set; } = default!;
        public IList<Noticia> NoticiasRecientes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasDestacadas = await _context.Noticia.OrderByDescending(noticia => noticia.CantidadVisitas)
                    .Take(6).ToListAsync();

                NoticiasRecientes = await _context.Noticia.OrderByDescending(noticia => noticia.FechaPublicacion)
                    .Take(6).ToListAsync();
            }
        }
    }
}

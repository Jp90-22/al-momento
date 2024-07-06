using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class TurismoModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public TurismoModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }
        public IList<Noticia> NoticiasTurismo { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasTurismo = await _context.Noticia.Where(noticia => noticia.Categoria == "Turismo" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

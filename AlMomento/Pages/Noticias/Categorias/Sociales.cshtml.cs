using AlMomento.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class SocialesModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public SocialesModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }

        public IList<Noticia> NoticiasSociales { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasSociales = await _context.Noticia.Where(noticia => noticia.Categoria == "Sociales" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class DeportesModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public DeportesModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }
        public IList<Noticia> NoticiasDeportes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasDeportes = await _context.Noticia.Where(noticia => noticia.Categoria == "Deportes" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class EntretenimientoModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public EntretenimientoModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }
        public IList<Noticia> NoticiasEntretenimiento { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasEntretenimiento = await _context.Noticia.Where(noticia => noticia.Categoria == "Entretenimiento" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

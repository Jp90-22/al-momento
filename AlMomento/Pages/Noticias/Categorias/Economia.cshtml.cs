using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class EconomiaModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public EconomiaModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }
        public IList<Noticia> NoticiasEconomia { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasEconomia = await _context.Noticia.Where(noticia => noticia.Categoria == "Economía" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

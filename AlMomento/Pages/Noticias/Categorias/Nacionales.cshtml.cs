using AlMomento.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlMomento.Pages.Noticias.Categorias
{
    public class NacionalesModel : PageModel
    {
        private readonly AlMomento.Data.AlMomentoContext _context;

        public NacionalesModel(AlMomento.Data.AlMomentoContext context)
        {
            _context = context;
        }
        public IList<Noticia> NoticiasNacionales { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Noticia != null)
            {
                NoticiasNacionales = await _context.Noticia.Where(noticia => noticia.Categoria == "Nacionales" && noticia.Estado)
                    .OrderByDescending(noticia => noticia.FechaPublicacion).ToListAsync();
            }
        }
    }
}

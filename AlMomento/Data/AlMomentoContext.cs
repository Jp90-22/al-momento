using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlMomento.Models;

namespace AlMomento.Data
{
    public class AlMomentoContext : DbContext
    {
        public AlMomentoContext (DbContextOptions<AlMomentoContext> options)
            : base(options)
        {
        }

        public DbSet<AlMomento.Models.Noticia> Noticia { get; set; } = default!;
    }
}

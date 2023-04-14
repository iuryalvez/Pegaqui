using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pegaqui.Models;

namespace Pegaqui.Data
{
    public class PegaquiContext : DbContext
    {
        public PegaquiContext (DbContextOptions<PegaquiContext> options)
            : base(options)
        {
        }

        public DbSet<Pegaqui.Models.Usuario> Usuario { get; set; } = default!;
    }
}

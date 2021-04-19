using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sovitushuone.Models;

namespace Sovitushuone.Data
{
    public class SovitushuoneContext : DbContext
    {
        // Vaatehuone context
        public SovitushuoneContext (DbContextOptions<SovitushuoneContext> options)
            : base(options)
        {
        }

        public DbSet<Sovitushuone.Models.Vaatteet> Vaatteet { get; set; }
    }
}

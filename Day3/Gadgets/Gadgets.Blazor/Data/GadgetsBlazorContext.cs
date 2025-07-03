using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gadgets.Domain;

namespace Gadgets.Blazor.Data
{
    public class GadgetsBlazorContext : DbContext
    {
        public GadgetsBlazorContext (DbContextOptions<GadgetsBlazorContext> options)
            : base(options)
        {
        }

        public DbSet<Gadgets.Domain.Supplier> Supplier { get; set; } = default!;
        public DbSet<Gadgets.Domain.GadgetType> GadgetType { get; set; } = default!;
    }
}

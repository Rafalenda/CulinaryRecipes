using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesCulinaryRecipes.Models
{
    public class RazorPagesCulinaryRecipesContext : DbContext
    {
        public RazorPagesCulinaryRecipesContext (DbContextOptions<RazorPagesCulinaryRecipesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCulinaryRecipes.Models.Recipe> Recipe { get; set; }
    }
}

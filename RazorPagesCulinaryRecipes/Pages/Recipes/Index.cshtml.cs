using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCulinaryRecipes.Models;

namespace RazorPagesCulinaryRecipes.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCulinaryRecipes.Models.RazorPagesCulinaryRecipesContext _context;

        public IndexModel(RazorPagesCulinaryRecipes.Models.RazorPagesCulinaryRecipesContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}

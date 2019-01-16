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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCulinaryRecipes.Models.RazorPagesCulinaryRecipesContext _context;

        public DetailsModel(RazorPagesCulinaryRecipes.Models.RazorPagesCulinaryRecipesContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.ID == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace RazorPagesCulinaryRecipes.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ingredient;
        public DateTime ReleaseDate { get; set; }

    }
}

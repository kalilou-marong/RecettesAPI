using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Models;

namespace RecettesAPI_HBKMAM.Models
{
	[PrimaryKey(nameof(recipe_id), nameof(ingredient_id))]
	public class RecipeIngredient
	{
		public int recipe_id { get; set; }
		public Recipe recipe { get; set; }
		public int ingredient_id { get; set; }
		public Ingredient ingredient { get; set; }
		public string ingredient_quantity { get; set; }

	}
}
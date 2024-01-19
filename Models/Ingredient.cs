using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace RecettesAPI_HBKMAM.Models;

public class Ingredient
{
	[Key]
	public int ingredient_id { get; set; }
	public string name { get; set; }
	public string photo_url { get; set; }
	public List<RecipeIngredient> recipe_ingredients { get; set; }
}
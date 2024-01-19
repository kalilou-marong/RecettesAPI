using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Models;

namespace RecettesAPI_HBKMAM.Models;

public class Recipe
{
	[Key]
	public int recipe_id { get; set; }
	public int category_id { get; set; }
	public Categorie Categorie { get; set; }
	public string title { get; set; }
	public string photo_url { get; set; }
	public List<string> photos_array { get; set; }
	public int time { get; set; }
	public List<RecipeIngredient> recipe_ingredients { get; set; }
	public string description { get; set; }
}
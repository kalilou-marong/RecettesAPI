using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models;

namespace RecettesAPI_HBKMAM.Controllers;

[Route("RecipeIngredient")]
public class RecipeIngredientsController : Controller
{

	private readonly RecettesAPIContext _context;

	public RecipeIngredientsController(RecettesAPIContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult GetRecipeIngredient()
	{
		var recipeIngredient = _context.RecipeIngredient.ToList();
		return Ok(recipeIngredient);
	}

	[HttpGet("{recipe_id}")]
	public IActionResult GetRecipeIngredientByRecipeId(int recipe_id)
	{
		var recipeIngredient = _context.RecipeIngredient
			.Where(r => r.recipe_id == recipe_id)
			.ToList();
		return Ok(recipeIngredient);
	}



}


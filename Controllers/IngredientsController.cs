using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models;

namespace RecettesAPI_HBKMAM.Controllers;

[Route("ingredient")]
public class IngredientsController : ControllerBase
{
	private readonly RecettesAPIContext _context;

	public IngredientsController(RecettesAPIContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult GetIngredient()
	{
		var ingredient = _context.Ingredient.ToList();
		return Ok(ingredient);
	}

	[HttpGet("{ingredient_id}")]
	public IActionResult GetIngredient(int ingredient_id)
	{
		var ingredient = _context.Ingredient.Find(ingredient_id);
		return Ok(ingredient);
	}

	[HttpPut("{ingredient_id}")]
	public IActionResult UpdateIngredient([FromBody] Ingredient ingredient)
	{
		_context.Ingredient.Update(ingredient);
		_context.SaveChanges();
		return Ok();
	}



	[HttpPost]
	public IActionResult AddIngredient([FromBody] Ingredient ingredient)
	{
		_context.Ingredient.Add(ingredient);
		_context.SaveChanges();
		return Ok();
	}

	[HttpDelete("{ingredient_id}")]
	public IActionResult DeleteIngredient(int ingredient_id)
	{

		var ingredient = _context.Ingredient.Find(ingredient_id);

		if (ingredient == null)
		{
			return NotFound(); // Retourne une réponse 404 si l'ingrédient n'est pas trouvé
		}

		_context.Ingredient.Remove(ingredient);
		_context.SaveChanges();

		return Ok();
	}
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecettesAPI_HBKMAM.Data;

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
}

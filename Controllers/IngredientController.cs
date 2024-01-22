using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models;

[ApiController]
[Route("ingredient")]
public class IngredientController : ControllerBase
{
    private readonly RecettesAPIContext _context;

    public IngredientController(RecettesAPIContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
    {
        var ingredients = await _context.Ingredient.ToListAsync();

        if (ingredients == null || ingredients.Count == 0)
        {
            return NotFound();
        }

        return Ok(ingredients);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models; 

namespace RecettesAPI_HBKMAM.Controllers
{
    [Route("recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecettesAPIContext _context;

        public RecipeController(RecettesAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetRecipes()
        {
            var recipes = _context.Recipe
                .Include(r => r.Categorie) // Include related category
                .Include(r => r.recipe_ingredients) // Include related recipe ingredients
                .ToList();

            if (recipes == null || recipes.Count == 0)
            {
                return NotFound();
            }

            return Ok(recipes);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            var recipeToDelete = _context.Recipe
                .Include(r => r.recipe_ingredients)
                .FirstOrDefault(r => r.recipe_id == id);

            if (recipeToDelete == null)
            {
                return NotFound();
            }
            _context.Recipe.Remove(recipeToDelete);
            _context.SaveChanges();

            return NoContent();
        }

       
        [HttpPost]
        public IActionResult CreateRecipe([FromBody] Recipe newRecipe)
        {

            // Validate the input if necessary

            // Add the new recipe to the context
            _context.Recipe.Add(newRecipe);
            _context.SaveChanges();

            // Return the created recipe
            return CreatedAtAction(nameof(GetRecipeById), new { id = newRecipe.recipe_id }, newRecipe);
        }

        [HttpGet("{id}")]
        public IActionResult GetRecipeById(int id)
        {
            // Retrieve the recipe by ID
            var recipe = _context.Recipe
                .Include(r => r.Categorie)
                .Include(r => r.recipe_ingredients)
                .FirstOrDefault(r => r.recipe_id == id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }

    }
}
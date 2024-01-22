using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models; // Add this line

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

        // [HttpPut("{id}")]
        // public IActionResult UpdateRecipe(int id, [FromBody] Recipe updatedRecipe)
        // {
        //     var existingRecipe = _context.Recipe
        //         .Include(r => r.recipe_ingredients)
        //         .FirstOrDefault(r => r.recipe_id == id);

        //     if (existingRecipe == null)
        //     {
        //         return NotFound();
        //     }

        //     // Update properties of existingRecipe with values from updatedRecipe
        //     existingRecipe.title = updatedRecipe.title;
        //     existingRecipe.photo_url = updatedRecipe.photo_url;
        //     existingRecipe.photos_array = updatedRecipe.photos_array;
        //     existingRecipe.time = updatedRecipe.time;
        //     existingRecipe.description = updatedRecipe.description;

        //     // Update related properties (e.g., Categorie, recipe_ingredients) if needed

        //     _context.SaveChanges();

        //     return Ok(existingRecipe);
        // }

    }
}
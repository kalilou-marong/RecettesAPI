// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using RecettesAPI_HBKMAM.Data;
// using RecettesAPI_HBKMAM.Models;

// namespace RecettesAPI_HBKMAM.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class RecipeController : ControllerBase
//     {
//         private readonly RecettesAPIContext _context;

//         public RecipeController(RecettesAPIContext context)
//         {
//             _context = context;
//         }

//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
//         {
//             var recipes = await _context.Recipe
//                 .Include(r => r.Ingredients)
//                 .ToListAsync();

//             if (recipes == null || recipes.Count == 0)
//             {
//                 return NotFound();
//             }

//             return Ok(recipes);
//         }
//     }
// }
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecettesAPI_HBKMAM.Data;

namespace RecettesAPI_HBKMAM.Controllers
{
    [Route("api/categorie")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly RecettesAPIContext _context;

        public CategorieController(RecettesAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategorie()
        {
            var categorie = _context.Category.ToList();
            return Ok(categorie);
        }
    }
}

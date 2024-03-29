﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecettesAPI_HBKMAM.Data;
using RecettesAPI_HBKMAM.Models;

namespace RecettesAPI_HBKMAM.Controllers
{
    [Route("categorie")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly RecettesAPIContext _context;

        public CategorieController(RecettesAPIContext context)
        {
            _context = context;
        }

        [HttpGet("{Id_categorie}")]
        public IActionResult GetCategorie()
        {
            var categorie = _context.Category.ToList();
            return Ok(categorie);
        }

        [HttpPost]
        public IActionResult CreateCategorie([FromBody] Categorie categorie)
        {
            _context.Category.Add(categorie);
            _context.SaveChanges();
            return CreatedAtAction("GetCategorie", new { id = categorie.Id_categorie }, categorie);
        }

        [HttpPut("{Id_categorie}")]
        public IActionResult UpdateCategorie([FromBody] Categorie categorie)
        {
            _context.Category.Update(categorie);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{Id_categorie}")]
        public IActionResult DeleteIngredient(int id_categorie)
        {

            var categorie = _context.Category.Find(id_categorie);

            if (categorie == null)
            {
                return NotFound();
            }

            _context.Category.Remove(categorie);
            _context.SaveChanges();

            return Ok();
        }
    }
}

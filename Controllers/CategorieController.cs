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

        [HttpGet]
        public IActionResult GetCategorie()
        {
            var categorie = _context.Category.ToList();
            return Ok(categorie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategorie([FromBody] Categorie categorie)
        {
            _context.Category.Update(categorie);
            _context.SaveChanges();
            return Ok();
        }
    }
}

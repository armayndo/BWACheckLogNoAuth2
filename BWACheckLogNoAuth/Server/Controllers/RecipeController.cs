using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Server.Services;
using BWACheckLogNoAuth.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        //private RecipeDbOperations dbOpereations = new RecipeDbOperations();
        private readonly IRecipeService _recipeService;
        private readonly AppDbContext _appDbContext;

        public RecipeController(IRecipeService recipeService, AppDbContext appDbContext)
        {
            _recipeService = recipeService;
            _appDbContext = appDbContext;
        }

        // GET: api/<controller>
        [HttpGet("recipes")]
        public async Task<IEnumerable<Recipe>> GetRecipes()
        {
            return await _recipeService.ListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("detail/{id}")]
        public async Task<Recipe> GetRecipeDetail(int id)
        {
            var result = await _recipeService.ListAsync();
            return result.FirstOrDefault(x => x.RecipeId == id);
        }

        // POST api/<controller>
        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                var result = await _recipeService.SaveAsync(recipe);
                return Ok(result);
            }

            return BadRequest("Data not valid");
                
        }

        // PUT api/<controller>/5
        [HttpPut("edit")]
        public async Task<IActionResult> Put([FromBody] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                var result = await _recipeService.UpdateAsync(recipe.RecipeId, recipe); //error DI if not

                //_appDbContext.Update(recipe);
                //_appDbContext.SaveChanges();
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _recipeService.DeleteAsync(id);
            return Ok(result);
        }
    }
}

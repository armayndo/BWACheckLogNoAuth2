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

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
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
        public void Post([FromBody] Recipe recipe)
        {
            if (ModelState.IsValid)
                _recipeService.SaveAsync(recipe);
        }

        // PUT api/<controller>/5
        [HttpPut("edit")]
        public void Put([FromBody] Recipe recipe)
        {
            if (ModelState.IsValid)
                _recipeService.UpdateAsync(recipe.RecipeId, recipe);
        }

        // DELETE api/<controller>/5
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            _recipeService.DeleteAsync(id);
        }
    }
}

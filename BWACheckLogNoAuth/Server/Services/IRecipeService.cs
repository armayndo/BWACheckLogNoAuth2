using BWACheckLogNoAuth.Server.Services.Communication;
using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> ListAsync();
        Task<RecipeResponse> SaveAsync(Recipe category);
        Task<RecipeResponse> UpdateAsync(int id, Recipe category);
        Task<RecipeResponse> DeleteAsync(int id);
    }
}

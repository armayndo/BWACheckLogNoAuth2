using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<Recipe>> ListAsync();
        Task AddAsync(Recipe category);
        Task<Recipe> FindByIdAsync(int id);
        void Update(Recipe category);
        void Remove(Recipe category);
    }
}

using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public class RecipeRepository : BaseRepository, IRecipeRepository
    {
        public RecipeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Recipe category)
        {
            await _context.tblRecipe.AddAsync(category);
        }

        public async Task<Recipe> FindByIdAsync(int id)
        {
            var result = await _context.tblRecipe.FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<Recipe>> ListAsync()
        {
            return await _context.tblRecipe
                                .AsNoTracking()
                                .ToListAsync();

            // AsNoTracking tells EF Core it doesn't need to track changes on listed entities. Disabling entity
            // tracking makes the code a little faster
        }

        public void Remove(Recipe category)
        {
            _context.tblRecipe.Remove(category);
        }

        public void Update(Recipe category)
        {
            _context.tblRecipe.Update(category);
        }
    }
}

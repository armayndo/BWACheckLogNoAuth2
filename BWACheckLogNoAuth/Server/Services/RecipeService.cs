using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Server.Data.Repositories;
using BWACheckLogNoAuth.Server.Services.Communication;
using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IRecipeRepository recipeRepository, IUnitOfWork unitOfWork)
        {
            _recipeRepository = recipeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<RecipeResponse> DeleteAsync(int id)
        {
            var existingData = _recipeRepository.FindByIdAsync(id);

            if (existingData == null)
                return new RecipeResponse("Category not found.");

            try
            {
                _recipeRepository.Remove(existingData.Result);
                //await _unitOfWork.CompleteAsync(); //error
                _unitOfWork.Complete();

                return new RecipeResponse(existingData.Result);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new RecipeResponse($"An error occurred when deleting the category: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Recipe>> ListAsync()
        {
            return await _recipeRepository.ListAsync();
        }

        public async Task<RecipeResponse> SaveAsync(Recipe recipe)
        {
            try
            {
                await _recipeRepository.AddAsync(recipe);
                //await _unitOfWork.CompleteAsync(); //error
                _unitOfWork.Complete();

                return new RecipeResponse(recipe);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new RecipeResponse($"An error occurred when saving the category: {ex.Message}");
                //return recipe;
            }
        }

        public async Task<RecipeResponse> UpdateAsync(int id, Recipe recipe)
        {
            var existingData = await _recipeRepository.FindByIdAsync(id);

            if (existingData == null)
                return new RecipeResponse("Category not found.");

            
            existingData.Description = recipe.Description;
            existingData.Ingredients = recipe.Ingredients;
            existingData.Name = recipe.Name;
            existingData.Notes = recipe.Notes;

            try
            {
                //_recipeRepository.Update(existingData);
                //await _unitOfWork.CompleteAsync(); //error
                _unitOfWork.Complete();

                return new RecipeResponse(existingData);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new RecipeResponse($"An error occurred when updating the category: {ex.Message}");
            }
        }
    }
}

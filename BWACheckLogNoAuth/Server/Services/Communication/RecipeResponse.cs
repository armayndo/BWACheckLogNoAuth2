using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Services.Communication
{
    public class RecipeResponse : BaseResponse<Recipe>
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="Recipe">Saved Recipe.</param>
        /// <returns>Response.</returns>
        public RecipeResponse(Recipe recipe) : base(recipe)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public RecipeResponse(string message) : base(message)
        { }
    }
}

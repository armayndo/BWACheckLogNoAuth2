using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Services
{
    public interface ISurveyService
    {
        Task<IEnumerable<SurveyQuestion>> GetSurveyQuestionsAsync();

        Task<UserResponse> SaveUserResponseAsync(UserResponse userResponse);
    }
}

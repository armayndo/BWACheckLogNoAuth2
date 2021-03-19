using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public interface ISurveyRepository
    {
        Task<IEnumerable<SurveyQuestion>> GetSurveyQuestionsAsync();

        void SaveUserResponse(UserResponse userResponse);
    }
}

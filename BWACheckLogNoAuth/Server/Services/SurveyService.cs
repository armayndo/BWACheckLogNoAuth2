using BWACheckLogNoAuth.Server.Data.Repositories;
using BWACheckLogNoAuth.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISurveyRepository _surveyRepository;

        public SurveyService(IUnitOfWork unitOfWork, ISurveyRepository surveyRepository)
        {
            _unitOfWork = unitOfWork;
            _surveyRepository = surveyRepository;
        }

        public async Task<IEnumerable<SurveyQuestion>> GetSurveyQuestionsAsync()
        {
            return await _surveyRepository.GetSurveyQuestionsAsync();
        }

        public Task<UserResponse> SaveUserResponseAsync(UserResponse userResponse)
        {
            throw new NotImplementedException();
        }
    }
}

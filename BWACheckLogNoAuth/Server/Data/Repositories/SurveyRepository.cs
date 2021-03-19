using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public class SurveyRepository : BaseRepository, ISurveyRepository
    {
        public SurveyRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SurveyQuestion>> GetSurveyQuestionsAsync()
        {
            return await _context.SurveyQuestions
                .Include(s => s.SurveyAnswers)
                .ToListAsync();
        }

        public void SaveUserResponse(UserResponse userResponse)
        {
            throw new NotImplementedException();
        }
    }
}

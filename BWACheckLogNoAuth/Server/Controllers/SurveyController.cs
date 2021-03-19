using BWACheckLogNoAuth.Server.Data.Context;
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
    public class SurveyController : Controller
    {
        private readonly ISurveyService _surveyService;
        private readonly AppDbContext _appDbContext;

        public SurveyController(ISurveyService surveyService, AppDbContext appDbContext)
        {
            _surveyService = surveyService;
            _appDbContext = appDbContext;
        }

        // GET: api/<controller>
        [HttpGet("questions")]
        public async Task<IEnumerable<SurveyQuestion>> GetQuestions()
        {
            var temp = await _surveyService.GetSurveyQuestionsAsync();
            return temp;
        }
    }
}

using BWACheckLogNoAuth.Server.Data.Context;
using BWACheckLogNoAuth.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.SeedData
{
    public class Seed
    {
        public static void SeedSurveyQuestion(AppDbContext context)
        {
            if (!context.SurveyQuestions.Any())
            {
                var seedData = System.IO.File.ReadAllText("Data/SeedData/SurveyQuestion.json");
                var surveyQuestions = JsonConvert.DeserializeObject<List<SurveyQuestion>>(seedData);
                foreach (var data in surveyQuestions)
                {
                    //data.LastTrn = DateTime.Now;
                    //data.LastUpdated = DateTime.UtcNow;
                    //data.ClientLastUpdated = data.LastUpdated;
                    context.SurveyQuestions.Add(data);
                }
                context.SaveChanges();
            }
        }

        public static void SeedSurveyAnswer(AppDbContext context)
        {
            if (!context.SurveyAnswers.Any())
            {
                var seedData = System.IO.File.ReadAllText("Data/SeedData/SurveyAnswer.json");
                var jsonData = JsonConvert.DeserializeObject<List<SurveyAnswer>>(seedData);
                foreach (var data in jsonData)
                {
                    //data.LastTrn = DateTime.Now;
                    //data.LastUpdated = DateTime.UtcNow;
                    //data.ClientLastUpdated = data.LastUpdated;
                    context.SurveyAnswers.Add(data);
                }
                context.SaveChanges();
            }
        }
    }
}

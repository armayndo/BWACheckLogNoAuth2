using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BWACheckLogNoAuth.Shared.Models
{
    public class SurveyAnswer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Answer { get; set; }
        public string AnswerType { get; set; }
        public int NextQuestion { get; set; }

        public int SurveyQuestionId { get; set; }
        public SurveyQuestion SurveyQuestion { get; set; }
    }
}

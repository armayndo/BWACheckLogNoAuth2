using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BWACheckLogNoAuth.Shared.Models
{
    public class SurveyQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Description { get; set; }

        public ICollection<SurveyAnswer> SurveyAnswers { get; set; }
    }
}

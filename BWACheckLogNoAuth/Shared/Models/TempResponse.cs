using System;
using System.Collections.Generic;
using System.Text;

namespace BWACheckLogNoAuth.Shared.Models
{
    public class TempResponse
    {
        public int QuestionNo { get; set; }
        public DateTime ResponseTime { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int NextQuestionId { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Book.Models
{
    public class TestResult
    {
        public int Porcentagem => CorrectAnswers / Total * 100;
        public int CorrectAnswers { get; set; }
        public int Total { get; set; }
    }
}

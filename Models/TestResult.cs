using System.Collections.Generic;
using System.Linq;

namespace Book.Models
{
    public class TestResult
    {
        public int Porcentagem { get; private set; }
        public int CorrectAnswers { get; set; }
        public int Total { get; set; }

        public TestResult(List<Test> items)
        {
            CorrectAnswers = items.Where(x => x.Answers.Any(y => y.IsCorrect == y.IsSelected)).Count();
            Total = items.Count();
            Porcentagem = CorrectAnswers / Total * 100;
        }
    }
}

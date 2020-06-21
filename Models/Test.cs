using System.Collections.Generic;

namespace Book.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}

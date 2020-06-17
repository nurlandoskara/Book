using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class BaseModel
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
        public string Number { get; set; }
    }
}

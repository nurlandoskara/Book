using Book.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class LessonData : BaseData<Lesson>
    {
        public override string CurrentDirectory => BasePath + "Lessons";
    }
}

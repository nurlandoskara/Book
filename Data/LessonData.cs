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

        public override List<Lesson> GetItems()
        {
            var list = new List<Lesson>();
            int i = 0;
            foreach (var file in Directory.GetFiles(CurrentDirectory, "*.rtf"))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                list.Add(new Lesson
                {
                    Title = fileName.Substring(3, fileName.Length - 3),
                    Id = ++i,
                    Path = file,
                    Number = fileName.Substring(0, 2)
                });
            }
            return list;
        }
    }
}

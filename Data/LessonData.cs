using Book.Models;
using MahApps.Metro.Controls;
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
            foreach (var file in Directory.GetFiles(CurrentDirectory, "*.rtf"))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);

                var title = fileName.Substring(fileName.IndexOf("_") + 1, fileName.Length - fileName.IndexOf("_") - 1);
                var path = file;
                var number = fileName.Substring(0, fileName.IndexOf("_"));
                var id = Convert.ToInt32(number.Substring(0,2));
                
                list.Add(new Lesson
                {
                    Title = title,
                    Path = path,
                    Number = number,
                    Id = id
                }); 
            }
            return list.OrderBy(x => x.Id).ToList();
        }
    }
}

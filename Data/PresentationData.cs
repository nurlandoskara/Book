using Book.Models;
using System.Collections.Generic;
using System.IO;

namespace Book.Data
{
    public class PresentationData : BaseData<Presentation>
    {
        public override string CurrentDirectory => BasePath + "Presentations";

        public override List<Presentation> GetItems()
        {
            var list = new List<Presentation>();
            int i = 0;
            foreach (var file in Directory.GetFiles(CurrentDirectory, "*.ppsx"))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                list.Add(new Presentation
                {
                    Title = fileName.Substring(3, fileName.Length - 3),
                    Id = ++i,
                    Path = file,
                    Number = i.ToString()
                });
            }
            return list;
        }
    }
}

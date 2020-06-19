using Book.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class VideoData : BaseData<Video>
    {
        public override string CurrentDirectory => BasePath + "Videos";

        public override List<Video> GetItems()
        {
            var list = new List<Video>();
            int i = 0;
            foreach (var file in Directory.GetFiles(CurrentDirectory))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                list.Add(new Video
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

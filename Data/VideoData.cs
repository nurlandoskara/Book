using Book.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Book.Data
{
    public class VideoData : BaseData<Video>
    {
        public override string CurrentDirectory => BasePath + "Videos";

        public override List<Video> GetItems()
        {
            var list = new List<Video>();
            foreach (var file in Directory.GetFiles(CurrentDirectory))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                list.Add(new Video
                {
                    Title = fileName.Substring(3, fileName.Length - 3),
                    Id = Convert.ToInt32(fileName.Substring(0, 2)),
                    Path = file,
                    Number = fileName.Substring(0, 2)
                });
            }
            return list;
        }
    }
}

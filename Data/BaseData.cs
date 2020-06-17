using Book.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Book.Data
{
    public class BaseData<T> where T : BaseModel, new()
    {
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public virtual string CurrentDirectory => BasePath;

        public virtual List<T> GetItems()
        {
            var list = new List<T>();
            int i = 0;
            foreach (var file in Directory.GetFiles(CurrentDirectory, "*.docx"))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                list.Add(new T
                {
                    Title = fileName.Substring(3, fileName.Length - 3),
                    Id = ++i,
                    Path = file,
                    Number = fileName.Substring(0, 2)
            });
            }
            return list;
        }
        public virtual FlowDocument GetDocument(string path)
        {
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var flowDocumentConverter = new DocxToFlowDocumentConverter(stream);
                flowDocumentConverter.Read();
                return flowDocumentConverter.Document;
            }
        }
    }
}

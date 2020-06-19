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
    public abstract class BaseData<T> where T : BaseModel, new()
    {
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public virtual string CurrentDirectory => BasePath;

        public abstract List<T> GetItems();
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

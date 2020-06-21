using Book.Models;
using Book.ViewModels;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Book.Views
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Lessons : ContentControl, IView
    {
        public Lessons()
        {
            InitializeComponent();
            var vm = new LessonViewModel();
            vm.View = this;
            DataContext = vm;
        }

        public void Finish(TestResult result)
        {
            throw new System.NotImplementedException();
        }

        public void ItemLoad(string path)
        {
            TextRange doc = new TextRange(DocumentReader.Document.ContentStart, DocumentReader.Document.ContentEnd);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                doc.Load(fs, DataFormats.Rtf);
            }
        }

        public void ItemUnload()
        {
            DocumentReader.Document = null;
        }
    }
}

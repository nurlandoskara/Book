using Book.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Book
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
            vm.View = this as IView;
            DataContext = vm;
        }

        public void RTFDocumentLoad(string path)
        {
            TextRange doc = new TextRange(DocumentReader.Document.ContentStart, DocumentReader.Document.ContentEnd);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                doc.Load(fs, DataFormats.Rtf);
            }
        }
    }
}

using Book.Data;
using Book.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Documents;

namespace Book.ViewModels
{
    public class LessonViewModel : BaseViewModel<Lesson, LessonData>
    {
        
        private FlowDocument _document { get; set; }
        public FlowDocument Document
        {
            get { return _document; }
            set
            {
                _document = value;
                OnPropertyChanged("Document");
            }
        }

        public LessonViewModel()
        {
            Data = new LessonData();
            Items = Data.GetItems();
        }

        public override void LoadDocument()
        {
            Document = Data.GetDocument(SelectedItem.Path);
        }
    }
}

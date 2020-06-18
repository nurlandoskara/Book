using Book.Classes;
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

        public string Title { get; set; }
        public string Number { get; set; }

        public LessonViewModel()
        {
            Data = new LessonData();
            Items = Data.GetItems();
            Consumo = new List<Consumo>();
        }

        public override void LoadDocument()
        {
            Visible = true;
            Consumo.Add(new Consumo(SelectedItem.Title, 100));
            Document = Data.GetDocument(SelectedItem.Path);
            Title = SelectedItem.Title;
            Number = SelectedItem.Number;
        }


    }

}

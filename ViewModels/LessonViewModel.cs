using Book.Classes;
using Book.Data;
using Book.Models;
using System.Collections.Generic;
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
            Consumo = new List<Consumo>();
        }

        public override void LoadDocument()
        {
            Title = SelectedItem.Title;
            Number = SelectedItem.Number;
            View.ItemLoad(SelectedItem.Path);
        }


    }

}

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
        private string title;
        private string _title;
        private string _number;

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

        public string Title { 
            get => _title; 
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged("Number");
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
            Consumo.Add(new Consumo(SelectedItem.Title, 100));
            Document = Data.GetDocument(SelectedItem.Path);
            Title = SelectedItem.Title;
            Number = SelectedItem.Number;
        }


    }

}

using Book.Data;
using Book.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Book.ViewModels
{
    public class TestViewModel: INotifyPropertyChanged
    {
        public bool ResultVisible { get {
                return _resultVisible;
            } set {
                _resultVisible = value;
                OnPropertyChanged("ResultVisible");
            } }
        public List<Test> Items { get; set; }
        public List<TestResult> Consumo { get; private set; }

        public TestViewModel()
        {
            Items = TestData.GetItems();
        }
        public void Finish()
        {
            ResultVisible = true;
            var result = new TestResult(Items);
            Consumo = new List<TestResult>();
            Consumo.Add(result);
        }

        private RelayCommand _finishCommand;
        private bool _resultVisible;

        public RelayCommand FinishCommand => _finishCommand ??
            (
                _finishCommand = new RelayCommand(obj => { 
                    Finish(); 
                })               
            );


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

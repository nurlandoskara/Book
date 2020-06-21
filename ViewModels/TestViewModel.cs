using Book.Data;
using Book.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Automation.Peers;

namespace Book.ViewModels
{
    public class TestViewModel: INotifyPropertyChanged
    {
        public bool ResultVisible
        {
            get
            {
                return _resultVisible;
            }
            set
            {
                _resultVisible = value;
                OnPropertyChanged("ResultVisible");
            }
        }

        public int CorrectAnswers
        {
            get
            {
                return _correctAnswers;
            }
            set
            {
                _correctAnswers = value;
                OnPropertyChanged("CorrectAnswers");
            }
        }
        public List<Test> Items { get; set; }
        public List<TestResult> Consumo { get; private set; }

        public IView View { get; set; }

        public TestViewModel()
        {
            Items = TestData.GetItems();
            Consumo = new List<TestResult>();
        }
        public void Finish()
        {
            ResultVisible = true;
            var result = new TestResult
            {
                CorrectAnswers = Items.Count(x => x.Answers.Any(y => y.IsCorrect == true && y.IsSelected == true)),
                Total = Items.Count()
            };

            CorrectAnswers = Items.Count(x => x.Answers.Any(y => y.IsCorrect == true && y.IsSelected == true));
            ResultVisible = true;
            Consumo.Add(result);
        }

        private RelayCommand _finishCommand;
        private bool _resultVisible;
        private int _correctAnswers;

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

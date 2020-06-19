using Book.Classes;
using Book.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Book.ViewModels
{
    public abstract class BaseViewModel<T, E> : INotifyPropertyChanged where T : BaseModel
    {
        public E Data;
        private RelayCommand _selectedCommand;
        public RelayCommand SelectedCommand => _selectedCommand ??
            (
                _selectedCommand = new RelayCommand(obj =>
                {
                    ItemSelected(obj);
                })
            );

        public List<T> Items { get; set; }
        public T SelectedItem { get; set; }
        public virtual void ItemSelected(object obj)
        {
            int id = (int)obj;
            SelectedItem = Items.FirstOrDefault(x => x.Id == id);
            ListVisible = false;
            LoadDocument();
        }

        public abstract void LoadDocument();


        public IView View { get; set; }
        public List<Consumo> Consumo { get; set; }

        private bool _visible = false;
        public bool Visible
        {
            get
            {
                return _visible;
            }

            set
            {
                _visible = value;
                OnPropertyChanged("Visible");
            }
        }

        private bool _listVisible = false;
        private string _title;
        private string _number;

        public bool ListVisible
        {
            get
            {
                return _listVisible;
            }

            set
            {
                _listVisible = value;
                Visible = value != true;
                OnPropertyChanged("ListVisible");
            }
        }


        public string Title
        {
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

        public BaseViewModel()
        {
            ListVisible = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

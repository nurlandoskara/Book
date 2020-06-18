using Book.Classes;
using Book.Data;
using Book.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            LoadDocument();
        }

        public abstract void LoadDocument();


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


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

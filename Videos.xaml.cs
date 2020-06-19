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
    public partial class Videos : ContentControl, IView
    {
        public Videos()
        {
            InitializeComponent();
            var vm = new VideoViewModel();
            vm.View = this;
            DataContext = vm;
        }

        public void ItemLoad(string path)
        {
            VideoPlayer.Source = new Uri(path);
            VideoPlayer.Play();
        }

        public void ItemUnload()
        {
            VideoPlayer.Stop();
            VideoPlayer.Source = null;
        }
    }
}

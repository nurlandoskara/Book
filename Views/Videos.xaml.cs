using Book.Models;
using Book.ViewModels;
using System;
using System.Windows.Controls;

namespace Book.Views
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

        public void Finish(TestResult result)
        {
            throw new NotImplementedException();
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

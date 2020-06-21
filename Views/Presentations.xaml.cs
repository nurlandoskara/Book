using Book.ViewModels;
using System;
using System.Diagnostics;
using System.Windows.Controls;

namespace Book.Views
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Presentations : ContentControl, IView
    {
        public Presentations()
        {
            InitializeComponent();
            var vm = new PresentationViewModel();
            vm.View = this;
            DataContext = vm;
        }

        public void ItemLoad(string path)
        {
            Process.Start(path);
        }

        public void ItemUnload()
        {
        }
    }
}

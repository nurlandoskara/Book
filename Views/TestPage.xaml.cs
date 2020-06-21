using Book.Models;
using Book.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;

namespace Book.Views
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class TestPage : ContentControl, IView
    {
        public TestPage()
        {
            InitializeComponent();
            var vm = new TestViewModel();
            vm.View = this;
            DataContext = vm;
        }

        public void Finish(TestResult result)
        {
        }

        public void ItemLoad(string path)
        {
            throw new System.NotImplementedException();
        }

        public void ItemUnload()
        {
            throw new System.NotImplementedException();
        }
    }
}

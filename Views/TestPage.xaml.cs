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
    public partial class TestPage : ContentControl
    {
        public TestPage()
        {
            InitializeComponent();
            DataContext = new TestViewModel();
        }

        public void Finish()
        {

        }


        

    }
}

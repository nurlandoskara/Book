using Book.Views;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Input;

namespace Book
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var window = new StartPage();
            transitioningControl.Content = window;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Lessons();
            transitioningControl.Content = window;
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new Videos();
            transitioningControl.Content = window;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var window = new StartPage();
            transitioningControl.Content = window;
        }
    }


    
}

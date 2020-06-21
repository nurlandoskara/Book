using Book.Models;
using Book.Views;
using MahApps.Metro.Controls;
using System.IO;
using System.Windows;
using System.Windows.Documents;
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
            DocumentReader.Visibility = Visibility.Hidden;
            var window = new StartPage();
            transitioningControl.Content = window;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DocumentReader.Visibility = Visibility.Hidden;
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
            DocumentReader.Visibility = Visibility.Hidden;
            var window = new Videos();
            transitioningControl.Content = window;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DocumentReader.Visibility = Visibility.Hidden;
            var window = new StartPage();
            transitioningControl.Content = window;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DocumentReader.Visibility = Visibility.Hidden;
            var window = new Presentations();
            transitioningControl.Content = window;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DocumentReader.Visibility = Visibility.Visible;
            var path = "00.rtf";
            TextRange doc = new TextRange(DocumentReader.Document.ContentStart, DocumentReader.Document.ContentEnd);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                doc.Load(fs, DataFormats.Rtf);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DocumentReader.Visibility = Visibility.Hidden;
            var window = new TestPage();
            transitioningControl.Content = window;
        }
    }


    
}

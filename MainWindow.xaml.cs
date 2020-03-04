using System.Windows;

namespace Электронные_деньги
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            демонстрация демонстрация = new демонстрация();
            демонстрация.Show();
            WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Реализация реализация = new Реализация();
            реализация.Show();
            WindowState = WindowState.Minimized;
        }
    }
}

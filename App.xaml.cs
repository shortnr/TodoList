using System.Configuration;
using System.Data;
using System.Windows;
using TodoList.Src.Views;
using TodoList.Src.ViewModels;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainViewModel mainViewModel = new();
            MainWindow mainWindow = new MainWindow { DataContext = mainViewModel };
            mainWindow.Show();
        }
    }
}

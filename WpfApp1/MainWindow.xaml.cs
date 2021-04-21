
using System.Windows;
using PingPongGameClassLibrary;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game MainGame = new Game();
             this.Close();
            MainGame.Run();
        }
    }
}

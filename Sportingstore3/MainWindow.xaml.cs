using Sportingstore.view;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;

namespace Sportingstore
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

    public void enterButton_Click(object sender, RoutedEventArgs e)
    {
        string login = loginField.Text;
        string passphrase = passwordField.Password;

        using (var dbContext = new MyDbContext())
        {
            var user = dbContext.Users.FirstOrDefault(
                u =>
                u.Login == login &&
                u.Passphrase == passphrase);
                
            if (user != null)
            {
                    showcase mainWindow = new showcase();
                    mainWindow.Show();

                    // Закрытие текущего окна
                    Window currentWindow = Application.Current.MainWindow;
                    currentWindow.Close();
                }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }
    }
    }
}

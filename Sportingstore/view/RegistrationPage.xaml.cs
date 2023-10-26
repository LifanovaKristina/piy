using Sportingstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sportingstore.view
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Window
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void backToLoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            Window mainWindow = Application.Current.MainWindow;
            mainWindow.Close();
            loginWindow.Show();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginField.Text;
            string password = passwordField.Password;
            string retryPassword = retryPasswordField.Password;
            string email = emailField.Text;

            if (password.Equals(retryPassword))
            {
                var newUser = new User
                {
                    Login = login,
                    Passphrase = password,
                    Email = email
                };

                using (var dbContext = new MyDbContext())
                {
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Пользователь успешно зарегистрирован!");
                loginField.Text = string.Empty;
                passwordField.Password = string.Empty;
                retryPasswordField.Password = string.Empty;
                emailField.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Введенные пароли не совпадают");
            }



        }

    }
}
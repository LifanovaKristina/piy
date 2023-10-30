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
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Window
    {
        public CatalogPage()
        {
            InitializeComponent();
        }

        private void FirstButton_OnClick(object sender, RoutedEventArgs e)
        {
            showcase detailPage = new showcase();
            Window mainWindow = new CatalogPage();
            mainWindow.Close();
            detailPage.Show();
        }
    }
}

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

namespace ССЕИЯ1.Viev.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void LoginTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var xv = Helpers.BD.user24Entities.Authorizations.FirstOrDefault(i => i.Login == LoginTB.Text && i.Password == PassTB.Password);
            if (xv != null)
            {
                MessageBox.Show("Успех");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void ForgerBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Viev.Windows.Registration registration = new Registration();
            registration.Show();
            Close();

        }
    }
}

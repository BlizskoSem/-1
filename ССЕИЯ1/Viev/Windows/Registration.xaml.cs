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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
                log += "Введите логин\n";

            if (string.IsNullOrWhiteSpace(PassTB.Password))
                log += "Введите пароль\n";

            if (string.IsNullOrWhiteSpace(EmTb.Text))
                log += "Повторите пароль\n";



            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }


            Models.Authorizations profile = new Models.Authorizations()
            {
                Id = 23,
                Name = "Sem",
                Login = LoginTB.Text,
                Phone = 123,
                Password = PassTB.Password,

            };
            Helpers.BD.user24Entities.Authorizations.Add(profile);
            Helpers.BD.user24Entities.SaveChanges();
            MessageBox.Show("Учетная запись создана");


            MessageBox.Show("Успех");
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();




        }





        private void EmTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

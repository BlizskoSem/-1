using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для LichoePosechenie.xaml
    /// </summary>
    public partial class LichoePosechenie : Window
    {
        public LichoePosechenie()
        {
            InitializeComponent();
            CoMbo_podrazdel.SelectedItem = "ID";
            CoMbo_podrazdel.DisplayMemberPath = "DivisionName";
            CoMbo_podrazdel.ItemsSource = Helpers.BD.user24Entities.Divisions.ToList();


            TxtOrgan.SelectedItem = "ID";
            TxtOrgan.DisplayMemberPath = "Name";
            TxtOrgan.ItemsSource = Helpers.BD.user24Entities.Organization.ToList();

            COMBO.SelectedItem = "ID";
            COMBO.DisplayMemberPath = "Visiting1";
            COMBO.ItemsSource = Helpers.BD.user24Entities.Visiting.ToList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CoMbo_podrazdel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtFami.Clear();
            TxtName.Clear();
            TxtOtchestvo.Clear();
            TxtPhone.Clear();
            TxtMail.Clear();
            TxtSeria.Clear();
            TxtNumber.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(TxtFami.Text))
                log += "Введите фамилию\n";

            if (string.IsNullOrWhiteSpace(TxtName.Text))
                log += "Введите имя\n";

            if (string.IsNullOrWhiteSpace(TxtOtchestvo.Text))
                log += "Повторите отчество\n";
            if (string.IsNullOrWhiteSpace(TxtPhone.Text))
                log += "Введите телефон\n";
            if (string.IsNullOrWhiteSpace(TxtMail.Text))
                log += "Введите почту\n";
            if (string.IsNullOrWhiteSpace(TxtOrgan.Text))
                log += "Выберите организациию\n";
            if (string.IsNullOrWhiteSpace(TxtSeria.Text))
                log += "Введите серию\n";
            if (string.IsNullOrWhiteSpace(TxtNumber.Text))
                log += "Введите номер\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }


            Models.InfoClient profile = new Models.InfoClient()
            {
                Surname = TxtFami.Text,
                Name = TxtName.Text,
                MiddleName = TxtOtchestvo.Text,
                Phone = TxtPhone.Text,
                Email = TxtMail.Text,
                Organization = TxtOrgan.SelectedItem as Models.Organization,
                Comment = TxtPrim.Text,
                SeriyaPasport = int.Parse(TxtSeria.Text),
                numberPasport = int.Parse(TxtNumber.Text),
                DataBirthday = (DateTime)DateBirth.SelectedDate,
                Photo = qwe

            };
            Helpers.BD.user24Entities.InfoClient.Add(profile);
            Helpers.BD.user24Entities.SaveChanges();
            MessageBox.Show("Новый клиент успешно добавлен");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            var qw = openFileDialog.FileName;
            qwe = File.ReadAllBytes(qw);
        }

        public byte[] qwe;

        private void TxtOrgan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}


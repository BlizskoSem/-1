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
    /// Логика взаимодействия для GruppovoePosechenie.xaml
    /// </summary>
    public partial class GruppovoePosechenie : Window
    {
        public GruppovoePosechenie()
        {
            InitializeComponent();
            PodrazdCmb.SelectedItem = "ID";
            PodrazdCmb.DisplayMemberPath = "DivisionName";
            PodrazdCmb.ItemsSource = Helpers.BD.user24Entities.Divisions.ToList();


            txtOrganizaci.SelectedItem = "ID";
            txtOrganizaci.DisplayMemberPath = "Name";
            txtOrganizaci.ItemsSource = Helpers.BD.user24Entities.Organization.ToList();
        }

        private void PodrazdCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(TxtFamiliya.Text))
                log += "Введите фамилию\n";

            if (string.IsNullOrWhiteSpace(TXTIMYA.Text))
                log += "Введите имя\n";

            if (string.IsNullOrWhiteSpace(TxtOtcestvo.Text))
                log += "Повторите отчество\n";
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                log += "Введите телефон\n";
            if (string.IsNullOrWhiteSpace(TxtPochta.Text))
                log += "Введите почту\n";
            if (string.IsNullOrWhiteSpace(txtOrganizaci.Text))
                log += "Выберите организациию\n";
            if (string.IsNullOrWhiteSpace(TxtSeria.Text))
                log += "Введите серию\n";
            if (string.IsNullOrWhiteSpace(TxtNomer.Text))
                log += "Введите номер\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }


            Models.InfoClient profile = new Models.InfoClient()
            {
                Surname = TxtFamiliya.Text,
                Name = TXTIMYA.Text,
                MiddleName = TxtOtcestvo.Text,
                Phone = txtPhone.Text,
                Email = TxtPochta.Text,
                Organization = txtOrganizaci.SelectedItem as Models.Organization,
                Comment = TxtPrimechanie.Text,
                SeriyaPasport = int.Parse(TxtSeria.Text),
                numberPasport = int.Parse(TxtNomer.Text),
                DataBirthday = (DateTime)DatePickerBerth.SelectedDate


            };
            Helpers.BD.user24Entities.InfoClient.Add(profile);
            Helpers.BD.user24Entities.SaveChanges();
            MessageBox.Show("Новый клиент успешно добавлен");
        }
    }
}

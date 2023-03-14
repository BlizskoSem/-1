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
    /// Логика взаимодействия для LichoePosechenie.xaml
    /// </summary>
    public partial class LichoePosechenie : Window
    {
        public LichoePosechenie()
        {
            InitializeComponent();

            COMBO.SelectedValuePath = "ID";
            CoMbo_podrazdel.DisplayMemberPath = "Name";
            CoMbo_podrazdel.ItemsSource = Helpers.BD.user24Entities.Authorizations.ToList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

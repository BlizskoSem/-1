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
            PodrazdCmb.DisplayMemberPath = "Name";
            PodrazdCmb.ItemsSource = Helpers.BD.user24Entities.Organization.ToList();
        }
    }
}

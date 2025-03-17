using Krylova_EYP.Class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krylova_EYP.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void TeacherBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new AuthorizationPage());
        }

        private void StudentBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new StudentRegistrationPage());
        }
    }
}

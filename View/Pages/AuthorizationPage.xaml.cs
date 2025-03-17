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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            string password = "123";

            if (PasswordPb.Password == null)
            {
                MessageBox.Show("Введите пароль!");
            }
            if (PasswordPb.Password != password)
            {
                MessageBox.Show("Вы ввели пароль неверно, попробуйте еще раз!");
            }
            else
            {
                MessageBox.Show("Вы успешно вошли!");

                ClassFrame.MainFrame.Navigate(new MenuPage());
            }
        }
    }
}

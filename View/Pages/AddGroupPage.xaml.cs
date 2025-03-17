using Krylova_EYP.Class;
using Krylova_EYP.Model;
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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameGroupTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Group newGroup = new Group()
                {
                    Name = NameGroupTb.Text
                };

                App.context.Group.Add(newGroup);
                App.context.SaveChanges();
                MessageBox.Show("Группа добавлена");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MenuPage());
        }
    }
}

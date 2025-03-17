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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(FullNameStudentTb.Text) && string.IsNullOrEmpty(GroupCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Student newStudent = new Student()
                {
                    Name = FullNameStudentTb.Text,
                    Group = GroupCmb.SelectedItem as Group
                };

                App.context.Student.Add(newStudent);
                App.context.SaveChanges();
                MessageBox.Show("Студент добавлен");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MenuPage());
        }
    }
}

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
    /// Логика взаимодействия для StudentRegistrationPage.xaml
    /// </summary>
    public partial class StudentRegistrationPage : Page
    {
        public StudentRegistrationPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "Id";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            TestCmb.SelectedValuePath = "Id";
            TestCmb.DisplayMemberPath = "Name";
            TestCmb.ItemsSource = App.context.Test.ToList();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TestCmb.Text) && string.IsNullOrEmpty(StudentCmb.Text)&& string.IsNullOrEmpty(GroupCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if(TestCmb.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test1Page());
            }
            else if (TestCmb.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test2Page());
            }
            else if (TestCmb.Text == "Формы и системы оплаты труда")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test3Page());
            }
            else if (TestCmb.Text == "Результаты коммерческой деятельности")
            {
                ClassFrame.MainFrame.Navigate(new Pages.Test4Page());
            }

            ClassVariable.classman = Convert.ToInt32(StudentCmb.SelectedValue);

            
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedGroup = Convert.ToInt32(GroupCmb.SelectedValue);
            StudentCmb.ItemsSource = App.context.Student.Where(s => s.IdGroup == selectedGroup).ToList();
        }
    }
}

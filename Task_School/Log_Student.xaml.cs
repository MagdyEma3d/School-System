using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Task_School
{
    /// <summary>
    /// Interaction logic for Log_Student.xaml
    /// </summary>
    public partial class Log_Student : Page
    {
        SQL_For_Today_SessionEntities2 pop=new SQL_For_Today_SessionEntities2();
        public Log_Student()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var emp = pop.Student_login.FirstOrDefault(x => x.ID == text_student1.Text&& x.Password==text_student2.Text);
            if (emp != null)
            {
                MessageBox.Show("signin successfully");
                student_page student_Page = new student_page();
                this.NavigationService.Navigate(student_Page);
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up_student sign_Up_Student = new sign_up_student();
            this.NavigationService.Navigate(sign_Up_Student);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forgitten_password forgitten_Password= new forgitten_password();
            this.NavigationService.Navigate(forgitten_Password);
        }
    }
}

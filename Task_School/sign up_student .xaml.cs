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
    /// Interaction logic for sign_up_student.xaml
    /// </summary>
    public partial class sign_up_student : Page
    {
        SQL_For_Today_SessionEntities2 pop=new SQL_For_Today_SessionEntities2();
        public sign_up_student()
        {
            InitializeComponent();
        }

        private void BtnSignup_Click(object sender, RoutedEventArgs e)
        {
            var em = pop.Student_login.FirstOrDefault(x => x.ID == textbox1.Text);

            if (em == null)
            {
                Student_login emp = new Student_login();
                emp.ID = textbox1.Text;

                emp.Password = textbox2.Text;
                pop.Student_login.Add(emp);
                pop.SaveChanges();
                this.NavigationService.GoBack();
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("user name is already exist");
            }
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

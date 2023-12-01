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
    /// Interaction logic for student_page.xaml
    /// </summary>
    public partial class student_page : Page
    {
        SQL_For_Today_SessionEntities2 pop = new SQL_For_Today_SessionEntities2();
        public student_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = pop.students.Where(x => x.Name.Contains(text_search.Text)).ToList();
        }
    }
}


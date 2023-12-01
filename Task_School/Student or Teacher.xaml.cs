using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Task_School
{
    /// <summary>
    /// Interaction logic for Student_or_Teacher.xaml
    /// </summary>
    public partial class Student_or_Teacher : Page
    {
        public Student_or_Teacher()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected item from the combo box
            if (combox.SelectedItem != null)
            {
                string selectedValue = ((ComboBoxItem)combox.SelectedItem).Content.ToString();
                MessageBox.Show($"Selected Value: {selectedValue}");

                if (selectedValue == "Student")
                {
                    Log_Student log_Student = new Log_Student();
                    this.NavigationService.Navigate(log_Student);
                }
                else
                {
                    Log_Teacher log_Teacher = new Log_Teacher();
                    this.NavigationService.Navigate(log_Teacher);
                }

            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }
    }
}

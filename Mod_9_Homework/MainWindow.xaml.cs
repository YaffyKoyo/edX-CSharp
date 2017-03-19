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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            index = -1;
            Student student1 = new Student();
            student1.firstName = txtFirstName.Text;
            student1.lastName = txtLastName.Text;
            student1.City = txtCity.Text;

            students.Add(student1);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();           
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (index < students.Count()-1)
            {
                btnPrevious.IsEnabled = true;
                index++;

                txtCity.Text = students[index].City;
                txtFirstName.Text = students[index].firstName;
                txtLastName.Text = students[index].lastName;
            }
            if(index==students.Count-1) {
                btnNext.IsEnabled = false;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                btnNext.IsEnabled = true;
                index--;

                txtCity.Text = students[index].City;
                txtFirstName.Text = students[index].firstName;
                txtLastName.Text = students[index].lastName;
            }
            if (index == 0)
            {
                btnPrevious.IsEnabled = false;
            }
        }
    }
}

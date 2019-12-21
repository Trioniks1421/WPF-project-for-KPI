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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Admin_home_page.xaml
    /// </summary>
    public partial class Admin_home_page : Window
    {
        public Admin_home_page()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Add_group_Click(object sender, RoutedEventArgs e)
        {
            Add_group add_Group = new Add_group();
            add_Group.Show();
            this.Close();


        }

        private void Add_file_Click(object sender, RoutedEventArgs e)
        {
            Add_file add_file = new Add_file();
            add_file.Show();
            this.Close();
        }

        private void My_profile_Click(object sender, RoutedEventArgs e)
        {
            My_profile my_profile = new My_profile();
            my_profile.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App_info app_Info = new App_info();
            app_Info.Show();
        }
    }
}

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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Register_button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
            
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
           bool pool = false;
            if (pool==true )
                {
                User_home_page user_Home_Page = new User_home_page();
                user_Home_Page.Show();
                this.Close();
            }
            else
            {
                Admin_home_page admin_Home_Page = new Admin_home_page();
                admin_Home_Page.Show();
                this.Close();
            }

            
        }
       
    }
}

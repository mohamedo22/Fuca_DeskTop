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

namespace fuca
{
    /// <summary>
    /// Interaction logic for first_page.xaml
    /// </summary>
    public partial class first_page : Page
    {
        fucaEntities entities = new fucaEntities();
        public first_page()
        {
            InitializeComponent();
        }

        private void Log_inn(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem == null)
            {
                MessageBox.Show("No selected item");
            }
            else
            {
                switch (list.Text)
                {

                    case "User":
                        foreach (var s in entities.usersses)
                        {
                            if (s.user_namee == username.Text && s.passwordd == int.Parse(password_txt.Text))
                            {
                                user_page user_Page = new user_page();
                                this.NavigationService.Navigate(user_Page);


                            }

                        }
                        break;
                    case "Admin":
                        foreach (var s in entities.admins)
                        {

                            if (s.user_namee == username.Text && s.passwordd == int.Parse(password_txt.Text))
                            {
                                Admin_page admin_page = new Admin_page();
                                this.NavigationService.Navigate(admin_page);
                            }
                        }
                        break;
                    default:
                        MessageBox.Show(list.SelectedItem.ToString());
                        break;
                }
            }
        }
    
           
        

        private void sign_up(object sender, RoutedEventArgs e)
        {
            signup signup= new signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetpass resetpass = new resetpass();
            this.NavigationService.Navigate(resetpass);
        }
    }
}

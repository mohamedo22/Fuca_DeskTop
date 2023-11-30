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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        fucaEntities fucaEntities = new fucaEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void save(object sender, RoutedEventArgs e)
        {
            userss userss = new userss();
            userss.user_namee = name.Text;
            if(int.Parse(pass.Text) == int.Parse(scpass.Text))
            {
                userss.passwordd = int.Parse(scpass.Text);
            }
            fucaEntities.usersses.Add(userss);
            fucaEntities.SaveChanges();
            MessageBox.Show("Create success!");
        }
    }
}
    
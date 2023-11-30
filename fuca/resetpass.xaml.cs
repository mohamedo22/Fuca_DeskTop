using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for resetpass.xaml
    /// </summary>
    public partial class resetpass : Page
    {
        fucaEntities fucaEntities = new fucaEntities();
        public resetpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userss userss = new userss();
            try
            {
                userss = fucaEntities.usersses.First(x => x.user_namee == user_name.Text);
                if (int.Parse(pass.Text) == int.Parse(scpass.Text))
                {
                    userss.passwordd = int.Parse(scpass.Text);
                }
                MessageBox.Show("Reset success");
                fucaEntities.usersses.AddOrUpdate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

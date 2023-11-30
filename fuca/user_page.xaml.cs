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
    /// Interaction logic for user_page.xaml
    /// </summary>
    public partial class user_page : Page
    {
        fucaEntities fucaEntities = new fucaEntities();
        public user_page()
        {
            InitializeComponent();
        }

        private void save(object sender, RoutedEventArgs e)
        {
            user_table user_Table = new user_table();
            user_Table.user_namee = name.Text;
            if(male.IsChecked== true) 
            {
                user_Table.gender = "Male";
            }
            if (female.IsChecked == true)
            {
                user_Table.gender = "female";
            }
            user_Table.age = int.Parse(age.Text);
            user_Table.addresss = address.Text;
            user_Table.department = comp_box.Text;
            fucaEntities.user_table.Add(user_Table);
            fucaEntities.SaveChanges();
        }
    }
}

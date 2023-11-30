using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
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
    /// Interaction logic for Admin_page.xaml
    /// </summary>
    public partial class Admin_page : Page
    {
        fucaEntities fucaEntities = new fucaEntities();
        List<user_table> usersses= new List<user_table>();
        public Admin_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (list.Text)
            {
                case "User name":
                    if(usersses != null)
                    {
                        usersses.Clear();
                    }
                    foreach (var s in fucaEntities.user_table)
                    {
                        if (s.user_namee == search_txt.Text)
                        {
                            usersses.Add(s);
                        }

                    }
                    dg.ItemsSource = usersses;
                    break;
                case "gender":
                    if (usersses != null)
                    {
                        usersses.Clear();
                    }
                    foreach (var s in fucaEntities.user_table)
                    {
                        if (s.gender == search_txt.Text)
                        {
                            usersses.Add(s);
                        }

                    }
                    dg.ItemsSource = usersses;
                    break;
                case "age":
                    if (usersses != null)
                    {
                        usersses.Clear();
                    }
                    foreach (var s in fucaEntities.user_table)
                    {
                        if (s.age == int.Parse(search_txt.Text))
                        {
                            usersses.Add(s);
                        }

                    }
                    dg.ItemsSource = usersses;
                    break;
                case "address":
                    if (usersses != null)
                    {
                        usersses.Clear();
                    }
                    foreach (var s in fucaEntities.user_table)
                    {
                        if (s.addresss == search_txt.Text)
                        {
                            usersses.Add(s);
                        }

                    }
                    dg.ItemsSource = usersses;
                    break;
                case "deparment":
                    if (usersses != null)
                    {
                        usersses.Clear();
                    }
                    foreach (var s in fucaEntities.user_table)
                    {
                        if (s.department == search_txt.Text)
                        {
                            usersses.Add(s);
                        }

                    }
                    dg.ItemsSource = usersses;
                    break;
                default: MessageBox.Show(list.Text); break;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user_table user_Table = new user_table();
            try
            {
                int idd = int.Parse(id.Text);
                user_Table = fucaEntities.user_table.First(x => x.id == idd);
                user_Table.department = dep.Text;
                fucaEntities.user_table.AddOrUpdate();
                MessageBox.Show("Update success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            user_table user_Table = new user_table();
            try
            {
                int idd = int.Parse(id.Text);
                user_Table = fucaEntities.user_table.Remove(fucaEntities.user_table.First(x => x.id == idd));
                fucaEntities.SaveChanges();
                MessageBox.Show("Delete success!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = usersses; 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = "";
        }
    }
}

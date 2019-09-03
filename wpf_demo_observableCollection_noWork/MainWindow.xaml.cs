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

namespace wpf_demo_observableCollection_noWork
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class ChangeNotificationSample : Window
    {
        private List<User> users = new List<User>();

        public ChangeNotificationSample()
        {
            InitializeComponent();

            users.Add(new User() { Name = "John Doe" });
            users.Add(new User() { Name = "Jane Doe" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New user" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Random Name";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}

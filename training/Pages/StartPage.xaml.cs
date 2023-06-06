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

namespace training.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        private Classes.PagesNavigate navigate = new Classes.PagesNavigate();
        public StartPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Database.BookClubEntities connection = new Database.BookClubEntities();
            if (connection.User.Where(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text).Count() == 1)
            {
                NavigationService.Navigate(navigate.IsMainPageExist());
            }
            else MessageBox.Show("Некорректно введены данные! \nПроверьте правильно ли введены логин и пароль.");
        }

        private void GuestEntry(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(navigate.IsMainPageExist());
        }
    }
}

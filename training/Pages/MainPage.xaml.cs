using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static ObservableCollection<Database.Product> products;
        public static ObservableCollection<Database.Product> productsInCart = new ObservableCollection<Database.Product>();
        public static Database.BookClubEntities connection = new Database.BookClubEntities();
        public static Database.Product selectedProduct;
        public MainPage()
        {
            InitializeComponent();

            products = new ObservableCollection<Database.Product>(connection.Product.ToList());
            ProductList.ItemsSource = products;
            DataContext = this;
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            string product = selectedProduct.Article;
            productsInCart.Add(connection.Product.Where(x => x.Article == product).FirstOrDefault());
            if (productsInCart.Count > 0)
            { Cart.Visibility = Visibility.Visible; }
        }
        private void GoToCart(object sender, RoutedEventArgs e)
        {
            Classes.PagesNavigate pagesNavigate = new Classes.PagesNavigate();
            Window CartWindow=pagesNavigate.IsCartWindowExist(productsInCart);
            
            CartWindow.ShowDialog();

        }

        private void ProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedProduct = ProductList.SelectedItem as Database.Product;
        }
    }
}

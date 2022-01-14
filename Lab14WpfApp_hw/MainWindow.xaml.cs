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

namespace Lab14WpfApp_hw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            { 
                Name="Туалетная бумага",
                Price=59,
                ImagePath ="Data/1.png",
                ProductType=ProductTypes.NonFood
            });
            products.Add(new Product()
            {
                Name = "Печенье Oreo",
                Price = 149,
                ImagePath = "Data/2.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Name = "Шоколад Аленка",
                Price = 89,
                ImagePath = "Data/3.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                Name = "Жидкость для стекол -20",
                Price = 249,
                ImagePath = "Data/4.jpg",
                ProductType = ProductTypes.NonFood
            });
            lstBox.ItemsSource = products;

        }
    }
}

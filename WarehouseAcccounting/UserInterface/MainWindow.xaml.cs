using System.Windows;
using DataAccesLayer;
using BusinessLogicLayer;
using DataAccesLayer.Interfaces;
using BusinessLogicLayer.Services;
using System.Collections.ObjectModel;
using BusinessLogicLayer.ModelDTO;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CurrencyService currencyService;
        private SearchingService searchingService;
        private ObservableCollection<ProductDTO> products;
        public ObservableCollection<ProductDTO> Products
        {
            get
            {
                products = new ObservableCollection<ProductDTO>(searchingService.GetProducts());
                return products;
            }
            set
            {
                products = value;                
            }
        }


        public MainWindow()
        {
            InitializeComponent();           
            currencyService = new CurrencyService(new WarehouseUnitOfWork());
            searchingService = new SearchingService(new WarehouseUnitOfWork());
        }
       

        private void RefreshCurrency_Click(object sender, RoutedEventArgs e)
        {         
          
            currencyService.UpdateCurrencyRate("USD");
            Usd_sale.Text = currencyService.Rate.ToString();

            currencyService.UpdateCurrencyRate("EUR");
            Eur_sale.Text = currencyService.Rate.ToString();
           
        }

        private void ShowProducts_Click(object sender, RoutedEventArgs e)
        {
            productList.ItemsSource = Products;
        }

        
    }
}

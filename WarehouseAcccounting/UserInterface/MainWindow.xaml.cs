using BusinessLogicLayer;
using System.Windows;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Repositories;
using DataAccesLayer;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ICurrencyRepository _repository;
        ExchangeRate rate;
        public MainWindow(ICurrencyRepository repository)
        {
            InitializeComponent();
            rate = new ExchangeRate();
            _repository = repository;
        }
       

        private void RefreshCurrency_Click(object sender, RoutedEventArgs e)
        {
            rate.SetValues("USD");
            Usd_buy.Text = rate.Buy.ToString();
            Usd_sale.Text = rate.Sale.ToString();
            _repository.UpdateItem("USD", rate.Buy);


            rate.SetValues("EUR");
            Eur_buy.Text = rate.Buy.ToString();
            Eur_sale.Text = rate.Sale.ToString();
            _repository.UpdateItem("EUR", rate.Buy);
        }
    }
}

using BusinessLogicLayer;
using System.Windows;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ExchangeRate rate;
        public MainWindow()
        {
            InitializeComponent();
            rate = new ExchangeRate();
           
        }

        private void RefreshCurrency_Click(object sender, RoutedEventArgs e)
        {
            rate.SetValues("USD");
            Usd_buy.Text = rate.Buy.ToString();
            Usd_sale.Text = rate.Sale.ToString();

            rate.SetValues("EUR");
            Eur_buy.Text = rate.Buy.ToString();
            Eur_sale.Text = rate.Sale.ToString();
        }
    }
}

using MahApps.Metro.Controls;
using MarketManager.ViewModel;
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
using System.Windows.Shapes;
using MarketManager.Schemas;

namespace MarketManager
{
    /// <summary>
    /// Interaction logic for Quotes.xaml
    /// </summary>
    public partial class Quotes : MetroWindow
    {
        public QuoteViewModel quote;
        private LookupResult quoteName;

        public Quotes()
        {

        }

        public Quotes(LookupResult quoteName)
        {
            this.quoteName = quoteName;
            quote = new QuoteViewModel(quoteName.Symbol);
            InitializeComponent();
            DataContext = quote;
        }
    }
}

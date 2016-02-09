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
using MarketManager.Schemas;
using MarketManager.Connector;
using MarketManager.ViewPopulator;
using MarketManager.ViewModel;
using MahApps.Metro.Controls;

namespace MarketManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        MainViewModel _mainView;   
        public MainWindow()
        {           
            _mainView = new MainViewModel();
            this.DataContext = _mainView;
           
        }

        private void Open_quote(object sender, MouseButtonEventArgs e)
        {
            var gridItem = (DataGrid)sender;
            var quoteName = (LookupResult)gridItem.SelectedItem;
            Quotes q = new Quotes(quoteName);
            q.Show();
        }
    }
}



  
    


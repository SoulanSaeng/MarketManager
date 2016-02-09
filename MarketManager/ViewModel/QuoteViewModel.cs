using MarketManager.Connector;
using MarketManager.Schemas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.ViewModel
{
    public class QuoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private MarketAPI _api;
        private Quote _quote;
        private string _stockQuote;
        protected void OnPropertyChanged(string property)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
                eventHandler(this, new PropertyChangedEventArgs(property));
        }

        public QuoteViewModel(string quote)
        {
            _api = new MarketAPI();
            _stockQuote = quote;
            _quote = _api.getQuote(quote);
        }

        public QuoteViewModel()
        {
        }

        public string StockQuote
        {
            get
            {
                return this._stockQuote;
            }
            set
            {
                this._stockQuote = value;
                OnPropertyChanged("StockQuote");
            }
        }

        public Quote Quote
        {
            get
            {
                return this._quote;
            }

            set
            {
                this._quote = value;
                OnPropertyChanged("Quote");
            }
        }
    }
}

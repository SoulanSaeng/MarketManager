using MarketManager.Connector;
using MarketManager.Schemas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MarketManager.ViewModel
{
    public class MainViewModel  : INotifyPropertyChanged
    {
       
        private MarketAPI _MarketDataSource;
        private string _searchTerm;
        private LookupResultList _queryResult;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            this._queryResult = new LookupResultList();
            this._MarketDataSource = new MarketAPI();
            
        }

        public LookupResultList QueryResult
        {
            get
            {
                return this._queryResult;
            }

            set
            {
                this._queryResult = value;
                OnPropertyChanged("QueryResult");
            }
        }

        private MarketAPI MarketDataSource
        {
            get
            {
                return this._MarketDataSource;
            }

            set
            {
                this._MarketDataSource = value;
            }
        }


        //Pass a query, return a list of elements matching that query. 
        public void QueryQuotes(string query)
        {
            _MarketDataSource.getSymbolAsync<LookupResultList>(query, e =>
            {
                this.QueryResult = e;
            });   
        }

       
        public string SearchTerm
        {
            get
            {
                return _searchTerm;
            }
            set
            {
                this._searchTerm = value;
                if(value.Length>=4)
                    QueryQuotes(value); //Set the query
                OnPropertyChanged("SearchTerm");
            }
        }
        protected void OnPropertyChanged(string property)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
                eventHandler(this, new PropertyChangedEventArgs(property));
        }
    }
}

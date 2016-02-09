using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using MarketManager.Schemas;
using MarketManager.EndPoints;

namespace MarketManager.Connector
{
    public class MarketAPI
    {
        /// <summary>
        /// Returns the lookup for the query symbol - Get Request
        /// </summary>
        /// <param name="query"></param>
        public LookupResultList getSymbol(string query)
        {
            string host = MarkitEndpoints.BaseUrl;
            string endPoint = MarkitEndpoints.LookUp;
            RestRequest SymbolRequest = new RestRequest();
            SymbolRequest.AddParameter("input", query, ParameterType.QueryString);
            SymbolRequest.AddHeader("Content-Type", "application/xml");
            //Either Create an instance of Request Executor or access it statically.
            return RequestExecutor.Execute<LookupResultList>(SymbolRequest, host, endPoint);
        }

        public void getSymbolAsync<T>(string query, Action<LookupResultList> call)
        {
            string host = MarkitEndpoints.BaseUrl;
            string endPoint = MarkitEndpoints.LookUp;
            //TODO: Make this more modular. Use a wrapper class for RestRequest. 
            RestRequest SymbolRequest = new RestRequest();
            SymbolRequest.AddParameter("input", query, ParameterType.QueryString);
            SymbolRequest.AddHeader("Content-Type", "application/xml");
            RequestExecutor.ExecuteAsync<LookupResultList>(SymbolRequest, callback =>
            {
                call(callback);
            },
            host, endPoint);
        }

        public Quote getQuote(string quote)
        {
            string host = MarkitEndpoints.BaseUrl;
            string endPoint = MarkitEndpoints.StockQuote;
            RestRequest quoteRequest = new RestRequest();
            quoteRequest.AddParameter("symbol", quote, ParameterType.QueryString);
            quoteRequest.AddHeader("Content-type", "application/xml");
            return RequestExecutor.Execute<Quote>(quoteRequest, host, endPoint);
        }

        public void getQuoteAsync<T>(string quote, Action<Quote> call)
        {
            string host = MarkitEndpoints.BaseUrl;
            string endPoint = MarkitEndpoints.StockQuote;
            RestRequest quoteRequest = new RestRequest();
            quoteRequest.AddParameter("symbol", quote, ParameterType.QueryString);
            quoteRequest.AddHeader("Content-type", "application/xml");
            RequestExecutor.ExecuteAsync<Quote>(quoteRequest, callback =>
            {
                call(callback);
            },
            host, endPoint);
        }
    }
}

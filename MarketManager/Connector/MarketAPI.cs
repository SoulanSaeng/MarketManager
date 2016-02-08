using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using MarketManager.Schemas;

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
            RestRequest SymbolRequest = new RestRequest();
            SymbolRequest.AddParameter("input", query, ParameterType.QueryString);
            SymbolRequest.AddHeader("Content-Type", "application/xml");
            //Either Create an instance of Request Executor or access it statically.
            return RequestExecutor.Execute<LookupResultList>(SymbolRequest);
        }

        public void getSymbolAsync<T>(string query, Action<LookupResultList> call)
        {
            RestRequest SymbolRequest = new RestRequest();
            SymbolRequest.AddParameter("input", query, ParameterType.QueryString);
            SymbolRequest.AddHeader("Content-Type", "application/xml");
            RequestExecutor.ExecuteAsync<LookupResultList>(SymbolRequest, callback =>
            {
                call(callback);
            });
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.EndPoints
{
    /// <summary>
    /// Returns a preformatted url for the chosen endpoint.
    /// </summary>
     public static class MarkitEndpoints
    {
        //Provides the base url for all markit request.
        public const string BaseUrl = "dev.markitondemand.com";

        /// <summary>
        /// represents a stock quote lookup. Returns matching quotes based on input string
        /// </summary>
        public const string LookUp = "Api/v2/Lookup";

        /// <summary>
        /// Returns a quote based on the input string.
        /// </summary>
        public const string StockQuote = "Api/v2/Quote";

        /// <summary>
        /// Returns a data rich chart for the a given quote.
        /// </summary>
        public const string InteractiveChart = "Api/v2/InteractiveChart";   
    }
}

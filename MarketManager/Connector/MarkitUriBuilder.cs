using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManager.Connector
{
    public static class MarkitUriBuilder
    {
        /// <summary>
        /// Returns a prebuilt uri object
        /// </summary>
        /// <param name="baseurl">the base url to perform the request</param>
        /// <param name="endpoint">the endpoint on which the request is to be performed</param>
        /// <returns></returns>
        public static UriBuilder Build(string baseurl, string endpoint) 
        {
            UriBuilder uri = new UriBuilder();
            uri.Host = baseurl;
            uri.Path = endpoint;
            return uri;
        }
    }
}

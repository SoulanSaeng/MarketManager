using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace MarketManager.Connector
{
    public static class  RequestExecutor
    {
        /// <summary>
        /// Executes Request based on generic parameter types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Request"></param>
        /// <returns></returns>
        public static T Execute <T>(RestRequest Request, string baseUrl, string endPoint) where T : new()
        {
            RestClient client = new RestClient();
            UriBuilder requestUri = MarkitUriBuilder.Build(baseUrl, endPoint);
            client.BaseUrl = requestUri.Uri;
            
            var response = client.Execute<T>(Request);
            if (response.ErrorException!=null)
            {
                Console.WriteLine("Something went wrong! The following {0} occured", response.ErrorMessage);
                var ApiException = new Exception("ApiExeption is thrown", response.ErrorException);
            }

            return response.Data;
        }

        public static void ExecuteAsync<T>(RestRequest Request, Action<T>CallBack, string baseUrl, string endPoint) where T : new()
        {
            RestClient client = new RestClient();
            UriBuilder requestUri = MarkitUriBuilder.Build(baseUrl, endPoint);
            client.BaseUrl = requestUri.Uri;
            client.ExecuteAsync<T>(Request, (response) =>
            {
                if (response.ErrorException != null)
                {
                    Console.WriteLine("Something went wrong! The following {0} occured, {1}, {2}", response.ResponseStatus, response.Content, response.ErrorMessage);
                    var ApiException = new Exception("ApiExeption is thrown", response.ErrorException);
                }
                CallBack(response.Data);
            });
        }
    }
}

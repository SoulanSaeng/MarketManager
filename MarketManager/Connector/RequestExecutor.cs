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
        public const string BaseUrl = "dev.markitondemand.com";
        public const string LookUp = "Api/v2/Lookup";

        /// <summary>
        /// Executes Request based on generic parameter types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Request"></param>
        /// <returns></returns>
        public static T Execute <T>(RestRequest Request) where T : new()
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Host = BaseUrl;
            uriBuilder.Path = LookUp;
            Uri RequestUri = uriBuilder.Uri;

            RestClient client = new RestClient();
            client.BaseUrl = RequestUri;

            var response = client.Execute<T>(Request);

            if (response.ErrorException!=null)
            {
                Console.WriteLine("Something went wrong! The following {0} occured", response.ErrorMessage);
                var ApiException = new Exception("ApiExeption is thrown", response.ErrorException);
            }

            return response.Data;
        }

        public static void ExecuteAsync<T>(RestRequest Request, Action<T>CallBack) where T : new()
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Host = BaseUrl;
            uriBuilder.Path = LookUp;
            Uri RequestUri = uriBuilder.Uri;
            RestClient client = new RestClient();
            client.BaseUrl = RequestUri;
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

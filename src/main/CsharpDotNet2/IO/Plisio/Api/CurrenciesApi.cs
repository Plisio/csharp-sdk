using System;
using System.Collections.Generic;
using RestSharp;
using IO.Plisio.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICurrenciesApi
    {
        /// <summary>
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>CryptocurrencyApiResponseDto</returns>
        CryptocurrencyApiResponseDto CurrenciesFiatGet (string fiat);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CurrenciesApi : ICurrenciesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CurrenciesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrenciesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>CryptocurrencyApiResponseDto</returns>
        public CryptocurrencyApiResponseDto CurrenciesFiatGet (string fiat)
        {
            // verify the required parameter 'fiat' is set
            if (fiat == null) throw new ApiException(400, "Missing required parameter 'fiat' when calling CurrenciesFiatGet");
    
            var path = "/currencies/{fiat}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fiat" + "}", ApiClient.ParameterToString(fiat));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CurrenciesFiatGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CurrenciesFiatGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CryptocurrencyApiResponseDto) ApiClient.Deserialize(response.Content, typeof(CryptocurrencyApiResponseDto), response.Headers);
        }
    
    }
}

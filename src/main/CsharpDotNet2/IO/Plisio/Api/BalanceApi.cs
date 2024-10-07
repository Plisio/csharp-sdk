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
    public interface IBalanceApi
    {
        /// <summary>
        /// Get cryptocurrency balance 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>BalanceApiResponseDto</returns>
        BalanceApiResponseDto BalancesPsysCidGet (string psysCid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BalanceApi : IBalanceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BalanceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalanceApi(String basePath)
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
        /// Get cryptocurrency balance 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>BalanceApiResponseDto</returns>
        public BalanceApiResponseDto BalancesPsysCidGet (string psysCid)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling BalancesPsysCidGet");
    
            var path = "/balances/{psys_cid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "psys_cid" + "}", ApiClient.ParameterToString(psysCid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling BalancesPsysCidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BalancesPsysCidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BalanceApiResponseDto) ApiClient.Deserialize(response.Content, typeof(BalanceApiResponseDto), response.Headers);
        }
    
    }
}

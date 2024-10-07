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
    public interface IWithdrawApi
    {
        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan)</param>
        /// <returns>WithdrawApiResponseDto</returns>
        WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WithdrawApi : IWithdrawApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public WithdrawApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WithdrawApi(String basePath)
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
        /// Create new invoice 
        /// </summary>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan)</param>
        /// <returns>WithdrawApiResponseDto</returns>
        public WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling OperationsWithdrawGet");
            // verify the required parameter 'to' is set
            if (to == null) throw new ApiException(400, "Missing required parameter 'to' when calling OperationsWithdrawGet");
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling OperationsWithdrawGet");
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling OperationsWithdrawGet");
    
            var path = "/operations/withdraw";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (psysCid != null) queryParams.Add("psys_cid", ApiClient.ParameterToString(psysCid)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (amount != null) queryParams.Add("amount", ApiClient.ParameterToString(amount)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (feePlan != null) queryParams.Add("feePlan", ApiClient.ParameterToString(feePlan)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsWithdrawGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsWithdrawGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WithdrawApiResponseDto) ApiClient.Deserialize(response.Content, typeof(WithdrawApiResponseDto), response.Headers);
        }
    
    }
}

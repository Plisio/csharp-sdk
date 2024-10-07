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
    public interface ITransactionApi
    {
        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans)</param>
        /// <returns>CommissionApiResponseDto</returns>
        CommissionApiResponseDto OperationsCommissionPsysCidGet (string psysCid, string addresses, string amounts, string type, string feePlan);
        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>FeePlanApiResponseDto</returns>
        FeePlanApiResponseDto OperationsFeePlanPsysCidGet (string psysCid);
        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans)</param>
        /// <returns>FeeApiResponseDto</returns>
        FeeApiResponseDto OperationsFeePsysCidGet (string psysCid, string addresses, string amounts, string feePlan);
        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="limit">number of elements on the page</param>
        /// <param name="shopId">Filter operation by shop</param>
        /// <param name="type">Transaction type</param>
        /// <param name="status">Transaction status</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice</param>
        /// <returns>OperationsApiResponseDto</returns>
        OperationsApiResponseDto OperationsGet (int? page, int? limit, string shopId, string type, string status, string currency, string search);
        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <param name="id">transactoion id</param>
        /// <returns>OperationApiResponseDto</returns>
        OperationApiResponseDto OperationsIdGet (string id);
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
    public class TransactionApi : ITransactionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionApi(String basePath)
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
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans)</param>
        /// <returns>CommissionApiResponseDto</returns>
        public CommissionApiResponseDto OperationsCommissionPsysCidGet (string psysCid, string addresses, string amounts, string type, string feePlan)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling OperationsCommissionPsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null) throw new ApiException(400, "Missing required parameter 'addresses' when calling OperationsCommissionPsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null) throw new ApiException(400, "Missing required parameter 'amounts' when calling OperationsCommissionPsysCidGet");
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling OperationsCommissionPsysCidGet");
    
            var path = "/operations/commission/{psys_cid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "psys_cid" + "}", ApiClient.ParameterToString(psysCid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (addresses != null) queryParams.Add("addresses", ApiClient.ParameterToString(addresses)); // query parameter
 if (amounts != null) queryParams.Add("amounts", ApiClient.ParameterToString(amounts)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (feePlan != null) queryParams.Add("feePlan", ApiClient.ParameterToString(feePlan)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsCommissionPsysCidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsCommissionPsysCidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommissionApiResponseDto) ApiClient.Deserialize(response.Content, typeof(CommissionApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>FeePlanApiResponseDto</returns>
        public FeePlanApiResponseDto OperationsFeePlanPsysCidGet (string psysCid)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling OperationsFeePlanPsysCidGet");
    
            var path = "/operations/fee-plan/{psys_cid}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsFeePlanPsysCidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsFeePlanPsysCidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeePlanApiResponseDto) ApiClient.Deserialize(response.Content, typeof(FeePlanApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans)</param>
        /// <returns>FeeApiResponseDto</returns>
        public FeeApiResponseDto OperationsFeePsysCidGet (string psysCid, string addresses, string amounts, string feePlan)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling OperationsFeePsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null) throw new ApiException(400, "Missing required parameter 'addresses' when calling OperationsFeePsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null) throw new ApiException(400, "Missing required parameter 'amounts' when calling OperationsFeePsysCidGet");
    
            var path = "/operations/fee/{psys_cid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "psys_cid" + "}", ApiClient.ParameterToString(psysCid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (addresses != null) queryParams.Add("addresses", ApiClient.ParameterToString(addresses)); // query parameter
 if (amounts != null) queryParams.Add("amounts", ApiClient.ParameterToString(amounts)); // query parameter
 if (feePlan != null) queryParams.Add("feePlan", ApiClient.ParameterToString(feePlan)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsFeePsysCidGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsFeePsysCidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FeeApiResponseDto) ApiClient.Deserialize(response.Content, typeof(FeeApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="limit">number of elements on the page</param>
        /// <param name="shopId">Filter operation by shop</param>
        /// <param name="type">Transaction type</param>
        /// <param name="status">Transaction status</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice</param>
        /// <returns>OperationsApiResponseDto</returns>
        public OperationsApiResponseDto OperationsGet (int? page, int? limit, string shopId, string type, string status, string currency, string search)
        {
    
            var path = "/operations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (shopId != null) queryParams.Add("shop_id", ApiClient.ParameterToString(shopId)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (currency != null) queryParams.Add("currency", ApiClient.ParameterToString(currency)); // query parameter
 if (search != null) queryParams.Add("search", ApiClient.ParameterToString(search)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OperationsApiResponseDto) ApiClient.Deserialize(response.Content, typeof(OperationsApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <param name="id">transactoion id</param>
        /// <returns>OperationApiResponseDto</returns>
        public OperationApiResponseDto OperationsIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OperationsIdGet");
    
            var path = "/operations/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OperationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OperationApiResponseDto) ApiClient.Deserialize(response.Content, typeof(OperationApiResponseDto), response.Headers);
        }
    
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

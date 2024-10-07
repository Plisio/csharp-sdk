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
    public interface IInvoiceApi
    {
        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesEmailIdGet (string id, string email);
        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesIdGet (string id);
        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <param name="sourceAmount">any float value</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC</param>
        /// <param name="description">merchant invoice description</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent</param>
        /// <param name="language">en_US (we support EN language only)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version </param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired</param>
        /// <returns>InvoiceWhiteLabelResponseDto</returns>
        InvoiceWhiteLabelResponseDto InvoicesNewGet (string currency, string orderName, string orderNumber, string amount, string sourceCurrency, string sourceAmount, string allowedPsysCids, string description, string callbackUrl, string email, string language, string plugin, string version, bool? redirectToInvoice, string expireMin);
        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesSwitchIdGet (string id, string psysCid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceApi : IInvoiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoiceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceApi(String basePath)
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
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesEmailIdGet (string id, string email)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoicesEmailIdGet");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling InvoicesEmailIdGet");
    
            var path = "/invoices/email/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesEmailIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesEmailIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceDetailsApiResponseDto) ApiClient.Deserialize(response.Content, typeof(InvoiceDetailsApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoicesIdGet");
    
            var path = "/invoices/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceDetailsApiResponseDto) ApiClient.Deserialize(response.Content, typeof(InvoiceDetailsApiResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <param name="sourceAmount">any float value</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC</param>
        /// <param name="description">merchant invoice description</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent</param>
        /// <param name="language">en_US (we support EN language only)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version </param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired</param>
        /// <returns>InvoiceWhiteLabelResponseDto</returns>
        public InvoiceWhiteLabelResponseDto InvoicesNewGet (string currency, string orderName, string orderNumber, string amount, string sourceCurrency, string sourceAmount, string allowedPsysCids, string description, string callbackUrl, string email, string language, string plugin, string version, bool? redirectToInvoice, string expireMin)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling InvoicesNewGet");
            // verify the required parameter 'orderName' is set
            if (orderName == null) throw new ApiException(400, "Missing required parameter 'orderName' when calling InvoicesNewGet");
            // verify the required parameter 'orderNumber' is set
            if (orderNumber == null) throw new ApiException(400, "Missing required parameter 'orderNumber' when calling InvoicesNewGet");
    
            var path = "/invoices/new";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (currency != null) queryParams.Add("currency", ApiClient.ParameterToString(currency)); // query parameter
 if (amount != null) queryParams.Add("amount", ApiClient.ParameterToString(amount)); // query parameter
 if (sourceCurrency != null) queryParams.Add("source_currency", ApiClient.ParameterToString(sourceCurrency)); // query parameter
 if (sourceAmount != null) queryParams.Add("source_amount", ApiClient.ParameterToString(sourceAmount)); // query parameter
 if (allowedPsysCids != null) queryParams.Add("allowed_psys_cids", ApiClient.ParameterToString(allowedPsysCids)); // query parameter
 if (orderName != null) queryParams.Add("order_name", ApiClient.ParameterToString(orderName)); // query parameter
 if (orderNumber != null) queryParams.Add("order_number", ApiClient.ParameterToString(orderNumber)); // query parameter
 if (description != null) queryParams.Add("description", ApiClient.ParameterToString(description)); // query parameter
 if (callbackUrl != null) queryParams.Add("callback_url", ApiClient.ParameterToString(callbackUrl)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
 if (plugin != null) queryParams.Add("plugin", ApiClient.ParameterToString(plugin)); // query parameter
 if (version != null) queryParams.Add("version", ApiClient.ParameterToString(version)); // query parameter
 if (redirectToInvoice != null) queryParams.Add("redirect_to_invoice", ApiClient.ParameterToString(redirectToInvoice)); // query parameter
 if (expireMin != null) queryParams.Add("expire_min", ApiClient.ParameterToString(expireMin)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesNewGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesNewGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceWhiteLabelResponseDto) ApiClient.Deserialize(response.Content, typeof(InvoiceWhiteLabelResponseDto), response.Headers);
        }
    
        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesSwitchIdGet (string id, string psysCid)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InvoicesSwitchIdGet");
            // verify the required parameter 'psysCid' is set
            if (psysCid == null) throw new ApiException(400, "Missing required parameter 'psysCid' when calling InvoicesSwitchIdGet");
    
            var path = "/invoices/switch/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (psysCid != null) queryParams.Add("psys_cid", ApiClient.ParameterToString(psysCid)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "view_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesSwitchIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InvoicesSwitchIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InvoiceDetailsApiResponseDto) ApiClient.Deserialize(response.Content, typeof(InvoiceDetailsApiResponseDto), response.Headers);
        }
    
    }
}

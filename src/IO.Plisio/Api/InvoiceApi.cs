/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 * Contact: lead@plisio.net
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace IO.Plisio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IInvoiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesEmailIdGet (string id, string email);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        ApiResponse<InvoiceDetailsApiResponseDto> InvoicesEmailIdGetWithHttpInfo (string id, string email);
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesIdGet (string id);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        ApiResponse<InvoiceDetailsApiResponseDto> InvoicesIdGetWithHttpInfo (string id);
        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>InvoiceWhiteLabelResponseDto</returns>
        InvoiceWhiteLabelResponseDto InvoicesNewGet (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null);

        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>ApiResponse of InvoiceWhiteLabelResponseDto</returns>
        ApiResponse<InvoiceWhiteLabelResponseDto> InvoicesNewGetWithHttpInfo (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null);
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        InvoiceDetailsApiResponseDto InvoicesSwitchIdGet (string id, string psysCid);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        ApiResponse<InvoiceDetailsApiResponseDto> InvoicesSwitchIdGetWithHttpInfo (string id, string psysCid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesEmailIdGetAsync (string id, string email);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesEmailIdGetAsyncWithHttpInfo (string id, string email);
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesIdGetAsync (string id);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>Task of InvoiceWhiteLabelResponseDto</returns>
        System.Threading.Tasks.Task<InvoiceWhiteLabelResponseDto> InvoicesNewGetAsync (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null);

        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>Task of ApiResponse (InvoiceWhiteLabelResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWhiteLabelResponseDto>> InvoicesNewGetAsyncWithHttpInfo (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null);
        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesSwitchIdGetAsync (string id, string psysCid);

        /// <summary>
        /// Invoice details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesSwitchIdGetAsyncWithHttpInfo (string id, string psysCid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class InvoiceApi : IInvoiceApi
    {
        private IO.Plisio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceApi(String basePath)
        {
            this.Configuration = new IO.Plisio.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public InvoiceApi()
        {
            this.Configuration = IO.Plisio.Client.Configuration.Default;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceApi(IO.Plisio.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Plisio.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Plisio.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Plisio.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesEmailIdGet (string id, string email)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = InvoicesEmailIdGetWithHttpInfo(id, email);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        public ApiResponse< InvoiceDetailsApiResponseDto > InvoicesEmailIdGetWithHttpInfo (string id, string email)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesEmailIdGet");
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling InvoiceApi->InvoicesEmailIdGet");

            var localVarPath = "/invoices/email/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesEmailIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        public async System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesEmailIdGetAsync (string id, string email)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = await InvoicesEmailIdGetAsyncWithHttpInfo(id, email);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="email">payer&#x27;s email</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesEmailIdGetAsyncWithHttpInfo (string id, string email)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesEmailIdGet");
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling InvoiceApi->InvoicesEmailIdGet");

            var localVarPath = "/invoices/email/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesEmailIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesIdGet (string id)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = InvoicesIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        public ApiResponse< InvoiceDetailsApiResponseDto > InvoicesIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesIdGet");

            var localVarPath = "/invoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        public async System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesIdGetAsync (string id)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = await InvoicesIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesIdGet");

            var localVarPath = "/invoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>InvoiceWhiteLabelResponseDto</returns>
        public InvoiceWhiteLabelResponseDto InvoicesNewGet (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null)
        {
             ApiResponse<InvoiceWhiteLabelResponseDto> localVarResponse = InvoicesNewGetWithHttpInfo(currency, orderName, orderNumber, amount, sourceCurrency, sourceAmount, allowedPsysCids, description, callbackUrl, email, language, plugin, version, redirectToInvoice, expireMin);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>ApiResponse of InvoiceWhiteLabelResponseDto</returns>
        public ApiResponse< InvoiceWhiteLabelResponseDto > InvoicesNewGetWithHttpInfo (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null)
                throw new ApiException(400, "Missing required parameter 'currency' when calling InvoiceApi->InvoicesNewGet");
            // verify the required parameter 'orderName' is set
            if (orderName == null)
                throw new ApiException(400, "Missing required parameter 'orderName' when calling InvoiceApi->InvoicesNewGet");
            // verify the required parameter 'orderNumber' is set
            if (orderNumber == null)
                throw new ApiException(400, "Missing required parameter 'orderNumber' when calling InvoiceApi->InvoicesNewGet");

            var localVarPath = "/invoices/new";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter
            if (sourceCurrency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "source_currency", sourceCurrency)); // query parameter
            if (sourceAmount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "source_amount", sourceAmount)); // query parameter
            if (allowedPsysCids != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "allowed_psys_cids", allowedPsysCids)); // query parameter
            if (orderName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_name", orderName)); // query parameter
            if (orderNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_number", orderNumber)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "description", description)); // query parameter
            if (callbackUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "callback_url", callbackUrl)); // query parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (plugin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "plugin", plugin)); // query parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (redirectToInvoice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "redirect_to_invoice", redirectToInvoice)); // query parameter
            if (expireMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "expire_min", expireMin)); // query parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesNewGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceWhiteLabelResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceWhiteLabelResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWhiteLabelResponseDto)));
        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>Task of InvoiceWhiteLabelResponseDto</returns>
        public async System.Threading.Tasks.Task<InvoiceWhiteLabelResponseDto> InvoicesNewGetAsync (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null)
        {
             ApiResponse<InvoiceWhiteLabelResponseDto> localVarResponse = await InvoicesNewGetAsyncWithHttpInfo(currency, orderName, orderNumber, amount, sourceCurrency, sourceAmount, allowedPsysCids, description, callbackUrl, email, language, plugin, version, redirectToInvoice, expireMin);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="orderName">merchant internal order name</param>
        /// <param name="orderNumber">merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!!</param>
        /// <param name="amount">any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional)</param>
        /// <param name="sourceCurrency">one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional)</param>
        /// <param name="sourceAmount">any float value (optional)</param>
        /// <param name="allowedPsysCids">comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional)</param>
        /// <param name="description">merchant invoice description (optional)</param>
        /// <param name="callbackUrl">merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional)</param>
        /// <param name="email">an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional)</param>
        /// <param name="language">en_US (we support EN language only) (optional)</param>
        /// <param name="plugin">Plisio’s internal field to determine integration plugin (optional)</param>
        /// <param name="version">Plisio’s internal field to determine integration plugin version  (optional)</param>
        /// <param name="redirectToInvoice">Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) (optional)</param>
        /// <param name="expireMin">Interval in minutes when invoice will be expired (optional)</param>
        /// <returns>Task of ApiResponse (InvoiceWhiteLabelResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWhiteLabelResponseDto>> InvoicesNewGetAsyncWithHttpInfo (string currency, string orderName, string orderNumber, string amount = null, string sourceCurrency = null, string sourceAmount = null, string allowedPsysCids = null, string description = null, string callbackUrl = null, string email = null, string language = null, string plugin = null, string version = null, bool? redirectToInvoice = null, string expireMin = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null)
                throw new ApiException(400, "Missing required parameter 'currency' when calling InvoiceApi->InvoicesNewGet");
            // verify the required parameter 'orderName' is set
            if (orderName == null)
                throw new ApiException(400, "Missing required parameter 'orderName' when calling InvoiceApi->InvoicesNewGet");
            // verify the required parameter 'orderNumber' is set
            if (orderNumber == null)
                throw new ApiException(400, "Missing required parameter 'orderNumber' when calling InvoiceApi->InvoicesNewGet");

            var localVarPath = "/invoices/new";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter
            if (sourceCurrency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "source_currency", sourceCurrency)); // query parameter
            if (sourceAmount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "source_amount", sourceAmount)); // query parameter
            if (allowedPsysCids != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "allowed_psys_cids", allowedPsysCids)); // query parameter
            if (orderName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_name", orderName)); // query parameter
            if (orderNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_number", orderNumber)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "description", description)); // query parameter
            if (callbackUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "callback_url", callbackUrl)); // query parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (plugin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "plugin", plugin)); // query parameter
            if (version != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "version", version)); // query parameter
            if (redirectToInvoice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "redirect_to_invoice", redirectToInvoice)); // query parameter
            if (expireMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "expire_min", expireMin)); // query parameter
            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesNewGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceWhiteLabelResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceWhiteLabelResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWhiteLabelResponseDto)));
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>InvoiceDetailsApiResponseDto</returns>
        public InvoiceDetailsApiResponseDto InvoicesSwitchIdGet (string id, string psysCid)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = InvoicesSwitchIdGetWithHttpInfo(id, psysCid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>ApiResponse of InvoiceDetailsApiResponseDto</returns>
        public ApiResponse< InvoiceDetailsApiResponseDto > InvoicesSwitchIdGetWithHttpInfo (string id, string psysCid)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesSwitchIdGet");
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling InvoiceApi->InvoicesSwitchIdGet");

            var localVarPath = "/invoices/switch/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (psysCid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "psys_cid", psysCid)); // query parameter
            // authentication (view_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("view_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "view_key", this.Configuration.GetApiKeyWithPrefix("view_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesSwitchIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>Task of InvoiceDetailsApiResponseDto</returns>
        public async System.Threading.Tasks.Task<InvoiceDetailsApiResponseDto> InvoicesSwitchIdGetAsync (string id, string psysCid)
        {
             ApiResponse<InvoiceDetailsApiResponseDto> localVarResponse = await InvoicesSwitchIdGetAsyncWithHttpInfo(id, psysCid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Invoice details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">invoice id</param>
        /// <param name="psysCid">destination cryptocurrency id</param>
        /// <returns>Task of ApiResponse (InvoiceDetailsApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceDetailsApiResponseDto>> InvoicesSwitchIdGetAsyncWithHttpInfo (string id, string psysCid)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceApi->InvoicesSwitchIdGet");
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling InvoiceApi->InvoicesSwitchIdGet");

            var localVarPath = "/invoices/switch/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (psysCid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "psys_cid", psysCid)); // query parameter
            // authentication (view_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("view_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "view_key", this.Configuration.GetApiKeyWithPrefix("view_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InvoicesSwitchIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceDetailsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InvoiceDetailsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceDetailsApiResponseDto)));
        }

    }
}

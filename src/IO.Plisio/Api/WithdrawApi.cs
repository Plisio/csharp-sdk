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
        public interface IWithdrawApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>WithdrawApiResponseDto</returns>
        WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan = null);

        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>ApiResponse of WithdrawApiResponseDto</returns>
        ApiResponse<WithdrawApiResponseDto> OperationsWithdrawGetWithHttpInfo (string psysCid, string to, string amount, string type, string feePlan = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>Task of WithdrawApiResponseDto</returns>
        System.Threading.Tasks.Task<WithdrawApiResponseDto> OperationsWithdrawGetAsync (string psysCid, string to, string amount, string type, string feePlan = null);

        /// <summary>
        /// Create new invoice
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>Task of ApiResponse (WithdrawApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<WithdrawApiResponseDto>> OperationsWithdrawGetAsyncWithHttpInfo (string psysCid, string to, string amount, string type, string feePlan = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class WithdrawApi : IWithdrawApi
    {
        private IO.Plisio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WithdrawApi(String basePath)
        {
            this.Configuration = new IO.Plisio.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class
        /// </summary>
        /// <returns></returns>
        public WithdrawApi()
        {
            this.Configuration = IO.Plisio.Client.Configuration.Default;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WithdrawApi(IO.Plisio.Client.Configuration configuration = null)
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
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>WithdrawApiResponseDto</returns>
        public WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan = null)
        {
             ApiResponse<WithdrawApiResponseDto> localVarResponse = OperationsWithdrawGetWithHttpInfo(psysCid, to, amount, type, feePlan);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>ApiResponse of WithdrawApiResponseDto</returns>
        public ApiResponse< WithdrawApiResponseDto > OperationsWithdrawGetWithHttpInfo (string psysCid, string to, string amount, string type, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'amount' is set
            if (amount == null)
                throw new ApiException(400, "Missing required parameter 'amount' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling WithdrawApi->OperationsWithdrawGet");

            var localVarPath = "/operations/withdraw";
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

            if (psysCid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "psys_cid", psysCid)); // query parameter
            if (to != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to", to)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (feePlan != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "feePlan", feePlan)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsWithdrawGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WithdrawApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WithdrawApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WithdrawApiResponseDto)));
        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>Task of WithdrawApiResponseDto</returns>
        public async System.Threading.Tasks.Task<WithdrawApiResponseDto> OperationsWithdrawGetAsync (string psysCid, string to, string amount, string type, string feePlan = null)
        {
             ApiResponse<WithdrawApiResponseDto> localVarResponse = await OperationsWithdrawGetAsyncWithHttpInfo(psysCid, to, amount, type, feePlan);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new invoice 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)</param>
        /// <param name="to">hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27;</param>
        /// <param name="amount">any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter</param>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes</param>
        /// <param name="feePlan"> normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional)</param>
        /// <returns>Task of ApiResponse (WithdrawApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WithdrawApiResponseDto>> OperationsWithdrawGetAsyncWithHttpInfo (string psysCid, string to, string amount, string type, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'amount' is set
            if (amount == null)
                throw new ApiException(400, "Missing required parameter 'amount' when calling WithdrawApi->OperationsWithdrawGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling WithdrawApi->OperationsWithdrawGet");

            var localVarPath = "/operations/withdraw";
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

            if (psysCid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "psys_cid", psysCid)); // query parameter
            if (to != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "to", to)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (feePlan != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "feePlan", feePlan)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsWithdrawGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WithdrawApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (WithdrawApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WithdrawApiResponseDto)));
        }

    }
}

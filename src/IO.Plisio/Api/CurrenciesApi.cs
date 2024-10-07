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
        public interface ICurrenciesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List of supported cryptocurrencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>CryptocurrencyApiResponseDto</returns>
        CryptocurrencyApiResponseDto CurrenciesFiatGet (string fiat);

        /// <summary>
        /// List of supported cryptocurrencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>ApiResponse of CryptocurrencyApiResponseDto</returns>
        ApiResponse<CryptocurrencyApiResponseDto> CurrenciesFiatGetWithHttpInfo (string fiat);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List of supported cryptocurrencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>Task of CryptocurrencyApiResponseDto</returns>
        System.Threading.Tasks.Task<CryptocurrencyApiResponseDto> CurrenciesFiatGetAsync (string fiat);

        /// <summary>
        /// List of supported cryptocurrencies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>Task of ApiResponse (CryptocurrencyApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<CryptocurrencyApiResponseDto>> CurrenciesFiatGetAsyncWithHttpInfo (string fiat);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CurrenciesApi : ICurrenciesApi
    {
        private IO.Plisio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrenciesApi(String basePath)
        {
            this.Configuration = new IO.Plisio.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class
        /// </summary>
        /// <returns></returns>
        public CurrenciesApi()
        {
            this.Configuration = IO.Plisio.Client.Configuration.Default;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurrenciesApi(IO.Plisio.Client.Configuration configuration = null)
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
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>CryptocurrencyApiResponseDto</returns>
        public CryptocurrencyApiResponseDto CurrenciesFiatGet (string fiat)
        {
             ApiResponse<CryptocurrencyApiResponseDto> localVarResponse = CurrenciesFiatGetWithHttpInfo(fiat);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>ApiResponse of CryptocurrencyApiResponseDto</returns>
        public ApiResponse< CryptocurrencyApiResponseDto > CurrenciesFiatGetWithHttpInfo (string fiat)
        {
            // verify the required parameter 'fiat' is set
            if (fiat == null)
                throw new ApiException(400, "Missing required parameter 'fiat' when calling CurrenciesApi->CurrenciesFiatGet");

            var localVarPath = "/currencies/{fiat}";
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

            if (fiat != null) localVarPathParams.Add("fiat", this.Configuration.ApiClient.ParameterToString(fiat)); // path parameter
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
                Exception exception = ExceptionFactory("CurrenciesFiatGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CryptocurrencyApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CryptocurrencyApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CryptocurrencyApiResponseDto)));
        }

        /// <summary>
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>Task of CryptocurrencyApiResponseDto</returns>
        public async System.Threading.Tasks.Task<CryptocurrencyApiResponseDto> CurrenciesFiatGetAsync (string fiat)
        {
             ApiResponse<CryptocurrencyApiResponseDto> localVarResponse = await CurrenciesFiatGetAsyncWithHttpInfo(fiat);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of supported cryptocurrencies 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fiat">one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies</param>
        /// <returns>Task of ApiResponse (CryptocurrencyApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CryptocurrencyApiResponseDto>> CurrenciesFiatGetAsyncWithHttpInfo (string fiat)
        {
            // verify the required parameter 'fiat' is set
            if (fiat == null)
                throw new ApiException(400, "Missing required parameter 'fiat' when calling CurrenciesApi->CurrenciesFiatGet");

            var localVarPath = "/currencies/{fiat}";
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

            if (fiat != null) localVarPathParams.Add("fiat", this.Configuration.ApiClient.ParameterToString(fiat)); // path parameter
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
                Exception exception = ExceptionFactory("CurrenciesFiatGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CryptocurrencyApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CryptocurrencyApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CryptocurrencyApiResponseDto)));
        }

    }
}

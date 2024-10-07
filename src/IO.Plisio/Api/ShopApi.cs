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
        public interface IShopApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get shop info by api_key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ShopResponseDto</returns>
        ShopResponseDto ShopsGet ();

        /// <summary>
        /// Get shop info by api_key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ShopResponseDto</returns>
        ApiResponse<ShopResponseDto> ShopsGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get shop info by api_key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ShopResponseDto</returns>
        System.Threading.Tasks.Task<ShopResponseDto> ShopsGetAsync ();

        /// <summary>
        /// Get shop info by api_key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ShopResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShopResponseDto>> ShopsGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ShopApi : IShopApi
    {
        private IO.Plisio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShopApi(String basePath)
        {
            this.Configuration = new IO.Plisio.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopApi"/> class
        /// </summary>
        /// <returns></returns>
        public ShopApi()
        {
            this.Configuration = IO.Plisio.Client.Configuration.Default;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShopApi(IO.Plisio.Client.Configuration configuration = null)
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
        /// Get shop info by api_key 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ShopResponseDto</returns>
        public ShopResponseDto ShopsGet ()
        {
             ApiResponse<ShopResponseDto> localVarResponse = ShopsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get shop info by api_key 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ShopResponseDto</returns>
        public ApiResponse< ShopResponseDto > ShopsGetWithHttpInfo ()
        {

            var localVarPath = "/shops";
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
                Exception exception = ExceptionFactory("ShopsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShopResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ShopResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShopResponseDto)));
        }

        /// <summary>
        /// Get shop info by api_key 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ShopResponseDto</returns>
        public async System.Threading.Tasks.Task<ShopResponseDto> ShopsGetAsync ()
        {
             ApiResponse<ShopResponseDto> localVarResponse = await ShopsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get shop info by api_key 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ShopResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShopResponseDto>> ShopsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/shops";
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
                Exception exception = ExceptionFactory("ShopsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShopResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ShopResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShopResponseDto)));
        }

    }
}

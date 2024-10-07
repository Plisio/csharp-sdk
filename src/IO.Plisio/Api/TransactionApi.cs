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
        public interface ITransactionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>CommissionApiResponseDto</returns>
        CommissionApiResponseDto OperationsCommissionPsysCidGet (string psysCid, string addresses, string amounts, string type, string feePlan = null);

        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>ApiResponse of CommissionApiResponseDto</returns>
        ApiResponse<CommissionApiResponseDto> OperationsCommissionPsysCidGetWithHttpInfo (string psysCid, string addresses, string amounts, string type, string feePlan = null);
        /// <summary>
        /// Get Plisio fee plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>FeePlanApiResponseDto</returns>
        FeePlanApiResponseDto OperationsFeePlanPsysCidGet (string psysCid);

        /// <summary>
        /// Get Plisio fee plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>ApiResponse of FeePlanApiResponseDto</returns>
        ApiResponse<FeePlanApiResponseDto> OperationsFeePlanPsysCidGetWithHttpInfo (string psysCid);
        /// <summary>
        /// Estimate fee
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>FeeApiResponseDto</returns>
        FeeApiResponseDto OperationsFeePsysCidGet (string psysCid, string addresses, string amounts, string feePlan = null);

        /// <summary>
        /// Estimate fee
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>ApiResponse of FeeApiResponseDto</returns>
        ApiResponse<FeeApiResponseDto> OperationsFeePsysCidGetWithHttpInfo (string psysCid, string addresses, string amounts, string feePlan = null);
        /// <summary>
        /// List of all user transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>OperationsApiResponseDto</returns>
        OperationsApiResponseDto OperationsGet (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null);

        /// <summary>
        /// List of all user transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>ApiResponse of OperationsApiResponseDto</returns>
        ApiResponse<OperationsApiResponseDto> OperationsGetWithHttpInfo (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null);
        /// <summary>
        /// Transaction details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>OperationApiResponseDto</returns>
        OperationApiResponseDto OperationsIdGet (string id);

        /// <summary>
        /// Transaction details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>ApiResponse of OperationApiResponseDto</returns>
        ApiResponse<OperationApiResponseDto> OperationsIdGetWithHttpInfo (string id);
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
        /// Estimate cryptocurrency fee and Plisio commission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of CommissionApiResponseDto</returns>
        System.Threading.Tasks.Task<CommissionApiResponseDto> OperationsCommissionPsysCidGetAsync (string psysCid, string addresses, string amounts, string type, string feePlan = null);

        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of ApiResponse (CommissionApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommissionApiResponseDto>> OperationsCommissionPsysCidGetAsyncWithHttpInfo (string psysCid, string addresses, string amounts, string type, string feePlan = null);
        /// <summary>
        /// Get Plisio fee plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>Task of FeePlanApiResponseDto</returns>
        System.Threading.Tasks.Task<FeePlanApiResponseDto> OperationsFeePlanPsysCidGetAsync (string psysCid);

        /// <summary>
        /// Get Plisio fee plans
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>Task of ApiResponse (FeePlanApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeePlanApiResponseDto>> OperationsFeePlanPsysCidGetAsyncWithHttpInfo (string psysCid);
        /// <summary>
        /// Estimate fee
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of FeeApiResponseDto</returns>
        System.Threading.Tasks.Task<FeeApiResponseDto> OperationsFeePsysCidGetAsync (string psysCid, string addresses, string amounts, string feePlan = null);

        /// <summary>
        /// Estimate fee
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of ApiResponse (FeeApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<FeeApiResponseDto>> OperationsFeePsysCidGetAsyncWithHttpInfo (string psysCid, string addresses, string amounts, string feePlan = null);
        /// <summary>
        /// List of all user transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>Task of OperationsApiResponseDto</returns>
        System.Threading.Tasks.Task<OperationsApiResponseDto> OperationsGetAsync (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null);

        /// <summary>
        /// List of all user transactions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>Task of ApiResponse (OperationsApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationsApiResponseDto>> OperationsGetAsyncWithHttpInfo (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null);
        /// <summary>
        /// Transaction details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>Task of OperationApiResponseDto</returns>
        System.Threading.Tasks.Task<OperationApiResponseDto> OperationsIdGetAsync (string id);

        /// <summary>
        /// Transaction details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>Task of ApiResponse (OperationApiResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperationApiResponseDto>> OperationsIdGetAsyncWithHttpInfo (string id);
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
        public partial class TransactionApi : ITransactionApi
    {
        private IO.Plisio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionApi(String basePath)
        {
            this.Configuration = new IO.Plisio.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class
        /// </summary>
        /// <returns></returns>
        public TransactionApi()
        {
            this.Configuration = IO.Plisio.Client.Configuration.Default;

            ExceptionFactory = IO.Plisio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionApi(IO.Plisio.Client.Configuration configuration = null)
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
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>CommissionApiResponseDto</returns>
        public CommissionApiResponseDto OperationsCommissionPsysCidGet (string psysCid, string addresses, string amounts, string type, string feePlan = null)
        {
             ApiResponse<CommissionApiResponseDto> localVarResponse = OperationsCommissionPsysCidGetWithHttpInfo(psysCid, addresses, amounts, type, feePlan);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>ApiResponse of CommissionApiResponseDto</returns>
        public ApiResponse< CommissionApiResponseDto > OperationsCommissionPsysCidGetWithHttpInfo (string psysCid, string addresses, string amounts, string type, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null)
                throw new ApiException(400, "Missing required parameter 'amounts' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling TransactionApi->OperationsCommissionPsysCidGet");

            var localVarPath = "/operations/commission/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
            if (addresses != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addresses", addresses)); // query parameter
            if (amounts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amounts", amounts)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsCommissionPsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommissionApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CommissionApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommissionApiResponseDto)));
        }

        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of CommissionApiResponseDto</returns>
        public async System.Threading.Tasks.Task<CommissionApiResponseDto> OperationsCommissionPsysCidGetAsync (string psysCid, string addresses, string amounts, string type, string feePlan = null)
        {
             ApiResponse<CommissionApiResponseDto> localVarResponse = await OperationsCommissionPsysCidGetAsyncWithHttpInfo(psysCid, addresses, amounts, type, feePlan);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Estimate cryptocurrency fee and Plisio commission 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="type">operation type</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of ApiResponse (CommissionApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommissionApiResponseDto>> OperationsCommissionPsysCidGetAsyncWithHttpInfo (string psysCid, string addresses, string amounts, string type, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null)
                throw new ApiException(400, "Missing required parameter 'amounts' when calling TransactionApi->OperationsCommissionPsysCidGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling TransactionApi->OperationsCommissionPsysCidGet");

            var localVarPath = "/operations/commission/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
            if (addresses != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addresses", addresses)); // query parameter
            if (amounts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amounts", amounts)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsCommissionPsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommissionApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CommissionApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommissionApiResponseDto)));
        }

        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>FeePlanApiResponseDto</returns>
        public FeePlanApiResponseDto OperationsFeePlanPsysCidGet (string psysCid)
        {
             ApiResponse<FeePlanApiResponseDto> localVarResponse = OperationsFeePlanPsysCidGetWithHttpInfo(psysCid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>ApiResponse of FeePlanApiResponseDto</returns>
        public ApiResponse< FeePlanApiResponseDto > OperationsFeePlanPsysCidGetWithHttpInfo (string psysCid)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsFeePlanPsysCidGet");

            var localVarPath = "/operations/fee-plan/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
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
                Exception exception = ExceptionFactory("OperationsFeePlanPsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FeePlanApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FeePlanApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeePlanApiResponseDto)));
        }

        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>Task of FeePlanApiResponseDto</returns>
        public async System.Threading.Tasks.Task<FeePlanApiResponseDto> OperationsFeePlanPsysCidGetAsync (string psysCid)
        {
             ApiResponse<FeePlanApiResponseDto> localVarResponse = await OperationsFeePlanPsysCidGetAsyncWithHttpInfo(psysCid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Plisio fee plans 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <returns>Task of ApiResponse (FeePlanApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FeePlanApiResponseDto>> OperationsFeePlanPsysCidGetAsyncWithHttpInfo (string psysCid)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsFeePlanPsysCidGet");

            var localVarPath = "/operations/fee-plan/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
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
                Exception exception = ExceptionFactory("OperationsFeePlanPsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FeePlanApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FeePlanApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeePlanApiResponseDto)));
        }

        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>FeeApiResponseDto</returns>
        public FeeApiResponseDto OperationsFeePsysCidGet (string psysCid, string addresses, string amounts, string feePlan = null)
        {
             ApiResponse<FeeApiResponseDto> localVarResponse = OperationsFeePsysCidGetWithHttpInfo(psysCid, addresses, amounts, feePlan);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>ApiResponse of FeeApiResponseDto</returns>
        public ApiResponse< FeeApiResponseDto > OperationsFeePsysCidGetWithHttpInfo (string psysCid, string addresses, string amounts, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsFeePsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling TransactionApi->OperationsFeePsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null)
                throw new ApiException(400, "Missing required parameter 'amounts' when calling TransactionApi->OperationsFeePsysCidGet");

            var localVarPath = "/operations/fee/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
            if (addresses != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addresses", addresses)); // query parameter
            if (amounts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amounts", amounts)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsFeePsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FeeApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FeeApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeeApiResponseDto)));
        }

        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of FeeApiResponseDto</returns>
        public async System.Threading.Tasks.Task<FeeApiResponseDto> OperationsFeePsysCidGetAsync (string psysCid, string addresses, string amounts, string feePlan = null)
        {
             ApiResponse<FeeApiResponseDto> localVarResponse = await OperationsFeePsysCidGetAsyncWithHttpInfo(psysCid, addresses, amounts, feePlan);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Estimate fee 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="psysCid">ID column from one of the supported cryptocurrencies supported by Plisio</param>
        /// <param name="addresses">wallet address or comma separated addresses when estimating fee for mass withdrawal</param>
        /// <param name="amounts">amount or comma separated amount that will be send in case of mass withdraw</param>
        /// <param name="feePlan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional)</param>
        /// <returns>Task of ApiResponse (FeeApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FeeApiResponseDto>> OperationsFeePsysCidGetAsyncWithHttpInfo (string psysCid, string addresses, string amounts, string feePlan = null)
        {
            // verify the required parameter 'psysCid' is set
            if (psysCid == null)
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsFeePsysCidGet");
            // verify the required parameter 'addresses' is set
            if (addresses == null)
                throw new ApiException(400, "Missing required parameter 'addresses' when calling TransactionApi->OperationsFeePsysCidGet");
            // verify the required parameter 'amounts' is set
            if (amounts == null)
                throw new ApiException(400, "Missing required parameter 'amounts' when calling TransactionApi->OperationsFeePsysCidGet");

            var localVarPath = "/operations/fee/{psys_cid}";
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

            if (psysCid != null) localVarPathParams.Add("psys_cid", this.Configuration.ApiClient.ParameterToString(psysCid)); // path parameter
            if (addresses != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addresses", addresses)); // query parameter
            if (amounts != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amounts", amounts)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsFeePsysCidGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FeeApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FeeApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FeeApiResponseDto)));
        }

        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>OperationsApiResponseDto</returns>
        public OperationsApiResponseDto OperationsGet (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null)
        {
             ApiResponse<OperationsApiResponseDto> localVarResponse = OperationsGetWithHttpInfo(page, limit, shopId, type, status, currency, search);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>ApiResponse of OperationsApiResponseDto</returns>
        public ApiResponse< OperationsApiResponseDto > OperationsGetWithHttpInfo (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null)
        {

            var localVarPath = "/operations";
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

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (shopId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "shop_id", shopId)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OperationsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationsApiResponseDto)));
        }

        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>Task of OperationsApiResponseDto</returns>
        public async System.Threading.Tasks.Task<OperationsApiResponseDto> OperationsGetAsync (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null)
        {
             ApiResponse<OperationsApiResponseDto> localVarResponse = await OperationsGetAsyncWithHttpInfo(page, limit, shopId, type, status, currency, search);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of all user transactions 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">page number (optional)</param>
        /// <param name="limit">number of elements on the page (optional)</param>
        /// <param name="shopId">Filter operation by shop (optional)</param>
        /// <param name="type">Transaction type (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="currency">one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional)</param>
        /// <param name="search">text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional)</param>
        /// <returns>Task of ApiResponse (OperationsApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperationsApiResponseDto>> OperationsGetAsyncWithHttpInfo (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null)
        {

            var localVarPath = "/operations";
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

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (shopId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "shop_id", shopId)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "search", search)); // query parameter
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
                Exception exception = ExceptionFactory("OperationsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationsApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OperationsApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationsApiResponseDto)));
        }

        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>OperationApiResponseDto</returns>
        public OperationApiResponseDto OperationsIdGet (string id)
        {
             ApiResponse<OperationApiResponseDto> localVarResponse = OperationsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>ApiResponse of OperationApiResponseDto</returns>
        public ApiResponse< OperationApiResponseDto > OperationsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionApi->OperationsIdGet");

            var localVarPath = "/operations/{id}";
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
                Exception exception = ExceptionFactory("OperationsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OperationApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationApiResponseDto)));
        }

        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>Task of OperationApiResponseDto</returns>
        public async System.Threading.Tasks.Task<OperationApiResponseDto> OperationsIdGetAsync (string id)
        {
             ApiResponse<OperationApiResponseDto> localVarResponse = await OperationsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transaction details 
        /// </summary>
        /// <exception cref="IO.Plisio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">transactoion id</param>
        /// <returns>Task of ApiResponse (OperationApiResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperationApiResponseDto>> OperationsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionApi->OperationsIdGet");

            var localVarPath = "/operations/{id}";
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
                Exception exception = ExceptionFactory("OperationsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperationApiResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OperationApiResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationApiResponseDto)));
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
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'amount' is set
            if (amount == null)
                throw new ApiException(400, "Missing required parameter 'amount' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling TransactionApi->OperationsWithdrawGet");

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
                throw new ApiException(400, "Missing required parameter 'psysCid' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'to' is set
            if (to == null)
                throw new ApiException(400, "Missing required parameter 'to' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'amount' is set
            if (amount == null)
                throw new ApiException(400, "Missing required parameter 'amount' when calling TransactionApi->OperationsWithdrawGet");
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling TransactionApi->OperationsWithdrawGet");

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

# IO.Plisio.Api.TransactionApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OperationsCommissionPsysCidGet**](TransactionApi.md#operationscommissionpsyscidget) | **GET** /operations/commission/{psys_cid} | Estimate cryptocurrency fee and Plisio commission
[**OperationsFeePlanPsysCidGet**](TransactionApi.md#operationsfeeplanpsyscidget) | **GET** /operations/fee-plan/{psys_cid} | Get Plisio fee plans
[**OperationsFeePsysCidGet**](TransactionApi.md#operationsfeepsyscidget) | **GET** /operations/fee/{psys_cid} | Estimate fee
[**OperationsGet**](TransactionApi.md#operationsget) | **GET** /operations | List of all user transactions
[**OperationsIdGet**](TransactionApi.md#operationsidget) | **GET** /operations/{id} | Transaction details
[**OperationsWithdrawGet**](TransactionApi.md#operationswithdrawget) | **GET** /operations/withdraw | Create new invoice

<a name="operationscommissionpsyscidget"></a>
# **OperationsCommissionPsysCidGet**
> CommissionApiResponseDto OperationsCommissionPsysCidGet (string psysCid, string addresses, string amounts, string type, string feePlan = null)

Estimate cryptocurrency fee and Plisio commission

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsCommissionPsysCidGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var psysCid = psysCid_example;  // string | ID column from one of the supported cryptocurrencies supported by Plisio
            var addresses = addresses_example;  // string | wallet address or comma separated addresses when estimating fee for mass withdrawal
            var amounts = amounts_example;  // string | amount or comma separated amount that will be send in case of mass withdraw
            var type = type_example;  // string | operation type
            var feePlan = feePlan_example;  // string | normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional) 

            try
            {
                // Estimate cryptocurrency fee and Plisio commission
                CommissionApiResponseDto result = apiInstance.OperationsCommissionPsysCidGet(psysCid, addresses, amounts, type, feePlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsCommissionPsysCidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psysCid** | **string**| ID column from one of the supported cryptocurrencies supported by Plisio | 
 **addresses** | **string**| wallet address or comma separated addresses when estimating fee for mass withdrawal | 
 **amounts** | **string**| amount or comma separated amount that will be send in case of mass withdraw | 
 **type** | **string**| operation type | 
 **feePlan** | **string**| normal or priority (https://plisio.net/documentation/endpoints/fee-plans) | [optional] 

### Return type

[**CommissionApiResponseDto**](CommissionApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="operationsfeeplanpsyscidget"></a>
# **OperationsFeePlanPsysCidGet**
> FeePlanApiResponseDto OperationsFeePlanPsysCidGet (string psysCid)

Get Plisio fee plans

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsFeePlanPsysCidGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var psysCid = psysCid_example;  // string | ID column from one of the supported cryptocurrencies supported by Plisio

            try
            {
                // Get Plisio fee plans
                FeePlanApiResponseDto result = apiInstance.OperationsFeePlanPsysCidGet(psysCid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsFeePlanPsysCidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psysCid** | **string**| ID column from one of the supported cryptocurrencies supported by Plisio | 

### Return type

[**FeePlanApiResponseDto**](FeePlanApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="operationsfeepsyscidget"></a>
# **OperationsFeePsysCidGet**
> FeeApiResponseDto OperationsFeePsysCidGet (string psysCid, string addresses, string amounts, string feePlan = null)

Estimate fee

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsFeePsysCidGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var psysCid = psysCid_example;  // string | ID column from one of the supported cryptocurrencies supported by Plisio
            var addresses = addresses_example;  // string | wallet address or comma separated addresses when estimating fee for mass withdrawal
            var amounts = amounts_example;  // string | amount or comma separated amount that will be send in case of mass withdraw
            var feePlan = feePlan_example;  // string | normal or priority (https://plisio.net/documentation/endpoints/fee-plans) (optional) 

            try
            {
                // Estimate fee
                FeeApiResponseDto result = apiInstance.OperationsFeePsysCidGet(psysCid, addresses, amounts, feePlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsFeePsysCidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psysCid** | **string**| ID column from one of the supported cryptocurrencies supported by Plisio | 
 **addresses** | **string**| wallet address or comma separated addresses when estimating fee for mass withdrawal | 
 **amounts** | **string**| amount or comma separated amount that will be send in case of mass withdraw | 
 **feePlan** | **string**| normal or priority (https://plisio.net/documentation/endpoints/fee-plans) | [optional] 

### Return type

[**FeeApiResponseDto**](FeeApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="operationsget"></a>
# **OperationsGet**
> OperationsApiResponseDto OperationsGet (int? page = null, int? limit = null, string shopId = null, string type = null, string status = null, string currency = null, string search = null)

List of all user transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var page = 56;  // int? | page number (optional) 
            var limit = 56;  // int? | number of elements on the page (optional) 
            var shopId = shopId_example;  // string | Filter operation by shop (optional) 
            var type = type_example;  // string | Transaction type (optional) 
            var status = status_example;  // string | Transaction status (optional) 
            var currency = currency_example;  // string | one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) (optional) 
            var search = search_example;  // string | text search by the transaction id (txid), invoice’s order number or customer email from invoice (optional) 

            try
            {
                // List of all user transactions
                OperationsApiResponseDto result = apiInstance.OperationsGet(page, limit, shopId, type, status, currency, search);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| page number | [optional] 
 **limit** | **int?**| number of elements on the page | [optional] 
 **shopId** | **string**| Filter operation by shop | [optional] 
 **type** | **string**| Transaction type | [optional] 
 **status** | **string**| Transaction status | [optional] 
 **currency** | **string**| one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) | [optional] 
 **search** | **string**| text search by the transaction id (txid), invoice’s order number or customer email from invoice | [optional] 

### Return type

[**OperationsApiResponseDto**](OperationsApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="operationsidget"></a>
# **OperationsIdGet**
> OperationApiResponseDto OperationsIdGet (string id)

Transaction details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var id = id_example;  // string | transactoion id

            try
            {
                // Transaction details
                OperationApiResponseDto result = apiInstance.OperationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| transactoion id | 

### Return type

[**OperationApiResponseDto**](OperationApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="operationswithdrawget"></a>
# **OperationsWithdrawGet**
> WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan = null)

Create new invoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class OperationsWithdrawGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new TransactionApi();
            var psysCid = psysCid_example;  // string | one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)
            var to = to_example;  // string | hash or multiple comma separated hashes pooled for the 'mass_cash_out'
            var amount = amount_example;  // string | any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter
            var type = type_example;  // string | 'cash_out' or 'mass_cash_out' to send to single or multiple comma separated hashes
            var feePlan = feePlan_example;  // string |  normal or priority (https://plisio.net/documentation/endpoints/fee-plan) (optional) 

            try
            {
                // Create new invoice
                WithdrawApiResponseDto result = apiInstance.OperationsWithdrawGet(psysCid, to, amount, type, feePlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionApi.OperationsWithdrawGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **psysCid** | **string**| one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) | 
 **to** | **string**| hash or multiple comma separated hashes pooled for the &#x27;mass_cash_out&#x27; | 
 **amount** | **string**| any comma separated float values for the “ mass_cash_out” in the order that hashes are in “to” parameter | 
 **type** | **string**| &#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; to send to single or multiple comma separated hashes | 
 **feePlan** | **string**|  normal or priority (https://plisio.net/documentation/endpoints/fee-plan) | [optional] 

### Return type

[**WithdrawApiResponseDto**](WithdrawApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# IO.Swagger.Api.WithdrawApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OperationsWithdrawGet**](WithdrawApi.md#operationswithdrawget) | **GET** /operations/withdraw | Create new invoice

<a name="operationswithdrawget"></a>
# **OperationsWithdrawGet**
> WithdrawApiResponseDto OperationsWithdrawGet (string psysCid, string to, string amount, string type, string feePlan)

Create new invoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Plisio.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OperationsWithdrawGetExample
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new WithdrawApi();
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
                Debug.Print("Exception when calling WithdrawApi.OperationsWithdrawGet: " + e.Message );
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


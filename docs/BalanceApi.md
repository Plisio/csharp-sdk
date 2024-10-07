# IO.Plisio.Api.BalanceApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BalancesPsysCidGet**](BalanceApi.md#balancespsyscidget) | **GET** /balances/{psys_cid} | Get cryptocurrency balance

<a name="balancespsyscidget"></a>
# **BalancesPsysCidGet**
> BalanceApiResponseDto BalancesPsysCidGet (string psysCid)

Get cryptocurrency balance

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class BalancesPsysCidGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new BalanceApi();
            var psysCid = psysCid_example;  // string | ID column from one of the supported cryptocurrencies supported by Plisio

            try
            {
                // Get cryptocurrency balance
                BalanceApiResponseDto result = apiInstance.BalancesPsysCidGet(psysCid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.BalancesPsysCidGet: " + e.Message );
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

[**BalanceApiResponseDto**](BalanceApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

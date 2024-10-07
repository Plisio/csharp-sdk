# IO.Plisio.Api.CurrenciesApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CurrenciesFiatGet**](CurrenciesApi.md#currenciesfiatget) | **GET** /currencies/{fiat} | List of supported cryptocurrencies

<a name="currenciesfiatget"></a>
# **CurrenciesFiatGet**
> CryptocurrencyApiResponseDto CurrenciesFiatGet (string fiat)

List of supported cryptocurrencies

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class CurrenciesFiatGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new CurrenciesApi();
            var fiat = fiat_example;  // string | one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies

            try
            {
                // List of supported cryptocurrencies
                CryptocurrencyApiResponseDto result = apiInstance.CurrenciesFiatGet(fiat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CurrenciesApi.CurrenciesFiatGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fiat** | **string**| one of the 168 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies | 

### Return type

[**CryptocurrencyApiResponseDto**](CryptocurrencyApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

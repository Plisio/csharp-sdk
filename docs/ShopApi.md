# IO.Plisio.Api.ShopApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShopsGet**](ShopApi.md#shopsget) | **GET** /shops | Get shop info by api_key

<a name="shopsget"></a>
# **ShopsGet**
> ShopResponseDto ShopsGet ()

Get shop info by api_key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class ShopsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ShopApi();

            try
            {
                // Get shop info by api_key
                ShopResponseDto result = apiInstance.ShopsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShopApi.ShopsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ShopResponseDto**](ShopResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

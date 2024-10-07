# IO.Swagger.Api.InvoiceApi

All URIs are relative to *https://plisio.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoicesEmailIdGet**](InvoiceApi.md#invoicesemailidget) | **GET** /invoices/email/{id} | Invoice details
[**InvoicesIdGet**](InvoiceApi.md#invoicesidget) | **GET** /invoices/{id} | Invoice details
[**InvoicesNewGet**](InvoiceApi.md#invoicesnewget) | **GET** /invoices/new | Create new invoice
[**InvoicesSwitchIdGet**](InvoiceApi.md#invoicesswitchidget) | **GET** /invoices/switch/{id} | Invoice details

<a name="invoicesemailidget"></a>
# **InvoicesEmailIdGet**
> InvoiceDetailsApiResponseDto InvoicesEmailIdGet (string id, string email)

Invoice details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Plisio.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesEmailIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | invoice id
            var email = email_example;  // string | payer's email

            try
            {
                // Invoice details
                InvoiceDetailsApiResponseDto result = apiInstance.InvoicesEmailIdGet(id, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicesEmailIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| invoice id | 
 **email** | **string**| payer&#x27;s email | 

### Return type

[**InvoiceDetailsApiResponseDto**](InvoiceDetailsApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesidget"></a>
# **InvoicesIdGet**
> InvoiceDetailsApiResponseDto InvoicesIdGet (string id)

Invoice details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Plisio.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | invoice id

            try
            {
                // Invoice details
                InvoiceDetailsApiResponseDto result = apiInstance.InvoicesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| invoice id | 

### Return type

[**InvoiceDetailsApiResponseDto**](InvoiceDetailsApiResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesnewget"></a>
# **InvoicesNewGet**
> InvoiceWhiteLabelResponseDto InvoicesNewGet (string currency, string orderName, string orderNumber, string amount, string sourceCurrency, string sourceAmount, string allowedPsysCids, string description, string callbackUrl, string email, string language, string plugin, string version, bool? redirectToInvoice, string expireMin)

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
    public class InvoicesNewGetExample
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new InvoiceApi();
            var currency = currency_example;  // string | one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies)
            var orderName = orderName_example;  // string | merchant internal order name
            var orderNumber = orderNumber_example;  // string | merchant internal order number. Must be unique number in your store for each new store`s order!!!
            var amount = amount_example;  // string | any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead (optional) 
            var sourceCurrency = sourceCurrency_example;  // string | one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies (optional) 
            var sourceAmount = sourceAmount_example;  // string | any float value (optional) 
            var allowedPsysCids = allowedPsysCids_example;  // string | comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC (optional) 
            var description = description_example;  // string | merchant invoice description (optional) 
            var callbackUrl = callbackUrl_example;  // string | merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field (optional) 
            var email = email_example;  // string | an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent (optional) 
            var language = language_example;  // string | en_US (we support EN language only) (optional) 
            var plugin = plugin_example;  // string | Plisio’s internal field to determine integration plugin (optional) 
            var version = version_example;  // string | Plisio’s internal field to determine integration plugin version  (optional) 
            var redirectToInvoice = true;  // bool? | Instead of JSON response user will be redirected to the Plisio's invoice page (is not working for a white-label shop) (optional) 
            var expireMin = expireMin_example;  // string | Interval in minutes when invoice will be expired (optional) 

            try
            {
                // Create new invoice
                InvoiceWhiteLabelResponseDto result = apiInstance.InvoicesNewGet(currency, orderName, orderNumber, amount, sourceCurrency, sourceAmount, allowedPsysCids, description, callbackUrl, email, language, plugin, version, redirectToInvoice, expireMin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicesNewGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| one of the cryptocurrencies supported by Plisio (ID column from supported cryptocurrencies https://plisio.net/documentation/appendices/supported-cryptocurrencies) | 
 **orderName** | **string**| merchant internal order name | 
 **orderNumber** | **string**| merchant internal order number. Must be unique number in your store for each new store&#x60;s order!!! | 
 **amount** | **string**| any cryptocurrency float value. !!! Please, skip this field If you want to convert a fiat currency and use source_currency and source_amount fields instead | [optional] 
 **sourceCurrency** | **string**| one of the 167 fiat currencies https://plisio.net/documentation/appendices/supported-fiat-currencies | [optional] 
 **sourceAmount** | **string**| any float value | [optional] 
 **allowedPsysCids** | **string**| comma-separated list of cryptocurrencies that allowed for payment. Customer will be able to select one of them. Example: BTC,ETH,TZEC | [optional] 
 **description** | **string**| merchant invoice description | [optional] 
 **callbackUrl** | **string**| merchant full URL to get invoice updates. The “POST” request will be sent to this URL (example). If this parameter isn’t set, Plisio will send a callback to URL that can be set under profile API » API settings » ”Status URL” field | [optional] 
 **email** | **string**| an auto-fill invoice email. The customer will be asked to insert their email where a notification will be sent | [optional] 
 **language** | **string**| en_US (we support EN language only) | [optional] 
 **plugin** | **string**| Plisio’s internal field to determine integration plugin | [optional] 
 **version** | **string**| Plisio’s internal field to determine integration plugin version  | [optional] 
 **redirectToInvoice** | **bool?**| Instead of JSON response user will be redirected to the Plisio&#x27;s invoice page (is not working for a white-label shop) | [optional] 
 **expireMin** | **string**| Interval in minutes when invoice will be expired | [optional] 

### Return type

[**InvoiceWhiteLabelResponseDto**](InvoiceWhiteLabelResponseDto.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesswitchidget"></a>
# **InvoicesSwitchIdGet**
> InvoiceDetailsApiResponseDto InvoicesSwitchIdGet (string id, string psysCid)

Invoice details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Plisio.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesSwitchIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: view_key
            Configuration.Default.ApiKey.Add("view_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("view_key", "Bearer");

            var apiInstance = new InvoiceApi();
            var id = id_example;  // string | invoice id
            var psysCid = psysCid_example;  // string | destination cryptocurrency id

            try
            {
                // Invoice details
                InvoiceDetailsApiResponseDto result = apiInstance.InvoicesSwitchIdGet(id, psysCid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoiceApi.InvoicesSwitchIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| invoice id | 
 **psysCid** | **string**| destination cryptocurrency id | 

### Return type

[**InvoiceDetailsApiResponseDto**](InvoiceDetailsApiResponseDto.md)

### Authorization

[view_key](../README.md#view_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


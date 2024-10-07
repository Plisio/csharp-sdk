# Plisio C# API SDK

Plisio payment gateway API

- API version: 1.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.7.1 or later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 111.4.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation

Run the following commands to generate the DLL
```
cd src/IO.Plisio
dotnet restore
dotnet build
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Plisio.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://plisio.net/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BalanceApi* | [**BalancesPsysCidGet**](docs/BalanceApi.md#balancespsyscidget) | **GET** /balances/{psys_cid} | Get cryptocurrency balance
*CurrenciesApi* | [**CurrenciesFiatGet**](docs/CurrenciesApi.md#currenciesfiatget) | **GET** /currencies/{fiat} | List of supported cryptocurrencies
*InvoiceApi* | [**InvoicesEmailIdGet**](docs/InvoiceApi.md#invoicesemailidget) | **GET** /invoices/email/{id} | Invoice details
*InvoiceApi* | [**InvoicesIdGet**](docs/InvoiceApi.md#invoicesidget) | **GET** /invoices/{id} | Invoice details
*InvoiceApi* | [**InvoicesNewGet**](docs/InvoiceApi.md#invoicesnewget) | **GET** /invoices/new | Create new invoice
*InvoiceApi* | [**InvoicesSwitchIdGet**](docs/InvoiceApi.md#invoicesswitchidget) | **GET** /invoices/switch/{id} | Invoice details
*ShopApi* | [**ShopsGet**](docs/ShopApi.md#shopsget) | **GET** /shops | Get shop info by api_key
*TransactionApi* | [**OperationsCommissionPsysCidGet**](docs/TransactionApi.md#operationscommissionpsyscidget) | **GET** /operations/commission/{psys_cid} | Estimate cryptocurrency fee and Plisio commission
*TransactionApi* | [**OperationsFeePlanPsysCidGet**](docs/TransactionApi.md#operationsfeeplanpsyscidget) | **GET** /operations/fee-plan/{psys_cid} | Get Plisio fee plans
*TransactionApi* | [**OperationsFeePsysCidGet**](docs/TransactionApi.md#operationsfeepsyscidget) | **GET** /operations/fee/{psys_cid} | Estimate fee
*TransactionApi* | [**OperationsGet**](docs/TransactionApi.md#operationsget) | **GET** /operations | List of all user transactions
*TransactionApi* | [**OperationsIdGet**](docs/TransactionApi.md#operationsidget) | **GET** /operations/{id} | Transaction details
*TransactionApi* | [**OperationsWithdrawGet**](docs/TransactionApi.md#operationswithdrawget) | **GET** /operations/withdraw | Create new invoice
*WithdrawApi* | [**OperationsWithdrawGet**](docs/WithdrawApi.md#operationswithdrawget) | **GET** /operations/withdraw | Create new invoice

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BalanceApiResponseDto](docs/BalanceApiResponseDto.md)
 - [Model.BalanceResponseDto](docs/BalanceResponseDto.md)
 - [Model.CommissionApiResponseDto](docs/CommissionApiResponseDto.md)
 - [Model.CommissionResponseBoostDto](docs/CommissionResponseBoostDto.md)
 - [Model.CommissionResponseDto](docs/CommissionResponseDto.md)
 - [Model.CommissionResponseSimpleDto](docs/CommissionResponseSimpleDto.md)
 - [Model.CommissionResponseSimpleErrorDto](docs/CommissionResponseSimpleErrorDto.md)
 - [Model.CryptocurrencyApiResponseDto](docs/CryptocurrencyApiResponseDto.md)
 - [Model.DonateBlockDto](docs/DonateBlockDto.md)
 - [Model.DonateDto](docs/DonateDto.md)
 - [Model.ErrorDto](docs/ErrorDto.md)
 - [Model.ErrorResponseDto](docs/ErrorResponseDto.md)
 - [Model.FeeApiResponseDto](docs/FeeApiResponseDto.md)
 - [Model.FeeParamsDto](docs/FeeParamsDto.md)
 - [Model.FeePlanApiResponseDto](docs/FeePlanApiResponseDto.md)
 - [Model.FeePlanBtcDto](docs/FeePlanBtcDto.md)
 - [Model.FeePlanCommonDto](docs/FeePlanCommonDto.md)
 - [Model.FeePlanCustomDto](docs/FeePlanCustomDto.md)
 - [Model.FeePlanDto](docs/FeePlanDto.md)
 - [Model.FeePlanEthDto](docs/FeePlanEthDto.md)
 - [Model.FeePlanLimitsBtcDto](docs/FeePlanLimitsBtcDto.md)
 - [Model.FeePlanLimitsEthDto](docs/FeePlanLimitsEthDto.md)
 - [Model.FeePlanTonDto](docs/FeePlanTonDto.md)
 - [Model.FeePlanTrxDto](docs/FeePlanTrxDto.md)
 - [Model.FeePlanXmrDto](docs/FeePlanXmrDto.md)
 - [Model.FeeResponseDto](docs/FeeResponseDto.md)
 - [Model.FeeSimplePlanDto](docs/FeeSimplePlanDto.md)
 - [Model.FeeSimplePlanItemDto](docs/FeeSimplePlanItemDto.md)
 - [Model.HateoasLinkDto](docs/HateoasLinkDto.md)
 - [Model.HateoasLinksDto](docs/HateoasLinksDto.md)
 - [Model.HateoasMetaDto](docs/HateoasMetaDto.md)
 - [Model.InvoiceCallbackExtendedResponseDto](docs/InvoiceCallbackExtendedResponseDto.md)
 - [Model.InvoiceDetailsApiResponseDto](docs/InvoiceDetailsApiResponseDto.md)
 - [Model.InvoiceDetailsResponseDto](docs/InvoiceDetailsResponseDto.md)
 - [Model.InvoiceExtendedResponseDto](docs/InvoiceExtendedResponseDto.md)
 - [Model.InvoiceFormResponseDto](docs/InvoiceFormResponseDto.md)
 - [Model.InvoicePaysysContractsGroupDto](docs/InvoicePaysysContractsGroupDto.md)
 - [Model.InvoicePaysysDto](docs/InvoicePaysysDto.md)
 - [Model.InvoiceResponseDto](docs/InvoiceResponseDto.md)
 - [Model.InvoiceSimpleResponseDto](docs/InvoiceSimpleResponseDto.md)
 - [Model.InvoiceSwitchApiResponseDto](docs/InvoiceSwitchApiResponseDto.md)
 - [Model.InvoiceUpdateEmailApiResponseDto](docs/InvoiceUpdateEmailApiResponseDto.md)
 - [Model.InvoiceUpdateEmailResponseDto](docs/InvoiceUpdateEmailResponseDto.md)
 - [Model.InvoiceWhiteLabelResponseDto](docs/InvoiceWhiteLabelResponseDto.md)
 - [Model.OperationApiResponseDto](docs/OperationApiResponseDto.md)
 - [Model.OperationDto](docs/OperationDto.md)
 - [Model.OperationParamsDto](docs/OperationParamsDto.md)
 - [Model.OperationSimpleDto](docs/OperationSimpleDto.md)
 - [Model.OperationsApiResponseDto](docs/OperationsApiResponseDto.md)
 - [Model.OperationsHateoasResponseDto](docs/OperationsHateoasResponseDto.md)
 - [Model.PaysysDto](docs/PaysysDto.md)
 - [Model.ShopDto](docs/ShopDto.md)
 - [Model.ShopInfoDto](docs/ShopInfoDto.md)
 - [Model.ShopResponseDto](docs/ShopResponseDto.md)
 - [Model.SuccessResponseDto](docs/SuccessResponseDto.md)
 - [Model.WithdrawApiResponseDto](docs/WithdrawApiResponseDto.md)
 - [Model.WithdrawResponseDto](docs/WithdrawResponseDto.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string

<a name="view_key"></a>
### view_key

- **Type**: API key
- **API key parameter name**: view_key
- **Location**: URL query string


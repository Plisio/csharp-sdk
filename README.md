# IO.Plisio - the C# library for the Plisio API

Plisio payment gateway API

- API version: 1.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Plisio.Api;
using IO.Plisio.Client;
using IO.Plisio.Model;
```
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

 - [IO.Plisio.Model.BalanceApiResponseDto](docs/BalanceApiResponseDto.md)
 - [IO.Plisio.Model.BalanceResponseDto](docs/BalanceResponseDto.md)
 - [IO.Plisio.Model.CommissionApiResponseDto](docs/CommissionApiResponseDto.md)
 - [IO.Plisio.Model.CommissionResponseBoostDto](docs/CommissionResponseBoostDto.md)
 - [IO.Plisio.Model.CommissionResponseDto](docs/CommissionResponseDto.md)
 - [IO.Plisio.Model.CommissionResponseSimpleDto](docs/CommissionResponseSimpleDto.md)
 - [IO.Plisio.Model.CommissionResponseSimpleErrorDto](docs/CommissionResponseSimpleErrorDto.md)
 - [IO.Plisio.Model.CryptocurrencyApiResponseDto](docs/CryptocurrencyApiResponseDto.md)
 - [IO.Plisio.Model.DonateBlockDto](docs/DonateBlockDto.md)
 - [IO.Plisio.Model.DonateDto](docs/DonateDto.md)
 - [IO.Plisio.Model.ErrorDto](docs/ErrorDto.md)
 - [IO.Plisio.Model.ErrorResponseDto](docs/ErrorResponseDto.md)
 - [IO.Plisio.Model.FeeApiResponseDto](docs/FeeApiResponseDto.md)
 - [IO.Plisio.Model.FeeParamsDto](docs/FeeParamsDto.md)
 - [IO.Plisio.Model.FeePlanApiResponseDto](docs/FeePlanApiResponseDto.md)
 - [IO.Plisio.Model.FeePlanBtcDto](docs/FeePlanBtcDto.md)
 - [IO.Plisio.Model.FeePlanCommonDto](docs/FeePlanCommonDto.md)
 - [IO.Plisio.Model.FeePlanCustomDto](docs/FeePlanCustomDto.md)
 - [IO.Plisio.Model.FeePlanDto](docs/FeePlanDto.md)
 - [IO.Plisio.Model.FeePlanEthDto](docs/FeePlanEthDto.md)
 - [IO.Plisio.Model.FeePlanLimitsBtcDto](docs/FeePlanLimitsBtcDto.md)
 - [IO.Plisio.Model.FeePlanLimitsEthDto](docs/FeePlanLimitsEthDto.md)
 - [IO.Plisio.Model.FeePlanTonDto](docs/FeePlanTonDto.md)
 - [IO.Plisio.Model.FeePlanTrxDto](docs/FeePlanTrxDto.md)
 - [IO.Plisio.Model.FeePlanXmrDto](docs/FeePlanXmrDto.md)
 - [IO.Plisio.Model.FeeResponseDto](docs/FeeResponseDto.md)
 - [IO.Plisio.Model.FeeSimplePlanDto](docs/FeeSimplePlanDto.md)
 - [IO.Plisio.Model.FeeSimplePlanItemDto](docs/FeeSimplePlanItemDto.md)
 - [IO.Plisio.Model.HateoasLinkDto](docs/HateoasLinkDto.md)
 - [IO.Plisio.Model.HateoasLinksDto](docs/HateoasLinksDto.md)
 - [IO.Plisio.Model.HateoasMetaDto](docs/HateoasMetaDto.md)
 - [IO.Plisio.Model.InvoiceCallbackExtendedResponseDto](docs/InvoiceCallbackExtendedResponseDto.md)
 - [IO.Plisio.Model.InvoiceDetailsApiResponseDto](docs/InvoiceDetailsApiResponseDto.md)
 - [IO.Plisio.Model.InvoiceDetailsResponseDto](docs/InvoiceDetailsResponseDto.md)
 - [IO.Plisio.Model.InvoiceExtendedResponseDto](docs/InvoiceExtendedResponseDto.md)
 - [IO.Plisio.Model.InvoiceFormResponseDto](docs/InvoiceFormResponseDto.md)
 - [IO.Plisio.Model.InvoicePaysysContractsGroupDto](docs/InvoicePaysysContractsGroupDto.md)
 - [IO.Plisio.Model.InvoicePaysysDto](docs/InvoicePaysysDto.md)
 - [IO.Plisio.Model.InvoiceResponseDto](docs/InvoiceResponseDto.md)
 - [IO.Plisio.Model.InvoiceSimpleResponseDto](docs/InvoiceSimpleResponseDto.md)
 - [IO.Plisio.Model.InvoiceSwitchApiResponseDto](docs/InvoiceSwitchApiResponseDto.md)
 - [IO.Plisio.Model.InvoiceUpdateEmailApiResponseDto](docs/InvoiceUpdateEmailApiResponseDto.md)
 - [IO.Plisio.Model.InvoiceUpdateEmailResponseDto](docs/InvoiceUpdateEmailResponseDto.md)
 - [IO.Plisio.Model.InvoiceWhiteLabelResponseDto](docs/InvoiceWhiteLabelResponseDto.md)
 - [IO.Plisio.Model.OperationApiResponseDto](docs/OperationApiResponseDto.md)
 - [IO.Plisio.Model.OperationDto](docs/OperationDto.md)
 - [IO.Plisio.Model.OperationParamsDto](docs/OperationParamsDto.md)
 - [IO.Plisio.Model.OperationSimpleDto](docs/OperationSimpleDto.md)
 - [IO.Plisio.Model.OperationsApiResponseDto](docs/OperationsApiResponseDto.md)
 - [IO.Plisio.Model.OperationsHateoasResponseDto](docs/OperationsHateoasResponseDto.md)
 - [IO.Plisio.Model.PaysysDto](docs/PaysysDto.md)
 - [IO.Plisio.Model.ShopDto](docs/ShopDto.md)
 - [IO.Plisio.Model.ShopInfoDto](docs/ShopInfoDto.md)
 - [IO.Plisio.Model.ShopResponseDto](docs/ShopResponseDto.md)
 - [IO.Plisio.Model.SuccessResponseDto](docs/SuccessResponseDto.md)
 - [IO.Plisio.Model.WithdrawApiResponseDto](docs/WithdrawApiResponseDto.md)
 - [IO.Plisio.Model.WithdrawResponseDto](docs/WithdrawResponseDto.md)

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


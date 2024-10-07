# IO.Swagger.Model.InvoiceCallbackExtendedResponseDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Invoice amount in the selected cryptocurrency | [optional] 
**PendingAmount** | **string** | Remained amount in the selected cryptocurrency | [optional] 
**WalletHash** | **string** | Invoice hash | [optional] 
**PsysCid** | **string** | ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**Currency** | **string** | Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**SourceCurrency** | **string** | Fiat currency - only USD available for the moment | [optional] 
**SourceRate** | **string** | Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer | [optional] 
**ExpectedConfirmations** | **string** | How many confirmations expected to mark invoice completed | [optional] 
**QrCode** | **string** | QR code image in base64 format | [optional] 
**VerifyHash** | **string** | Hash to verify the “POST” data signed with your SHOP_API_KEY | [optional] 
**InvoiceCommission** | **string** | Plisio commission | [optional] 
**InvoiceSum** | **string** | shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount | [optional] 
**InvoiceTotalSum** | **string** | shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.InvoiceExtendedResponseDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Plisio’s intertnal ID (copy of txn_id) | [optional] 
**Amount** | **string** | Invoice amount in the selected cryptocurrency | [optional] 
**ReceivedAmount** | **string** | Received and approved amount in the selected cryptocurrency | [optional] 
**PendingAmount** | **string** | Pending (not approve) amount in the selected cryptocurrency | [optional] 
**RemainingAmount** | **string** | Remaining amount in the selected cryptocurrency | [optional] 
**WalletHash** | **string** | Invoice hash | [optional] 
**PsysCid** | **string** | ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**Currency** | **string** | Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**SourceCurrency** | **string** | Fiat currency - only USD available for the moment | [optional] 
**SourceRate** | **string** | Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer | [optional] 
**ExpectedConfirmations** | **string** | How many confirmations expected to mark invoice completed | [optional] 
**InvoiceCommission** | **string** | Plisio commission | [optional] 
**InvoiceSum** | **string** | shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount | [optional] 
**InvoiceTotalSum** | **string** | shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum | [optional] 
**EmailAlreadySet** | **bool?** | If email has been set | [optional] 
**TxUrl** | **string** | link to the cryptocurrency block explorer | [optional] 
**TxId** | **List&lt;string&gt;** | array of transaction ids | [optional] 
**SwitchId** | **string** | Initial invoice ID | [optional] 
**PaidId** | **string** | ID of invoice that has money | [optional] 
**_Params** | [**OperationParamsDto**](OperationParamsDto.md) |  | [optional] 
**ViewKey** | **string** | invoice read-only view key | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


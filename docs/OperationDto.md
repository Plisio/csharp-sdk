# IO.Swagger.Model.OperationDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | Profile ID | [optional] 
**ShopId** | **string** | Shop ID | [optional] 
**Type** | **string** | cash_in, cash_out, mass_cash_out, invoice | [optional] 
**Status** | **string** | pending, completed, error, new, expired, mismatch, cancelled | [optional] 
**PendingSum** | **string** | unconfirmed amount (mempool) | [optional] 
**PsysCid** | **string** | ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**Currency** | **string** | Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**SourceCurrency** | **string** | fiat currency - USD by default or source_currency was set | [optional] 
**SourceRate** | **string** | Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer | [optional] 
**Fee** | **string** | transaction fee stated in the transfer | [optional] 
**WalletHash** | **string** | destination hash (type&#x3D;cash_out) or invoice hash | [optional] 
**Sendmany** | **List&lt;string&gt;** | Pairs of hashes and values (type&#x3D;mass_cash_out) | [optional] 
**_Params** | [**OperationParamsDto**](OperationParamsDto.md) |  | [optional] 
**ExpireAtUtc** | **int?** | timestamp in UTC timezone; it may need to be divided by 1000 | [optional] 
**CreatedAtUtc** | **int?** | timestamp in the UTC timezone; it may need to be divided by 1000 | [optional] 
**Amount** | **string** | amount received/transferred by an operation (invoice, cash-in/cash-out) | [optional] 
**Sum** | **string** | Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount | [optional] 
**Commission** | **string** | Plisio commission | [optional] 
**TxUrl** | **string** | link to the cryptocurrency block explorer | [optional] 
**TxId** | **List&lt;string&gt;** | array of transaction ids | [optional] 
**Id** | **string** | internal Plisio operation ID | [optional] 
**ActualSum** | **string** | Real incoming amount | [optional] 
**ActualCommission** | **string** | Plisio commission taken | [optional] 
**ActualFee** | **string** | Network fee (move invoice to wallet) | [optional] 
**ActualInvoiceSum** | **string** | actual_sum - actual_commis_sim - actual_fee | [optional] 
**Tx** | **List&lt;Object&gt;** | array of transaction payment items | [optional] 
**Confirmations** | **int?** | Number of confirmations of this transaction. We don&#x27;t update confirmation after operation is confirmed | [optional] 
**StatusCode** | **int?** | Status code | [optional] 
**ParentId** | **string** | ID of parent invoice | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Plisio.Model.WithdrawResponseDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | &#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; depending on the request | [optional] 
**Status** | **string** | Cash-out status &#x27;competed&#x27;, &#x27;error&#x27; | [optional] 
**PsysCid** | **string** | ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**Currency** | **string** | Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies | [optional] 
**SourceCurrency** | **string** | Fiat currency - only USD available for the moment | [optional] 
**SourceRate** | **string** | Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer | [optional] 
**Fee** | **string** | Transaction fee stated in the transfer | [optional] 
**WalletHash** | **string** | Destination hash (type&#x3D;cash_out) | [optional] 
**Sendmany** | **List&lt;string&gt;** | Pairs of hashes and values (type&#x3D;mass_cash_out) | [optional] 
**_Params** | [**FeeParamsDto**](FeeParamsDto.md) |  | [optional] 
**CreatedAtUtc** | **int?** | timestamp in the UTC timezone; it may need to be divided by 1000 | [optional] 
**Amount** | **string** | transfer amount in cryptocurrency | [optional] 
**TxUrl** | **string** | link to the cryptocurrency block explorer | [optional] 
**TxId** | **List&lt;string&gt;** | array of transaction ids | [optional] 
**Id** | **string** | internal Plisio operation ID | [optional] 
**TxnId** | **string** | internal Plisio operation ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


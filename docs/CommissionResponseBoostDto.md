# IO.Plisio.Model.CommissionResponseBoostDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commission** | **string** | Plisio commission value | [optional] 
**Fee** | **string** | Cryptocurrency fee value | [optional] 
**FeeUnit** | **string** | Cryptocurrency feeUnit value | [optional] 
**FeeFiat** | **string** | Cryptocurrency fee value in selected fiat currency | [optional] 
**FeeFiatUnit** | **string** | Selected fiat currency | [optional] 
**MaxAmount** | **string** | Maximum allowed amount to withdrawal | [optional] 
**Plan** | **string** | Plisio&#x27;s cryptocurrency fee estimation plan | [optional] 
**UseWallet** | **string** | Pay fee from wallet | [optional] 
**UseWalletBalance** | **string** | Balance of wallet that will be used to pay fee | [optional] 
**Plans** | [**FeeSimplePlanDto**](FeeSimplePlanDto.md) |  | [optional] 
**Custom** | [**List&lt;FeePlanCustomDto&gt;**](FeePlanCustomDto.md) | Cryptocurrency fee limits | [optional] 
**Errors** | [**List&lt;CommissionResponseSimpleErrorDto&gt;**](CommissionResponseSimpleErrorDto.md) |  | [optional] 
**CustomFeeRate** | **float?** |  | [optional] 
**MinFeeRate** | **float?** | Minimal fee rate for boost | [optional] 
**MaxFeeRate** | **float?** | Maximum fee rate for boost | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


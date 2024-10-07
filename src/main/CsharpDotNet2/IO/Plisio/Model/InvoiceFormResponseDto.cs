using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InvoiceFormResponseDto : InvoiceSimpleResponseDto {
    /// <summary>
    /// Plisio’s intertnal ID (copy of txn_id)
    /// </summary>
    /// <value>Plisio’s intertnal ID (copy of txn_id)</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Invoice amount in the selected cryptocurrency
    /// </summary>
    /// <value>Invoice amount in the selected cryptocurrency</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Received and approved amount in the selected cryptocurrency
    /// </summary>
    /// <value>Received and approved amount in the selected cryptocurrency</value>
    [DataMember(Name="received_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "received_amount")]
    public string ReceivedAmount { get; set; }

    /// <summary>
    /// Pending (not approve) amount in the selected cryptocurrency
    /// </summary>
    /// <value>Pending (not approve) amount in the selected cryptocurrency</value>
    [DataMember(Name="pending_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_amount")]
    public string PendingAmount { get; set; }

    /// <summary>
    /// Remaining amount in the selected cryptocurrency
    /// </summary>
    /// <value>Remaining amount in the selected cryptocurrency</value>
    [DataMember(Name="remaining_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remaining_amount")]
    public string RemainingAmount { get; set; }

    /// <summary>
    /// Invoice hash
    /// </summary>
    /// <value>Invoice hash</value>
    [DataMember(Name="wallet_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_hash")]
    public string WalletHash { get; set; }

    /// <summary>
    /// ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
    /// </summary>
    /// <value>ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
    [DataMember(Name="psys_cid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "psys_cid")]
    public string PsysCid { get; set; }

    /// <summary>
    /// Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
    /// </summary>
    /// <value>Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Fiat currency - only USD available for the moment
    /// </summary>
    /// <value>Fiat currency - only USD available for the moment</value>
    [DataMember(Name="source_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_currency")]
    public string SourceCurrency { get; set; }

    /// <summary>
    /// Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer
    /// </summary>
    /// <value>Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer</value>
    [DataMember(Name="source_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_rate")]
    public string SourceRate { get; set; }

    /// <summary>
    /// How many confirmations expected to mark invoice completed
    /// </summary>
    /// <value>How many confirmations expected to mark invoice completed</value>
    [DataMember(Name="expected_confirmations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_confirmations")]
    public string ExpectedConfirmations { get; set; }

    /// <summary>
    /// Plisio commission
    /// </summary>
    /// <value>Plisio commission</value>
    [DataMember(Name="invoice_commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_commission")]
    public string InvoiceCommission { get; set; }

    /// <summary>
    /// shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount
    /// </summary>
    /// <value>shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount</value>
    [DataMember(Name="invoice_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_sum")]
    public string InvoiceSum { get; set; }

    /// <summary>
    /// shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum
    /// </summary>
    /// <value>shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum</value>
    [DataMember(Name="invoice_total_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_total_sum")]
    public string InvoiceTotalSum { get; set; }

    /// <summary>
    /// If email has been set
    /// </summary>
    /// <value>If email has been set</value>
    [DataMember(Name="email_already_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_already_set")]
    public bool? EmailAlreadySet { get; set; }

    /// <summary>
    /// link to the cryptocurrency block explorer
    /// </summary>
    /// <value>link to the cryptocurrency block explorer</value>
    [DataMember(Name="tx_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tx_url")]
    public string TxUrl { get; set; }

    /// <summary>
    /// array of transaction ids
    /// </summary>
    /// <value>array of transaction ids</value>
    [DataMember(Name="tx_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tx_id")]
    public List<string> TxId { get; set; }

    /// <summary>
    /// Initial invoice ID
    /// </summary>
    /// <value>Initial invoice ID</value>
    [DataMember(Name="switch_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "switch_id")]
    public string SwitchId { get; set; }

    /// <summary>
    /// ID of invoice that has money
    /// </summary>
    /// <value>ID of invoice that has money</value>
    [DataMember(Name="paid_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paid_id")]
    public string PaidId { get; set; }

    /// <summary>
    /// Gets or Sets _Params
    /// </summary>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public OperationParamsDto _Params { get; set; }

    /// <summary>
    /// Donation hash
    /// </summary>
    /// <value>Donation hash</value>
    [DataMember(Name="donate_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "donate_hash")]
    public string DonateHash { get; set; }

    /// <summary>
    /// Invoice return url
    /// </summary>
    /// <value>Invoice return url</value>
    [DataMember(Name="return_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_url")]
    public string ReturnUrl { get; set; }

    /// <summary>
    /// True when psys_cid not in supported by shop
    /// </summary>
    /// <value>True when psys_cid not in supported by shop</value>
    [DataMember(Name="psys_cid_unsupported", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "psys_cid_unsupported")]
    public bool? PsysCidUnsupported { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceFormResponseDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  ReceivedAmount: ").Append(ReceivedAmount).Append("\n");
      sb.Append("  PendingAmount: ").Append(PendingAmount).Append("\n");
      sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
      sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
      sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
      sb.Append("  ExpectedConfirmations: ").Append(ExpectedConfirmations).Append("\n");
      sb.Append("  InvoiceCommission: ").Append(InvoiceCommission).Append("\n");
      sb.Append("  InvoiceSum: ").Append(InvoiceSum).Append("\n");
      sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
      sb.Append("  EmailAlreadySet: ").Append(EmailAlreadySet).Append("\n");
      sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
      sb.Append("  TxId: ").Append(TxId).Append("\n");
      sb.Append("  SwitchId: ").Append(SwitchId).Append("\n");
      sb.Append("  PaidId: ").Append(PaidId).Append("\n");
      sb.Append("  _Params: ").Append(_Params).Append("\n");
      sb.Append("  DonateHash: ").Append(DonateHash).Append("\n");
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
      sb.Append("  PsysCidUnsupported: ").Append(PsysCidUnsupported).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

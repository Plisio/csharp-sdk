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
  public class InvoiceCallbackExtendedResponseDto : InvoiceExtendedResponseDto {
    /// <summary>
    /// Invoice amount in the selected cryptocurrency
    /// </summary>
    /// <value>Invoice amount in the selected cryptocurrency</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Remained amount in the selected cryptocurrency
    /// </summary>
    /// <value>Remained amount in the selected cryptocurrency</value>
    [DataMember(Name="pending_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_amount")]
    public string PendingAmount { get; set; }

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
    /// QR code image in base64 format
    /// </summary>
    /// <value>QR code image in base64 format</value>
    [DataMember(Name="qr_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qr_code")]
    public string QrCode { get; set; }

    /// <summary>
    /// Hash to verify the “POST” data signed with your SHOP_API_KEY
    /// </summary>
    /// <value>Hash to verify the “POST” data signed with your SHOP_API_KEY</value>
    [DataMember(Name="verify_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verify_hash")]
    public string VerifyHash { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceCallbackExtendedResponseDto {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  PendingAmount: ").Append(PendingAmount).Append("\n");
      sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
      sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
      sb.Append("  ExpectedConfirmations: ").Append(ExpectedConfirmations).Append("\n");
      sb.Append("  QrCode: ").Append(QrCode).Append("\n");
      sb.Append("  VerifyHash: ").Append(VerifyHash).Append("\n");
      sb.Append("  InvoiceCommission: ").Append(InvoiceCommission).Append("\n");
      sb.Append("  InvoiceSum: ").Append(InvoiceSum).Append("\n");
      sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
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

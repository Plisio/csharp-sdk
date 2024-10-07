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
  public class OperationDto {
    /// <summary>
    /// Profile ID
    /// </summary>
    /// <value>Profile ID</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// Shop ID
    /// </summary>
    /// <value>Shop ID</value>
    [DataMember(Name="shop_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop_id")]
    public string ShopId { get; set; }

    /// <summary>
    /// cash_in, cash_out, mass_cash_out, invoice
    /// </summary>
    /// <value>cash_in, cash_out, mass_cash_out, invoice</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// pending, completed, error, new, expired, mismatch, cancelled
    /// </summary>
    /// <value>pending, completed, error, new, expired, mismatch, cancelled</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// unconfirmed amount (mempool)
    /// </summary>
    /// <value>unconfirmed amount (mempool)</value>
    [DataMember(Name="pending_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_sum")]
    public string PendingSum { get; set; }

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
    /// fiat currency - USD by default or source_currency was set
    /// </summary>
    /// <value>fiat currency - USD by default or source_currency was set</value>
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
    /// transaction fee stated in the transfer
    /// </summary>
    /// <value>transaction fee stated in the transfer</value>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public string Fee { get; set; }

    /// <summary>
    /// destination hash (type=cash_out) or invoice hash
    /// </summary>
    /// <value>destination hash (type=cash_out) or invoice hash</value>
    [DataMember(Name="wallet_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet_hash")]
    public string WalletHash { get; set; }

    /// <summary>
    /// Pairs of hashes and values (type=mass_cash_out)
    /// </summary>
    /// <value>Pairs of hashes and values (type=mass_cash_out)</value>
    [DataMember(Name="sendmany", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendmany")]
    public List<string> Sendmany { get; set; }

    /// <summary>
    /// Gets or Sets _Params
    /// </summary>
    [DataMember(Name="params", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "params")]
    public OperationParamsDto _Params { get; set; }

    /// <summary>
    /// timestamp in UTC timezone; it may need to be divided by 1000
    /// </summary>
    /// <value>timestamp in UTC timezone; it may need to be divided by 1000</value>
    [DataMember(Name="expire_at_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expire_at_utc")]
    public int? ExpireAtUtc { get; set; }

    /// <summary>
    /// timestamp in the UTC timezone; it may need to be divided by 1000
    /// </summary>
    /// <value>timestamp in the UTC timezone; it may need to be divided by 1000</value>
    [DataMember(Name="created_at_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at_utc")]
    public int? CreatedAtUtc { get; set; }

    /// <summary>
    /// amount received/transferred by an operation (invoice, cash-in/cash-out)
    /// </summary>
    /// <value>amount received/transferred by an operation (invoice, cash-in/cash-out)</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount
    /// </summary>
    /// <value>Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount</value>
    [DataMember(Name="sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sum")]
    public string Sum { get; set; }

    /// <summary>
    /// Plisio commission
    /// </summary>
    /// <value>Plisio commission</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

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
    /// internal Plisio operation ID
    /// </summary>
    /// <value>internal Plisio operation ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Real incoming amount
    /// </summary>
    /// <value>Real incoming amount</value>
    [DataMember(Name="actual_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actual_sum")]
    public string ActualSum { get; set; }

    /// <summary>
    /// Plisio commission taken
    /// </summary>
    /// <value>Plisio commission taken</value>
    [DataMember(Name="actual_commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actual_commission")]
    public string ActualCommission { get; set; }

    /// <summary>
    /// Network fee (move invoice to wallet)
    /// </summary>
    /// <value>Network fee (move invoice to wallet)</value>
    [DataMember(Name="actual_fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actual_fee")]
    public string ActualFee { get; set; }

    /// <summary>
    /// actual_sum - actual_commis_sim - actual_fee
    /// </summary>
    /// <value>actual_sum - actual_commis_sim - actual_fee</value>
    [DataMember(Name="actual_invoice_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actual_invoice_sum")]
    public string ActualInvoiceSum { get; set; }

    /// <summary>
    /// array of transaction payment items
    /// </summary>
    /// <value>array of transaction payment items</value>
    [DataMember(Name="tx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tx")]
    public List<Object> Tx { get; set; }

    /// <summary>
    /// Number of confirmations of this transaction. We don't update confirmation after operation is confirmed
    /// </summary>
    /// <value>Number of confirmations of this transaction. We don't update confirmation after operation is confirmed</value>
    [DataMember(Name="confirmations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirmations")]
    public int? Confirmations { get; set; }

    /// <summary>
    /// Status code
    /// </summary>
    /// <value>Status code</value>
    [DataMember(Name="status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_code")]
    public int? StatusCode { get; set; }

    /// <summary>
    /// ID of parent invoice
    /// </summary>
    /// <value>ID of parent invoice</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationDto {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  ShopId: ").Append(ShopId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  PendingSum: ").Append(PendingSum).Append("\n");
      sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
      sb.Append("  Sendmany: ").Append(Sendmany).Append("\n");
      sb.Append("  _Params: ").Append(_Params).Append("\n");
      sb.Append("  ExpireAtUtc: ").Append(ExpireAtUtc).Append("\n");
      sb.Append("  CreatedAtUtc: ").Append(CreatedAtUtc).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Sum: ").Append(Sum).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
      sb.Append("  TxId: ").Append(TxId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ActualSum: ").Append(ActualSum).Append("\n");
      sb.Append("  ActualCommission: ").Append(ActualCommission).Append("\n");
      sb.Append("  ActualFee: ").Append(ActualFee).Append("\n");
      sb.Append("  ActualInvoiceSum: ").Append(ActualInvoiceSum).Append("\n");
      sb.Append("  Tx: ").Append(Tx).Append("\n");
      sb.Append("  Confirmations: ").Append(Confirmations).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

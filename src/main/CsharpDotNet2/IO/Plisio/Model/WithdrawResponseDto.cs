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
  public class WithdrawResponseDto {
    /// <summary>
    /// 'cash_out' or 'mass_cash_out' depending on the request
    /// </summary>
    /// <value>'cash_out' or 'mass_cash_out' depending on the request</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Cash-out status 'competed', 'error'
    /// </summary>
    /// <value>Cash-out status 'competed', 'error'</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

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
    /// Transaction fee stated in the transfer
    /// </summary>
    /// <value>Transaction fee stated in the transfer</value>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public string Fee { get; set; }

    /// <summary>
    /// Destination hash (type=cash_out)
    /// </summary>
    /// <value>Destination hash (type=cash_out)</value>
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
    public FeeParamsDto _Params { get; set; }

    /// <summary>
    /// timestamp in the UTC timezone; it may need to be divided by 1000
    /// </summary>
    /// <value>timestamp in the UTC timezone; it may need to be divided by 1000</value>
    [DataMember(Name="created_at_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at_utc")]
    public int? CreatedAtUtc { get; set; }

    /// <summary>
    /// transfer amount in cryptocurrency
    /// </summary>
    /// <value>transfer amount in cryptocurrency</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

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
    /// internal Plisio operation ID
    /// </summary>
    /// <value>internal Plisio operation ID</value>
    [DataMember(Name="txn_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txn_id")]
    public string TxnId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WithdrawResponseDto {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
      sb.Append("  Sendmany: ").Append(Sendmany).Append("\n");
      sb.Append("  _Params: ").Append(_Params).Append("\n");
      sb.Append("  CreatedAtUtc: ").Append(CreatedAtUtc).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
      sb.Append("  TxId: ").Append(TxId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TxnId: ").Append(TxnId).Append("\n");
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

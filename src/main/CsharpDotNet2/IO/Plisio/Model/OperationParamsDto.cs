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
  public class OperationParamsDto {
    /// <summary>
    /// Gets or Sets Fee
    /// </summary>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public FeeParamsDto Fee { get; set; }

    /// <summary>
    /// Invoice order number. Must be unique number in your store for each new store`s order!!!
    /// </summary>
    /// <value>Invoice order number. Must be unique number in your store for each new store`s order!!!</value>
    [DataMember(Name="order_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_number")]
    public string OrderNumber { get; set; }

    /// <summary>
    /// Order name
    /// </summary>
    /// <value>Order name</value>
    [DataMember(Name="order_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_name")]
    public string OrderName { get; set; }

    /// <summary>
    /// Order description
    /// </summary>
    /// <value>Order description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Invoice amount in fiat currency
    /// </summary>
    /// <value>Invoice amount in fiat currency</value>
    [DataMember(Name="source_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_amount")]
    public string SourceAmount { get; set; }

    /// <summary>
    /// Invoice fiat currency
    /// </summary>
    /// <value>Invoice fiat currency</value>
    [DataMember(Name="source_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_currency")]
    public string SourceCurrency { get; set; }

    /// <summary>
    /// fee value
    /// </summary>
    /// <value>fee value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Custom invoice avatar
    /// </summary>
    /// <value>Custom invoice avatar</value>
    [DataMember(Name="avatar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// Custom invoice store name
    /// </summary>
    /// <value>Custom invoice store name</value>
    [DataMember(Name="store", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "store")]
    public string Store { get; set; }

    /// <summary>
    /// Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
    /// </summary>
    /// <value>Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
    /// </summary>
    /// <value>ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
    [DataMember(Name="psys_cid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "psys_cid")]
    public string PsysCid { get; set; }

    /// <summary>
    /// Invoice amount in selected cryptocurrency
    /// </summary>
    /// <value>Invoice amount in selected cryptocurrency</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Cryptocurrency rate
    /// </summary>
    /// <value>Cryptocurrency rate</value>
    [DataMember(Name="source_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_rate")]
    public string SourceRate { get; set; }

    /// <summary>
    /// Email of payer
    /// </summary>
    /// <value>Email of payer</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Donation hash
    /// </summary>
    /// <value>Donation hash</value>
    [DataMember(Name="donate_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "donate_hash")]
    public string DonateHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationParamsDto {\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
      sb.Append("  OrderName: ").Append(OrderName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SourceAmount: ").Append(SourceAmount).Append("\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Avatar: ").Append(Avatar).Append("\n");
      sb.Append("  Store: ").Append(Store).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  DonateHash: ").Append(DonateHash).Append("\n");
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

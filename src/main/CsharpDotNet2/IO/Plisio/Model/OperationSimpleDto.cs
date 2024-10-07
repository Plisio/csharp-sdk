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
  public class OperationSimpleDto : InvoiceSimpleResponseDto {
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
    /// link to the cryptocurrency block explorer
    /// </summary>
    /// <value>link to the cryptocurrency block explorer</value>
    [DataMember(Name="tx_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tx_url")]
    public string TxUrl { get; set; }

    /// <summary>
    /// internal Plisio operation ID
    /// </summary>
    /// <value>internal Plisio operation ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationSimpleDto {\n");
      sb.Append("  ShopId: ").Append(ShopId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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

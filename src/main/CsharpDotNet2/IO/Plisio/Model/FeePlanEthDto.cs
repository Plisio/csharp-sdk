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
  public class FeePlanEthDto : FeePlanCommonDto {
    /// <summary>
    /// Ethereum gas limit
    /// </summary>
    /// <value>Ethereum gas limit</value>
    [DataMember(Name="gasLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasLimit")]
    public float? GasLimit { get; set; }

    /// <summary>
    /// Ethereum gas price
    /// </summary>
    /// <value>Ethereum gas price</value>
    [DataMember(Name="gasPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasPrice")]
    public float? GasPrice { get; set; }

    /// <summary>
    /// Fee value
    /// </summary>
    /// <value>Fee value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Fee unit value
    /// </summary>
    /// <value>Fee unit value</value>
    [DataMember(Name="feeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeUnit")]
    public string FeeUnit { get; set; }

    /// <summary>
    /// Nonce param to update tx
    /// </summary>
    /// <value>Nonce param to update tx</value>
    [DataMember(Name="nonce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonce")]
    public Object Nonce { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanEthDto {\n");
      sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
      sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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

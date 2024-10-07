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
  public class FeePlanLimitsEthDto {
    /// <summary>
    /// Plan name: normal, priority or custom
    /// </summary>
    /// <value>Plan name: normal, priority or custom</value>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public string Plan { get; set; }

    /// <summary>
    /// Fee value
    /// </summary>
    /// <value>Fee value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Fee unit
    /// </summary>
    /// <value>Fee unit</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public decimal? Unit { get; set; }

    /// <summary>
    /// Ethereum gas limit
    /// </summary>
    /// <value>Ethereum gas limit</value>
    [DataMember(Name="gasLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasLimit")]
    public int? GasLimit { get; set; }

    /// <summary>
    /// Ethereum gas price in Gwai
    /// </summary>
    /// <value>Ethereum gas price in Gwai</value>
    [DataMember(Name="gasPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gasPrice")]
    public int? GasPrice { get; set; }

    /// <summary>
    /// Name of dynamic property name (ex: gasPrice)
    /// </summary>
    /// <value>Name of dynamic property name (ex: gasPrice)</value>
    [DataMember(Name="dynamicValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicValues")]
    public string DynamicValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanLimitsEthDto {\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
      sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
      sb.Append("  DynamicValues: ").Append(DynamicValues).Append("\n");
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

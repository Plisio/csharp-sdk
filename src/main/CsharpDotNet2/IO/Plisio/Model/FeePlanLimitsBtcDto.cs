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
  public class FeePlanLimitsBtcDto {
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
    /// estimate fee to be included into next 'conf_target' block(s)
    /// </summary>
    /// <value>estimate fee to be included into next 'conf_target' block(s)</value>
    [DataMember(Name="conf_target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conf_target")]
    public decimal? ConfTarget { get; set; }

    /// <summary>
    /// Fee rate in BTC/Kb
    /// </summary>
    /// <value>Fee rate in BTC/Kb</value>
    [DataMember(Name="feerate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feerate")]
    public decimal? Feerate { get; set; }

    /// <summary>
    /// Fee rate in sat/byte
    /// </summary>
    /// <value>Fee rate in sat/byte</value>
    [DataMember(Name="sat_b", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sat_b")]
    public decimal? SatB { get; set; }

    /// <summary>
    /// Name of dynamic property name (ex: sat_b)
    /// </summary>
    /// <value>Name of dynamic property name (ex: sat_b)</value>
    [DataMember(Name="dynamicValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicValues")]
    public string DynamicValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanLimitsBtcDto {\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
      sb.Append("  Feerate: ").Append(Feerate).Append("\n");
      sb.Append("  SatB: ").Append(SatB).Append("\n");
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

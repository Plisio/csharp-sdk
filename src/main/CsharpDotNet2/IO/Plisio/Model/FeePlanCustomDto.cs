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
  public class FeePlanCustomDto {
    /// <summary>
    /// minimal custom fee plan value
    /// </summary>
    /// <value>minimal custom fee plan value</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min")]
    public int? Min { get; set; }

    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public int? Max { get; set; }

    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public int? _Default { get; set; }

    /// <summary>
    /// comma-separated rates of supported plans
    /// </summary>
    /// <value>comma-separated rates of supported plans</value>
    [DataMember(Name="borders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borders")]
    public string Borders { get; set; }

    /// <summary>
    /// Fee unit
    /// </summary>
    /// <value>Fee unit</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Fee unit
    /// </summary>
    /// <value>Fee unit</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanCustomDto {\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
      sb.Append("  _Default: ").Append(_Default).Append("\n");
      sb.Append("  Borders: ").Append(Borders).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
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

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
  public class FeePlanDto {
    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="economy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "economy")]
    public Object Economy { get; set; }

    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public Object Normal { get; set; }

    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public Object Priority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanDto {\n");
      sb.Append("  Economy: ").Append(Economy).Append("\n");
      sb.Append("  Normal: ").Append(Normal).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
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

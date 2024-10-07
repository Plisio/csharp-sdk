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
  public class FeeParamsDto {
    /// <summary>
    /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
    /// </summary>
    /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
    [DataMember(Name="conf_target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conf_target")]
    public string ConfTarget { get; set; }

    /// <summary>
    /// the Plisio’s fee plan name
    /// </summary>
    /// <value>the Plisio’s fee plan name</value>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public string Plan { get; set; }

    /// <summary>
    /// fee value
    /// </summary>
    /// <value>fee value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeeParamsDto {\n");
      sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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

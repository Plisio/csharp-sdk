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
  public class FeeSimplePlanDto {
    /// <summary>
    /// Gets or Sets Economy
    /// </summary>
    [DataMember(Name="economy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "economy")]
    public FeeSimplePlanItemDto Economy { get; set; }

    /// <summary>
    /// Gets or Sets Normal
    /// </summary>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public FeeSimplePlanItemDto Normal { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public FeeSimplePlanItemDto Priority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeeSimplePlanDto {\n");
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

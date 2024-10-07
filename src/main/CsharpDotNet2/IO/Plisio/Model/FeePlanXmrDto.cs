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
  public class FeePlanXmrDto : FeePlanCommonDto {
    /// <summary>
    /// Priority value of XMR
    /// </summary>
    /// <value>Priority value of XMR</value>
    [DataMember(Name="conf_target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conf_target")]
    public Object ConfTarget { get; set; }

    /// <summary>
    /// Fee value
    /// </summary>
    /// <value>Fee value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public decimal? Value { get; set; }

    /// <summary>
    /// Fee unit
    /// </summary>
    /// <value>Fee unit</value>
    [DataMember(Name="feeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeUnit")]
    public decimal? FeeUnit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanXmrDto {\n");
      sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
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

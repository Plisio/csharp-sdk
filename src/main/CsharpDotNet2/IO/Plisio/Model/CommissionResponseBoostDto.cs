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
  public class CommissionResponseBoostDto : CommissionResponseSimpleDto {
    /// <summary>
    /// Minimal fee rate for boost
    /// </summary>
    /// <value>Minimal fee rate for boost</value>
    [DataMember(Name="minFeeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minFeeRate")]
    public float? MinFeeRate { get; set; }

    /// <summary>
    /// Maximum fee rate for boost
    /// </summary>
    /// <value>Maximum fee rate for boost</value>
    [DataMember(Name="maxFeeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxFeeRate")]
    public float? MaxFeeRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommissionResponseBoostDto {\n");
      sb.Append("  MinFeeRate: ").Append(MinFeeRate).Append("\n");
      sb.Append("  MaxFeeRate: ").Append(MaxFeeRate).Append("\n");
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

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
  public class FeePlanBtcDto : FeePlanCommonDto {
    /// <summary>
    /// estimate fee to be included into next 'conf_target' block(s)
    /// </summary>
    /// <value>estimate fee to be included into next 'conf_target' block(s)</value>
    [DataMember(Name="conf_target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conf_target")]
    public decimal? ConfTarget { get; set; }

    /// <summary>
    /// fee rate that will be used for transaction
    /// </summary>
    /// <value>fee rate that will be used for transaction</value>
    [DataMember(Name="feeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeRate")]
    public float? FeeRate { get; set; }

    /// <summary>
    /// fee rate unit
    /// </summary>
    /// <value>fee rate unit</value>
    [DataMember(Name="feeRateUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeRateUnit")]
    public decimal? FeeRateUnit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePlanBtcDto {\n");
      sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
      sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
      sb.Append("  FeeRateUnit: ").Append(FeeRateUnit).Append("\n");
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

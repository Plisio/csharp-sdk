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
  public class CommissionResponseDto {
    /// <summary>
    /// Plisio commission value
    /// </summary>
    /// <value>Plisio commission value</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

    /// <summary>
    /// Cryptocurrency fee value
    /// </summary>
    /// <value>Cryptocurrency fee value</value>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public string Fee { get; set; }

    /// <summary>
    /// Cryptocurrency feeUnit value
    /// </summary>
    /// <value>Cryptocurrency feeUnit value</value>
    [DataMember(Name="feeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeUnit")]
    public string FeeUnit { get; set; }

    /// <summary>
    /// Plisio's cryptocurrency fee estimation plan
    /// </summary>
    /// <value>Plisio's cryptocurrency fee estimation plan</value>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public string Plan { get; set; }

    /// <summary>
    /// Pay fee from wallet
    /// </summary>
    /// <value>Pay fee from wallet</value>
    [DataMember(Name="useWallet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useWallet")]
    public string UseWallet { get; set; }

    /// <summary>
    /// Balance of wallet that will be used to pay fee
    /// </summary>
    /// <value>Balance of wallet that will be used to pay fee</value>
    [DataMember(Name="useWalletBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useWalletBalance")]
    public string UseWalletBalance { get; set; }

    /// <summary>
    /// Cryptocurrency fee plans
    /// </summary>
    /// <value>Cryptocurrency fee plans</value>
    [DataMember(Name="plans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plans")]
    public List<FeePlanDto> Plans { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommissionResponseDto {\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  UseWallet: ").Append(UseWallet).Append("\n");
      sb.Append("  UseWalletBalance: ").Append(UseWalletBalance).Append("\n");
      sb.Append("  Plans: ").Append(Plans).Append("\n");
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

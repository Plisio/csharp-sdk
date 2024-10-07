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
  public class CommissionResponseSimpleDto {
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
    /// Cryptocurrency fee value in selected fiat currency
    /// </summary>
    /// <value>Cryptocurrency fee value in selected fiat currency</value>
    [DataMember(Name="feeFiat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeFiat")]
    public string FeeFiat { get; set; }

    /// <summary>
    /// Selected fiat currency
    /// </summary>
    /// <value>Selected fiat currency</value>
    [DataMember(Name="feeFiatUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeFiatUnit")]
    public string FeeFiatUnit { get; set; }

    /// <summary>
    /// Maximum allowed amount to withdrawal
    /// </summary>
    /// <value>Maximum allowed amount to withdrawal</value>
    [DataMember(Name="maxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxAmount")]
    public string MaxAmount { get; set; }

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
    /// Gets or Sets Plans
    /// </summary>
    [DataMember(Name="plans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plans")]
    public FeeSimplePlanDto Plans { get; set; }

    /// <summary>
    /// Cryptocurrency fee limits
    /// </summary>
    /// <value>Cryptocurrency fee limits</value>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom")]
    public List<FeePlanCustomDto> Custom { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<CommissionResponseSimpleErrorDto> Errors { get; set; }

    /// <summary>
    /// Gets or Sets CustomFeeRate
    /// </summary>
    [DataMember(Name="customFeeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customFeeRate")]
    public float? CustomFeeRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommissionResponseSimpleDto {\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
      sb.Append("  FeeFiat: ").Append(FeeFiat).Append("\n");
      sb.Append("  FeeFiatUnit: ").Append(FeeFiatUnit).Append("\n");
      sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  UseWallet: ").Append(UseWallet).Append("\n");
      sb.Append("  UseWalletBalance: ").Append(UseWalletBalance).Append("\n");
      sb.Append("  Plans: ").Append(Plans).Append("\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  CustomFeeRate: ").Append(CustomFeeRate).Append("\n");
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

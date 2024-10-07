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
  public class ShopDto {
    /// <summary>
    /// Shop name
    /// </summary>
    /// <value>Shop name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Link
    /// </summary>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public string Link { get; set; }

    /// <summary>
    /// Shop logo url
    /// </summary>
    /// <value>Shop logo url</value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Who pays the commission: Shop or Client
    /// </summary>
    /// <value>Who pays the commission: Shop or Client</value>
    [DataMember(Name="commission_payment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission_payment")]
    public int? CommissionPayment { get; set; }

    /// <summary>
    /// Is white-label is enabled
    /// </summary>
    /// <value>Is white-label is enabled</value>
    [DataMember(Name="white_label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "white_label")]
    public bool? WhiteLabel { get; set; }

    /// <summary>
    /// Extra white-label commission
    /// </summary>
    /// <value>Extra white-label commission</value>
    [DataMember(Name="extra_commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extra_commission")]
    public float? ExtraCommission { get; set; }

    /// <summary>
    /// Is domain verified
    /// </summary>
    /// <value>Is domain verified</value>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShopDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  CommissionPayment: ").Append(CommissionPayment).Append("\n");
      sb.Append("  WhiteLabel: ").Append(WhiteLabel).Append("\n");
      sb.Append("  ExtraCommission: ").Append(ExtraCommission).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
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

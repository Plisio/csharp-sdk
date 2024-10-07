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
  public class ShopInfoDto {
    /// <summary>
    /// Shop name
    /// </summary>
    /// <value>Shop name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Shop URL
    /// </summary>
    /// <value>Shop URL</value>
    [DataMember(Name="link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link")]
    public string Link { get; set; }

    /// <summary>
    /// Shop logo
    /// </summary>
    /// <value>Shop logo</value>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logo")]
    public string Logo { get; set; }

    /// <summary>
    /// Success callback URL
    /// </summary>
    /// <value>Success callback URL</value>
    [DataMember(Name="successUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successUrl")]
    public string SuccessUrl { get; set; }

    /// <summary>
    /// Fail callback URL
    /// </summary>
    /// <value>Fail callback URL</value>
    [DataMember(Name="failedUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedUrl")]
    public string FailedUrl { get; set; }

    /// <summary>
    /// Show renew button after invoice expored
    /// </summary>
    /// <value>Show renew button after invoice expored</value>
    [DataMember(Name="allow_renew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_renew")]
    public bool? AllowRenew { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShopInfoDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
      sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
      sb.Append("  AllowRenew: ").Append(AllowRenew).Append("\n");
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

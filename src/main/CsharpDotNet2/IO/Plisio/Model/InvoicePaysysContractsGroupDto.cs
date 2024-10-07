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
  public class InvoicePaysysContractsGroupDto : InvoicePaysysDto {
    /// <summary>
    /// Contract group cid
    /// </summary>
    /// <value>Contract group cid</value>
    [DataMember(Name="contractGroupCid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractGroupCid")]
    public string ContractGroupCid { get; set; }

    /// <summary>
    /// Contract group icon
    /// </summary>
    /// <value>Contract group icon</value>
    [DataMember(Name="contractGroupIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractGroupIcon")]
    public string ContractGroupIcon { get; set; }

    /// <summary>
    /// Contract group name
    /// </summary>
    /// <value>Contract group name</value>
    [DataMember(Name="contractGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractGroupName")]
    public string ContractGroupName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoicePaysysContractsGroupDto {\n");
      sb.Append("  ContractGroupCid: ").Append(ContractGroupCid).Append("\n");
      sb.Append("  ContractGroupIcon: ").Append(ContractGroupIcon).Append("\n");
      sb.Append("  ContractGroupName: ").Append(ContractGroupName).Append("\n");
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

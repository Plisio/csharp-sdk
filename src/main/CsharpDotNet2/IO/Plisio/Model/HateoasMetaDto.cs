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
  public class HateoasMetaDto {
    /// <summary>
    /// HATEOAS pagination items count
    /// </summary>
    /// <value>HATEOAS pagination items count</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// HATEOAS pagination pages count
    /// </summary>
    /// <value>HATEOAS pagination pages count</value>
    [DataMember(Name="pageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageCount")]
    public int? PageCount { get; set; }

    /// <summary>
    /// HATEOAS pagination current page
    /// </summary>
    /// <value>HATEOAS pagination current page</value>
    [DataMember(Name="currentPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPage")]
    public int? CurrentPage { get; set; }

    /// <summary>
    /// HATEOAS pagination items per page
    /// </summary>
    /// <value>HATEOAS pagination items per page</value>
    [DataMember(Name="perPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perPage")]
    public int? PerPage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HateoasMetaDto {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
      sb.Append("  PerPage: ").Append(PerPage).Append("\n");
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

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
  public class DonateDto {
    /// <summary>
    /// Donate name
    /// </summary>
    /// <value>Donate name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Donate info name
    /// </summary>
    /// <value>Donate info name</value>
    [DataMember(Name="info_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "info_name")]
    public string InfoName { get; set; }

    /// <summary>
    /// Donate description
    /// </summary>
    /// <value>Donate description</value>
    [DataMember(Name="info_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "info_description")]
    public string InfoDescription { get; set; }

    /// <summary>
    /// Donate info image url
    /// </summary>
    /// <value>Donate info image url</value>
    [DataMember(Name="info_image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "info_image")]
    public string InfoImage { get; set; }

    /// <summary>
    /// Donate allowed_psys_name
    /// </summary>
    /// <value>Donate allowed_psys_name</value>
    [DataMember(Name="allowed_psys_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_psys_name")]
    public string AllowedPsysName { get; set; }

    /// <summary>
    /// Donate $allowed_psys_cids
    /// </summary>
    /// <value>Donate $allowed_psys_cids</value>
    [DataMember(Name="allowed_psys_cids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_psys_cids")]
    public string AllowedPsysCids { get; set; }

    /// <summary>
    /// Donate $completed_name
    /// </summary>
    /// <value>Donate $completed_name</value>
    [DataMember(Name="completed_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_name")]
    public string CompletedName { get; set; }

    /// <summary>
    /// Donate $completed_text
    /// </summary>
    /// <value>Donate $completed_text</value>
    [DataMember(Name="completed_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_text")]
    public string CompletedText { get; set; }

    /// <summary>
    /// Donate $color_background_first
    /// </summary>
    /// <value>Donate $color_background_first</value>
    [DataMember(Name="color_background_first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_background_first")]
    public string ColorBackgroundFirst { get; set; }

    /// <summary>
    /// Donate $color_background_second
    /// </summary>
    /// <value>Donate $color_background_second</value>
    [DataMember(Name="color_background_second", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_background_second")]
    public string ColorBackgroundSecond { get; set; }

    /// <summary>
    /// Donate $color_title
    /// </summary>
    /// <value>Donate $color_title</value>
    [DataMember(Name="color_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_title")]
    public string ColorTitle { get; set; }

    /// <summary>
    /// Donate $color_description
    /// </summary>
    /// <value>Donate $color_description</value>
    [DataMember(Name="color_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_description")]
    public string ColorDescription { get; set; }

    /// <summary>
    /// Donate $color_link_button
    /// </summary>
    /// <value>Donate $color_link_button</value>
    [DataMember(Name="color_link_button", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_link_button")]
    public string ColorLinkButton { get; set; }

    /// <summary>
    /// Donate $color_text
    /// </summary>
    /// <value>Donate $color_text</value>
    [DataMember(Name="color_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color_text")]
    public string ColorText { get; set; }

    /// <summary>
    /// Donate $button_color
    /// </summary>
    /// <value>Donate $button_color</value>
    [DataMember(Name="button_color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "button_color")]
    public string ButtonColor { get; set; }

    /// <summary>
    /// Donate $button_type
    /// </summary>
    /// <value>Donate $button_type</value>
    [DataMember(Name="button_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "button_type")]
    public string ButtonType { get; set; }

    /// <summary>
    /// Donate $url_donate
    /// </summary>
    /// <value>Donate $url_donate</value>
    [DataMember(Name="url_donate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_donate")]
    public string UrlDonate { get; set; }

    /// <summary>
    /// Model DonateBlockDto
    /// </summary>
    /// <value>Model DonateBlockDto</value>
    [DataMember(Name="block_info", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_info")]
    public Object BlockInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DonateDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  InfoName: ").Append(InfoName).Append("\n");
      sb.Append("  InfoDescription: ").Append(InfoDescription).Append("\n");
      sb.Append("  InfoImage: ").Append(InfoImage).Append("\n");
      sb.Append("  AllowedPsysName: ").Append(AllowedPsysName).Append("\n");
      sb.Append("  AllowedPsysCids: ").Append(AllowedPsysCids).Append("\n");
      sb.Append("  CompletedName: ").Append(CompletedName).Append("\n");
      sb.Append("  CompletedText: ").Append(CompletedText).Append("\n");
      sb.Append("  ColorBackgroundFirst: ").Append(ColorBackgroundFirst).Append("\n");
      sb.Append("  ColorBackgroundSecond: ").Append(ColorBackgroundSecond).Append("\n");
      sb.Append("  ColorTitle: ").Append(ColorTitle).Append("\n");
      sb.Append("  ColorDescription: ").Append(ColorDescription).Append("\n");
      sb.Append("  ColorLinkButton: ").Append(ColorLinkButton).Append("\n");
      sb.Append("  ColorText: ").Append(ColorText).Append("\n");
      sb.Append("  ButtonColor: ").Append(ButtonColor).Append("\n");
      sb.Append("  ButtonType: ").Append(ButtonType).Append("\n");
      sb.Append("  UrlDonate: ").Append(UrlDonate).Append("\n");
      sb.Append("  BlockInfo: ").Append(BlockInfo).Append("\n");
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

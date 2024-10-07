/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Plisio.Client.SwaggerDateConverter;
namespace IO.Plisio.Model
{
    /// <summary>
    /// DonateDto
    /// </summary>
    [DataContract]
        public partial class DonateDto :  IEquatable<DonateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonateDto" /> class.
        /// </summary>
        /// <param name="name">Donate name.</param>
        /// <param name="infoName">Donate info name.</param>
        /// <param name="infoDescription">Donate description.</param>
        /// <param name="infoImage">Donate info image url.</param>
        /// <param name="allowedPsysName">Donate allowed_psys_name.</param>
        /// <param name="allowedPsysCids">Donate $allowed_psys_cids.</param>
        /// <param name="completedName">Donate $completed_name.</param>
        /// <param name="completedText">Donate $completed_text.</param>
        /// <param name="colorBackgroundFirst">Donate $color_background_first.</param>
        /// <param name="colorBackgroundSecond">Donate $color_background_second.</param>
        /// <param name="colorTitle">Donate $color_title.</param>
        /// <param name="colorDescription">Donate $color_description.</param>
        /// <param name="colorLinkButton">Donate $color_link_button.</param>
        /// <param name="colorText">Donate $color_text.</param>
        /// <param name="buttonColor">Donate $button_color.</param>
        /// <param name="buttonType">Donate $button_type.</param>
        /// <param name="urlDonate">Donate $url_donate.</param>
        /// <param name="blockInfo">Model DonateBlockDto.</param>
        public DonateDto(
            string name = default(string), 
            string infoName = default(string), 
            string infoDescription = default(string), 
            string infoImage = default(string), 
            string allowedPsysName = default(string), 
            string allowedPsysCids = default(string), 
            string completedName = default(string), 
            string completedText = default(string), 
            string colorBackgroundFirst = default(string), 
            string colorBackgroundSecond = default(string), 
            string colorTitle = default(string), 
            string colorDescription = default(string), 
            string colorLinkButton = default(string), 
            string colorText = default(string), 
            string buttonColor = default(string), 
            string buttonType = default(string), 
            string urlDonate = default(string), 
            Object blockInfo = default(Object)
            )
        {
            this.Name = name;
            this.InfoName = infoName;
            this.InfoDescription = infoDescription;
            this.InfoImage = infoImage;
            this.AllowedPsysName = allowedPsysName;
            this.AllowedPsysCids = allowedPsysCids;
            this.CompletedName = completedName;
            this.CompletedText = completedText;
            this.ColorBackgroundFirst = colorBackgroundFirst;
            this.ColorBackgroundSecond = colorBackgroundSecond;
            this.ColorTitle = colorTitle;
            this.ColorDescription = colorDescription;
            this.ColorLinkButton = colorLinkButton;
            this.ColorText = colorText;
            this.ButtonColor = buttonColor;
            this.ButtonType = buttonType;
            this.UrlDonate = urlDonate;
            this.BlockInfo = blockInfo;
        }
        
        /// <summary>
        /// Donate name
        /// </summary>
        /// <value>Donate name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Donate info name
        /// </summary>
        /// <value>Donate info name</value>
        [DataMember(Name="info_name", EmitDefaultValue=false)]
        public string InfoName { get; set; }

        /// <summary>
        /// Donate description
        /// </summary>
        /// <value>Donate description</value>
        [DataMember(Name="info_description", EmitDefaultValue=false)]
        public string InfoDescription { get; set; }

        /// <summary>
        /// Donate info image url
        /// </summary>
        /// <value>Donate info image url</value>
        [DataMember(Name="info_image", EmitDefaultValue=false)]
        public string InfoImage { get; set; }

        /// <summary>
        /// Donate allowed_psys_name
        /// </summary>
        /// <value>Donate allowed_psys_name</value>
        [DataMember(Name="allowed_psys_name", EmitDefaultValue=false)]
        public string AllowedPsysName { get; set; }

        /// <summary>
        /// Donate $allowed_psys_cids
        /// </summary>
        /// <value>Donate $allowed_psys_cids</value>
        [DataMember(Name="allowed_psys_cids", EmitDefaultValue=false)]
        public string AllowedPsysCids { get; set; }

        /// <summary>
        /// Donate $completed_name
        /// </summary>
        /// <value>Donate $completed_name</value>
        [DataMember(Name="completed_name", EmitDefaultValue=false)]
        public string CompletedName { get; set; }

        /// <summary>
        /// Donate $completed_text
        /// </summary>
        /// <value>Donate $completed_text</value>
        [DataMember(Name="completed_text", EmitDefaultValue=false)]
        public string CompletedText { get; set; }

        /// <summary>
        /// Donate $color_background_first
        /// </summary>
        /// <value>Donate $color_background_first</value>
        [DataMember(Name="color_background_first", EmitDefaultValue=false)]
        public string ColorBackgroundFirst { get; set; }

        /// <summary>
        /// Donate $color_background_second
        /// </summary>
        /// <value>Donate $color_background_second</value>
        [DataMember(Name="color_background_second", EmitDefaultValue=false)]
        public string ColorBackgroundSecond { get; set; }

        /// <summary>
        /// Donate $color_title
        /// </summary>
        /// <value>Donate $color_title</value>
        [DataMember(Name="color_title", EmitDefaultValue=false)]
        public string ColorTitle { get; set; }

        /// <summary>
        /// Donate $color_description
        /// </summary>
        /// <value>Donate $color_description</value>
        [DataMember(Name="color_description", EmitDefaultValue=false)]
        public string ColorDescription { get; set; }

        /// <summary>
        /// Donate $color_link_button
        /// </summary>
        /// <value>Donate $color_link_button</value>
        [DataMember(Name="color_link_button", EmitDefaultValue=false)]
        public string ColorLinkButton { get; set; }

        /// <summary>
        /// Donate $color_text
        /// </summary>
        /// <value>Donate $color_text</value>
        [DataMember(Name="color_text", EmitDefaultValue=false)]
        public string ColorText { get; set; }

        /// <summary>
        /// Donate $button_color
        /// </summary>
        /// <value>Donate $button_color</value>
        [DataMember(Name="button_color", EmitDefaultValue=false)]
        public string ButtonColor { get; set; }

        /// <summary>
        /// Donate $button_type
        /// </summary>
        /// <value>Donate $button_type</value>
        [DataMember(Name="button_type", EmitDefaultValue=false)]
        public string ButtonType { get; set; }

        /// <summary>
        /// Donate $url_donate
        /// </summary>
        /// <value>Donate $url_donate</value>
        [DataMember(Name="url_donate", EmitDefaultValue=false)]
        public string UrlDonate { get; set; }

        /// <summary>
        /// Model DonateBlockDto
        /// </summary>
        /// <value>Model DonateBlockDto</value>
        [DataMember(Name="block_info", EmitDefaultValue=false)]
        public Object BlockInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DonateDto);
        }

        /// <summary>
        /// Returns true if DonateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DonateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DonateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InfoName == input.InfoName ||
                    (this.InfoName != null &&
                    this.InfoName.Equals(input.InfoName))
                ) && 
                (
                    this.InfoDescription == input.InfoDescription ||
                    (this.InfoDescription != null &&
                    this.InfoDescription.Equals(input.InfoDescription))
                ) && 
                (
                    this.InfoImage == input.InfoImage ||
                    (this.InfoImage != null &&
                    this.InfoImage.Equals(input.InfoImage))
                ) && 
                (
                    this.AllowedPsysName == input.AllowedPsysName ||
                    (this.AllowedPsysName != null &&
                    this.AllowedPsysName.Equals(input.AllowedPsysName))
                ) && 
                (
                    this.AllowedPsysCids == input.AllowedPsysCids ||
                    (this.AllowedPsysCids != null &&
                    this.AllowedPsysCids.Equals(input.AllowedPsysCids))
                ) && 
                (
                    this.CompletedName == input.CompletedName ||
                    (this.CompletedName != null &&
                    this.CompletedName.Equals(input.CompletedName))
                ) && 
                (
                    this.CompletedText == input.CompletedText ||
                    (this.CompletedText != null &&
                    this.CompletedText.Equals(input.CompletedText))
                ) && 
                (
                    this.ColorBackgroundFirst == input.ColorBackgroundFirst ||
                    (this.ColorBackgroundFirst != null &&
                    this.ColorBackgroundFirst.Equals(input.ColorBackgroundFirst))
                ) && 
                (
                    this.ColorBackgroundSecond == input.ColorBackgroundSecond ||
                    (this.ColorBackgroundSecond != null &&
                    this.ColorBackgroundSecond.Equals(input.ColorBackgroundSecond))
                ) && 
                (
                    this.ColorTitle == input.ColorTitle ||
                    (this.ColorTitle != null &&
                    this.ColorTitle.Equals(input.ColorTitle))
                ) && 
                (
                    this.ColorDescription == input.ColorDescription ||
                    (this.ColorDescription != null &&
                    this.ColorDescription.Equals(input.ColorDescription))
                ) && 
                (
                    this.ColorLinkButton == input.ColorLinkButton ||
                    (this.ColorLinkButton != null &&
                    this.ColorLinkButton.Equals(input.ColorLinkButton))
                ) && 
                (
                    this.ColorText == input.ColorText ||
                    (this.ColorText != null &&
                    this.ColorText.Equals(input.ColorText))
                ) && 
                (
                    this.ButtonColor == input.ButtonColor ||
                    (this.ButtonColor != null &&
                    this.ButtonColor.Equals(input.ButtonColor))
                ) && 
                (
                    this.ButtonType == input.ButtonType ||
                    (this.ButtonType != null &&
                    this.ButtonType.Equals(input.ButtonType))
                ) && 
                (
                    this.UrlDonate == input.UrlDonate ||
                    (this.UrlDonate != null &&
                    this.UrlDonate.Equals(input.UrlDonate))
                ) && 
                (
                    this.BlockInfo == input.BlockInfo ||
                    (this.BlockInfo != null &&
                    this.BlockInfo.Equals(input.BlockInfo))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InfoName != null)
                    hashCode = hashCode * 59 + this.InfoName.GetHashCode();
                if (this.InfoDescription != null)
                    hashCode = hashCode * 59 + this.InfoDescription.GetHashCode();
                if (this.InfoImage != null)
                    hashCode = hashCode * 59 + this.InfoImage.GetHashCode();
                if (this.AllowedPsysName != null)
                    hashCode = hashCode * 59 + this.AllowedPsysName.GetHashCode();
                if (this.AllowedPsysCids != null)
                    hashCode = hashCode * 59 + this.AllowedPsysCids.GetHashCode();
                if (this.CompletedName != null)
                    hashCode = hashCode * 59 + this.CompletedName.GetHashCode();
                if (this.CompletedText != null)
                    hashCode = hashCode * 59 + this.CompletedText.GetHashCode();
                if (this.ColorBackgroundFirst != null)
                    hashCode = hashCode * 59 + this.ColorBackgroundFirst.GetHashCode();
                if (this.ColorBackgroundSecond != null)
                    hashCode = hashCode * 59 + this.ColorBackgroundSecond.GetHashCode();
                if (this.ColorTitle != null)
                    hashCode = hashCode * 59 + this.ColorTitle.GetHashCode();
                if (this.ColorDescription != null)
                    hashCode = hashCode * 59 + this.ColorDescription.GetHashCode();
                if (this.ColorLinkButton != null)
                    hashCode = hashCode * 59 + this.ColorLinkButton.GetHashCode();
                if (this.ColorText != null)
                    hashCode = hashCode * 59 + this.ColorText.GetHashCode();
                if (this.ButtonColor != null)
                    hashCode = hashCode * 59 + this.ButtonColor.GetHashCode();
                if (this.ButtonType != null)
                    hashCode = hashCode * 59 + this.ButtonType.GetHashCode();
                if (this.UrlDonate != null)
                    hashCode = hashCode * 59 + this.UrlDonate.GetHashCode();
                if (this.BlockInfo != null)
                    hashCode = hashCode * 59 + this.BlockInfo.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}

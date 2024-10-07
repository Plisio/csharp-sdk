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
    /// ShopInfoDto
    /// </summary>
    [DataContract]
        public partial class ShopInfoDto :  IEquatable<ShopInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopInfoDto" /> class.
        /// </summary>
        /// <param name="name">Shop name.</param>
        /// <param name="link">Shop URL.</param>
        /// <param name="logo">Shop logo.</param>
        /// <param name="successUrl">Success callback URL.</param>
        /// <param name="failedUrl">Fail callback URL.</param>
        /// <param name="allowRenew">Show renew button after invoice expored.</param>
        public ShopInfoDto(
            string name = default(string), 
            string link = default(string),
            string logo = default(string),
            string successUrl = default(string),
            string failedUrl = default(string),
            bool? allowRenew = default(bool?)
            )
        {
            this.Name = name;
            this.Link = link;
            this.Logo = logo;
            this.SuccessUrl = successUrl;
            this.FailedUrl = failedUrl;
            this.AllowRenew = allowRenew;
        }
        
        /// <summary>
        /// Shop name
        /// </summary>
        /// <value>Shop name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Shop URL
        /// </summary>
        /// <value>Shop URL</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Shop logo
        /// </summary>
        /// <value>Shop logo</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Success callback URL
        /// </summary>
        /// <value>Success callback URL</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Fail callback URL
        /// </summary>
        /// <value>Fail callback URL</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// Show renew button after invoice expored
        /// </summary>
        /// <value>Show renew button after invoice expored</value>
        [DataMember(Name="allow_renew", EmitDefaultValue=false)]
        public bool? AllowRenew { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(input as ShopInfoDto);
        }

        /// <summary>
        /// Returns true if ShopInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopInfoDto input)
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
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && 
                (
                    this.FailedUrl == input.FailedUrl ||
                    (this.FailedUrl != null &&
                    this.FailedUrl.Equals(input.FailedUrl))
                ) && 
                (
                    this.AllowRenew == input.AllowRenew ||
                    (this.AllowRenew != null &&
                    this.AllowRenew.Equals(input.AllowRenew))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
                if (this.FailedUrl != null)
                    hashCode = hashCode * 59 + this.FailedUrl.GetHashCode();
                if (this.AllowRenew != null)
                    hashCode = hashCode * 59 + this.AllowRenew.GetHashCode();
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

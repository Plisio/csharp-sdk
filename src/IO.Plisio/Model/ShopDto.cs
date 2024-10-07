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
    /// ShopDto
    /// </summary>
    [DataContract]
        public partial class ShopDto :  IEquatable<ShopDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopDto" /> class.
        /// </summary>
        /// <param name="name">Shop name.</param>
        /// <param name="link">link.</param>
        /// <param name="logo">Shop logo url.</param>
        /// <param name="commissionPayment">Who pays the commission: Shop or Client.</param>
        /// <param name="whiteLabel">Is white-label is enabled.</param>
        /// <param name="extraCommission">Extra white-label commission.</param>
        /// <param name="verified">Is domain verified.</param>
        public ShopDto(
            string name = default(string), 
            string link = default(string),
            string logo = default(string),
            int? commissionPayment = default(int?),
            bool? whiteLabel = default(bool?), 
            float? extraCommission = default(float?),
            bool? verified = default(bool?)
            )
        {
            this.Name = name;
            this.Link = link;
            this.Logo = logo;
            this.CommissionPayment = commissionPayment;
            this.WhiteLabel = whiteLabel;
            this.ExtraCommission = extraCommission;
            this.Verified = verified;
        }
        
        /// <summary>
        /// Shop name
        /// </summary>
        /// <value>Shop name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Shop logo url
        /// </summary>
        /// <value>Shop logo url</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Who pays the commission: Shop or Client
        /// </summary>
        /// <value>Who pays the commission: Shop or Client</value>
        [DataMember(Name="commission_payment", EmitDefaultValue=false)]
        public int? CommissionPayment { get; set; }

        /// <summary>
        /// Is white-label is enabled
        /// </summary>
        /// <value>Is white-label is enabled</value>
        [DataMember(Name="white_label", EmitDefaultValue=false)]
        public bool? WhiteLabel { get; set; }

        /// <summary>
        /// Extra white-label commission
        /// </summary>
        /// <value>Extra white-label commission</value>
        [DataMember(Name="extra_commission", EmitDefaultValue=false)]
        public float? ExtraCommission { get; set; }

        /// <summary>
        /// Is domain verified
        /// </summary>
        /// <value>Is domain verified</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(input as ShopDto);
        }

        /// <summary>
        /// Returns true if ShopDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopDto input)
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
                    this.CommissionPayment == input.CommissionPayment ||
                    (this.CommissionPayment != null &&
                    this.CommissionPayment.Equals(input.CommissionPayment))
                ) && 
                (
                    this.WhiteLabel == input.WhiteLabel ||
                    (this.WhiteLabel != null &&
                    this.WhiteLabel.Equals(input.WhiteLabel))
                ) && 
                (
                    this.ExtraCommission == input.ExtraCommission ||
                    (this.ExtraCommission != null &&
                    this.ExtraCommission.Equals(input.ExtraCommission))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
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
                if (this.CommissionPayment != null)
                    hashCode = hashCode * 59 + this.CommissionPayment.GetHashCode();
                if (this.WhiteLabel != null)
                    hashCode = hashCode * 59 + this.WhiteLabel.GetHashCode();
                if (this.ExtraCommission != null)
                    hashCode = hashCode * 59 + this.ExtraCommission.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
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

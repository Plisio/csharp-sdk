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
    /// DonateBlockDto
    /// </summary>
    [DataContract]
        public partial class DonateBlockDto :  IEquatable<DonateBlockDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonateBlockDto" /> class.
        /// </summary>
        /// <param name="donateId">Name.</param>
        /// <param name="name">Name.</param>
        /// <param name="url">Url.</param>
        /// <param name="image">Image.</param>
        /// <param name="icon">Icon.</param>
        /// <param name="status">Status.</param>
        public DonateBlockDto(
            string donateId = default(string), 
            string name = default(string), 
            string url = default(string), 
            string image = default(string), 
            string icon = default(string), 
            int? status = default(int?)
            )
        {
            this.DonateId = donateId;
            this.Name = name;
            this.Url = url;
            this.Image = image;
            this.Icon = icon;
            this.Status = status;
        }
        
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="donate_id", EmitDefaultValue=false)]
        public string DonateId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        /// <value>Url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        /// <value>Image</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Icon
        /// </summary>
        /// <value>Icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DonateBlockDto {\n");
            sb.Append("  DonateId: ").Append(DonateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as DonateBlockDto);
        }

        /// <summary>
        /// Returns true if DonateBlockDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DonateBlockDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DonateBlockDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DonateId == input.DonateId ||
                    (this.DonateId != null &&
                    this.DonateId.Equals(input.DonateId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DonateId != null)
                    hashCode = hashCode * 59 + this.DonateId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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

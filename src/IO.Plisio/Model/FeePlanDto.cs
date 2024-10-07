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
    /// FeePlanDto
    /// </summary>
    [DataContract]
        public partial class FeePlanDto :  IEquatable<FeePlanDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanDto" /> class.
        /// </summary>
        /// <param name="economy">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        /// <param name="normal">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        /// <param name="priority">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        public FeePlanDto(Object economy = default(Object), Object normal = default(Object), Object priority = default(Object))
        {
            this.Economy = economy;
            this.Normal = normal;
            this.Priority = priority;
        }
        
        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="economy", EmitDefaultValue=false)]
        public Object Economy { get; set; }

        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="normal", EmitDefaultValue=false)]
        public Object Normal { get; set; }

        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public Object Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanDto {\n");
            sb.Append("  Economy: ").Append(Economy).Append("\n");
            sb.Append("  Normal: ").Append(Normal).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as FeePlanDto);
        }

        /// <summary>
        /// Returns true if FeePlanDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Economy == input.Economy ||
                    (this.Economy != null &&
                    this.Economy.Equals(input.Economy))
                ) && 
                (
                    this.Normal == input.Normal ||
                    (this.Normal != null &&
                    this.Normal.Equals(input.Normal))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.Economy != null)
                    hashCode = hashCode * 59 + this.Economy.GetHashCode();
                if (this.Normal != null)
                    hashCode = hashCode * 59 + this.Normal.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
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

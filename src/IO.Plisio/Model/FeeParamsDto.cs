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
    /// FeeParamsDto
    /// </summary>
    [DataContract]
        public partial class FeeParamsDto :  IEquatable<FeeParamsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeParamsDto" /> class.
        /// </summary>
        /// <param name="confTarget">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        /// <param name="plan">the Plisio’s fee plan name.</param>
        /// <param name="value">fee value.</param>
        public FeeParamsDto(string confTarget = default(string), string plan = default(string), string value = default(string))
        {
            this.ConfTarget = confTarget;
            this.Plan = plan;
            this.Value = value;
        }
        
        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="conf_target", EmitDefaultValue=false)]
        public string ConfTarget { get; set; }

        /// <summary>
        /// the Plisio’s fee plan name
        /// </summary>
        /// <value>the Plisio’s fee plan name</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// fee value
        /// </summary>
        /// <value>fee value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeParamsDto {\n");
            sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FeeParamsDto);
        }

        /// <summary>
        /// Returns true if FeeParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeParamsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfTarget == input.ConfTarget ||
                    (this.ConfTarget != null &&
                    this.ConfTarget.Equals(input.ConfTarget))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ConfTarget != null)
                    hashCode = hashCode * 59 + this.ConfTarget.GetHashCode();
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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

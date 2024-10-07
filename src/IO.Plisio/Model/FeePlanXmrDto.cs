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
    /// FeePlanXmrDto
    /// </summary>
    [DataContract]
        public partial class FeePlanXmrDto : FeePlanCommonDto,  IEquatable<FeePlanXmrDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanXmrDto" /> class.
        /// </summary>
        /// <param name="confTarget">Priority value of XMR.</param>
        /// <param name="value">Fee value.</param>
        /// <param name="feeUnit">Fee unit.</param>
        public FeePlanXmrDto(
            Object confTarget = default(Object), 
            decimal? value = default(decimal?), 
            decimal? feeUnit = default(decimal?), 
            string key = default(string), 
            string name = default(string), 
            string description = default(string)
            ) : base(key, name, description)
        {
            this.ConfTarget = confTarget;
            this.Value = value;
            this.FeeUnit = feeUnit;
        }
        
        /// <summary>
        /// Priority value of XMR
        /// </summary>
        /// <value>Priority value of XMR</value>
        [DataMember(Name="conf_target", EmitDefaultValue=false)]
        public Object ConfTarget { get; set; }

        /// <summary>
        /// Fee value
        /// </summary>
        /// <value>Fee value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Fee unit
        /// </summary>
        /// <value>Fee unit</value>
        [DataMember(Name="feeUnit", EmitDefaultValue=false)]
        public decimal? FeeUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanXmrDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FeePlanXmrDto);
        }

        /// <summary>
        /// Returns true if FeePlanXmrDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanXmrDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanXmrDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ConfTarget == input.ConfTarget ||
                    (this.ConfTarget != null &&
                    this.ConfTarget.Equals(input.ConfTarget))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.FeeUnit == input.FeeUnit ||
                    (this.FeeUnit != null &&
                    this.FeeUnit.Equals(input.FeeUnit))
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
                int hashCode = base.GetHashCode();
                if (this.ConfTarget != null)
                    hashCode = hashCode * 59 + this.ConfTarget.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.FeeUnit != null)
                    hashCode = hashCode * 59 + this.FeeUnit.GetHashCode();
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

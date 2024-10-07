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
    /// FeePlanBtcDto
    /// </summary>
    [DataContract]
        public partial class FeePlanBtcDto : FeePlanCommonDto,  IEquatable<FeePlanBtcDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanBtcDto" /> class.
        /// </summary>
        /// <param name="confTarget">estimate fee to be included into next &#x27;conf_target&#x27; block(s).</param>
        /// <param name="feeRate">fee rate that will be used for transaction.</param>
        /// <param name="feeRateUnit">fee rate unit.</param>
        public FeePlanBtcDto(
            decimal? confTarget = default(decimal?), 
            float? feeRate = default(float?), 
            decimal? feeRateUnit = default(decimal?), 
            string key = default(string), 
            string name = default(string), 
            string description = default(string)
            ) : base(key, name, description)
        {
            this.ConfTarget = confTarget;
            this.FeeRate = feeRate;
            this.FeeRateUnit = feeRateUnit;
        }
        
        /// <summary>
        /// estimate fee to be included into next &#x27;conf_target&#x27; block(s)
        /// </summary>
        /// <value>estimate fee to be included into next &#x27;conf_target&#x27; block(s)</value>
        [DataMember(Name="conf_target", EmitDefaultValue=false)]
        public decimal? ConfTarget { get; set; }

        /// <summary>
        /// fee rate that will be used for transaction
        /// </summary>
        /// <value>fee rate that will be used for transaction</value>
        [DataMember(Name="feeRate", EmitDefaultValue=false)]
        public float? FeeRate { get; set; }

        /// <summary>
        /// fee rate unit
        /// </summary>
        /// <value>fee rate unit</value>
        [DataMember(Name="feeRateUnit", EmitDefaultValue=false)]
        public decimal? FeeRateUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanBtcDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  FeeRateUnit: ").Append(FeeRateUnit).Append("\n");
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
            return this.Equals(input as FeePlanBtcDto);
        }

        /// <summary>
        /// Returns true if FeePlanBtcDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanBtcDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanBtcDto input)
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
                    this.FeeRate == input.FeeRate ||
                    (this.FeeRate != null &&
                    this.FeeRate.Equals(input.FeeRate))
                ) && base.Equals(input) && 
                (
                    this.FeeRateUnit == input.FeeRateUnit ||
                    (this.FeeRateUnit != null &&
                    this.FeeRateUnit.Equals(input.FeeRateUnit))
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
                if (this.FeeRate != null)
                    hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                if (this.FeeRateUnit != null)
                    hashCode = hashCode * 59 + this.FeeRateUnit.GetHashCode();
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

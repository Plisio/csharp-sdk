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
    /// FeePlanLimitsBtcDto
    /// </summary>
    [DataContract]
        public partial class FeePlanLimitsBtcDto :  IEquatable<FeePlanLimitsBtcDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanLimitsBtcDto" /> class.
        /// </summary>
        /// <param name="plan">Plan name: normal, priority or custom.</param>
        /// <param name="value">Fee value.</param>
        /// <param name="unit">Fee unit.</param>
        /// <param name="confTarget">estimate fee to be included into next &#x27;conf_target&#x27; block(s).</param>
        /// <param name="feerate">Fee rate in BTC/Kb.</param>
        /// <param name="satB">Fee rate in sat/byte.</param>
        /// <param name="dynamicValues">Name of dynamic property name (ex: sat_b).</param>
        public FeePlanLimitsBtcDto(
            string plan = default(string), 
            string value = default(string), 
            decimal? unit = default(decimal?), 
            decimal? confTarget = default(decimal?), 
            decimal? feerate = default(decimal?), 
            decimal? satB = default(decimal?), 
            string dynamicValues = default(string)
            )
        {
            this.Plan = plan;
            this.Value = value;
            this.Unit = unit;
            this.ConfTarget = confTarget;
            this.Feerate = feerate;
            this.SatB = satB;
            this.DynamicValues = dynamicValues;
        }
        
        /// <summary>
        /// Plan name: normal, priority or custom
        /// </summary>
        /// <value>Plan name: normal, priority or custom</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// Fee value
        /// </summary>
        /// <value>Fee value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Fee unit
        /// </summary>
        /// <value>Fee unit</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public decimal? Unit { get; set; }

        /// <summary>
        /// estimate fee to be included into next &#x27;conf_target&#x27; block(s)
        /// </summary>
        /// <value>estimate fee to be included into next &#x27;conf_target&#x27; block(s)</value>
        [DataMember(Name="conf_target", EmitDefaultValue=false)]
        public decimal? ConfTarget { get; set; }

        /// <summary>
        /// Fee rate in BTC/Kb
        /// </summary>
        /// <value>Fee rate in BTC/Kb</value>
        [DataMember(Name="feerate", EmitDefaultValue=false)]
        public decimal? Feerate { get; set; }

        /// <summary>
        /// Fee rate in sat/byte
        /// </summary>
        /// <value>Fee rate in sat/byte</value>
        [DataMember(Name="sat_b", EmitDefaultValue=false)]
        public decimal? SatB { get; set; }

        /// <summary>
        /// Name of dynamic property name (ex: sat_b)
        /// </summary>
        /// <value>Name of dynamic property name (ex: sat_b)</value>
        [DataMember(Name="dynamicValues", EmitDefaultValue=false)]
        public string DynamicValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanLimitsBtcDto {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  ConfTarget: ").Append(ConfTarget).Append("\n");
            sb.Append("  Feerate: ").Append(Feerate).Append("\n");
            sb.Append("  SatB: ").Append(SatB).Append("\n");
            sb.Append("  DynamicValues: ").Append(DynamicValues).Append("\n");
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
            return this.Equals(input as FeePlanLimitsBtcDto);
        }

        /// <summary>
        /// Returns true if FeePlanLimitsBtcDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanLimitsBtcDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanLimitsBtcDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.ConfTarget == input.ConfTarget ||
                    (this.ConfTarget != null &&
                    this.ConfTarget.Equals(input.ConfTarget))
                ) && 
                (
                    this.Feerate == input.Feerate ||
                    (this.Feerate != null &&
                    this.Feerate.Equals(input.Feerate))
                ) && 
                (
                    this.SatB == input.SatB ||
                    (this.SatB != null &&
                    this.SatB.Equals(input.SatB))
                ) && 
                (
                    this.DynamicValues == input.DynamicValues ||
                    (this.DynamicValues != null &&
                    this.DynamicValues.Equals(input.DynamicValues))
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
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.ConfTarget != null)
                    hashCode = hashCode * 59 + this.ConfTarget.GetHashCode();
                if (this.Feerate != null)
                    hashCode = hashCode * 59 + this.Feerate.GetHashCode();
                if (this.SatB != null)
                    hashCode = hashCode * 59 + this.SatB.GetHashCode();
                if (this.DynamicValues != null)
                    hashCode = hashCode * 59 + this.DynamicValues.GetHashCode();
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

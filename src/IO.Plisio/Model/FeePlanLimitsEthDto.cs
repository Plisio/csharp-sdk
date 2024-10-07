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
    /// FeePlanLimitsEthDto
    /// </summary>
    [DataContract]
        public partial class FeePlanLimitsEthDto :  IEquatable<FeePlanLimitsEthDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanLimitsEthDto" /> class.
        /// </summary>
        /// <param name="plan">Plan name: normal, priority or custom.</param>
        /// <param name="value">Fee value.</param>
        /// <param name="unit">Fee unit.</param>
        /// <param name="gasLimit">Ethereum gas limit.</param>
        /// <param name="gasPrice">Ethereum gas price in Gwai.</param>
        /// <param name="dynamicValues">Name of dynamic property name (ex: gasPrice).</param>
        public FeePlanLimitsEthDto(
            string plan = default(string),
            string value = default(string),
            decimal? unit = default(decimal?),
            int? gasLimit = default(int?), 
            int? gasPrice = default(int?), 
            string dynamicValues = default(string)
            )
        {
            this.Plan = plan;
            this.Value = value;
            this.Unit = unit;
            this.GasLimit = gasLimit;
            this.GasPrice = gasPrice;
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
        /// Ethereum gas limit
        /// </summary>
        /// <value>Ethereum gas limit</value>
        [DataMember(Name="gasLimit", EmitDefaultValue=false)]
        public int? GasLimit { get; set; }

        /// <summary>
        /// Ethereum gas price in Gwai
        /// </summary>
        /// <value>Ethereum gas price in Gwai</value>
        [DataMember(Name="gasPrice", EmitDefaultValue=false)]
        public int? GasPrice { get; set; }

        /// <summary>
        /// Name of dynamic property name (ex: gasPrice)
        /// </summary>
        /// <value>Name of dynamic property name (ex: gasPrice)</value>
        [DataMember(Name="dynamicValues", EmitDefaultValue=false)]
        public string DynamicValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanLimitsEthDto {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
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
            return this.Equals(input as FeePlanLimitsEthDto);
        }

        /// <summary>
        /// Returns true if FeePlanLimitsEthDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanLimitsEthDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanLimitsEthDto input)
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
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
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
                if (this.GasLimit != null)
                    hashCode = hashCode * 59 + this.GasLimit.GetHashCode();
                if (this.GasPrice != null)
                    hashCode = hashCode * 59 + this.GasPrice.GetHashCode();
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

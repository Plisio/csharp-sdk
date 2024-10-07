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
    /// CommissionResponseBoostDto
    /// </summary>
    [DataContract]
        public partial class CommissionResponseBoostDto : CommissionResponseSimpleDto,  IEquatable<CommissionResponseBoostDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionResponseBoostDto" /> class.
        /// </summary>
        /// <param name="minFeeRate">Minimal fee rate for boost.</param>
        /// <param name="maxFeeRate">Maximum fee rate for boost.</param>
        public CommissionResponseBoostDto(
            float? minFeeRate = default(float?), 
            float? maxFeeRate = default(float?), 
            string commission = default(string), 
            string fee = default(string), 
            string feeUnit = default(string), 
            string feeFiat = default(string), 
            string feeFiatUnit = default(string), 
            string maxAmount = default(string), 
            string plan = default(string), 
            string useWallet = default(string), 
            string useWalletBalance = default(string), 
            FeeSimplePlanDto plans = default(FeeSimplePlanDto), 
            List<FeePlanCustomDto> custom = default(List<FeePlanCustomDto>), 
            List<CommissionResponseSimpleErrorDto> errors = default(List<CommissionResponseSimpleErrorDto>), 
            float? customFeeRate = default(float?)
            ) : base(commission, fee, feeUnit, feeFiat, feeFiatUnit, maxAmount, plan, useWallet, useWalletBalance, plans, custom, errors, customFeeRate)
        {
            this.MinFeeRate = minFeeRate;
            this.MaxFeeRate = maxFeeRate;
        }
        
        /// <summary>
        /// Minimal fee rate for boost
        /// </summary>
        /// <value>Minimal fee rate for boost</value>
        [DataMember(Name="minFeeRate", EmitDefaultValue=false)]
        public float? MinFeeRate { get; set; }

        /// <summary>
        /// Maximum fee rate for boost
        /// </summary>
        /// <value>Maximum fee rate for boost</value>
        [DataMember(Name="maxFeeRate", EmitDefaultValue=false)]
        public float? MaxFeeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionResponseBoostDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MinFeeRate: ").Append(MinFeeRate).Append("\n");
            sb.Append("  MaxFeeRate: ").Append(MaxFeeRate).Append("\n");
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
            return this.Equals(input as CommissionResponseBoostDto);
        }

        /// <summary>
        /// Returns true if CommissionResponseBoostDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionResponseBoostDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionResponseBoostDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.MinFeeRate == input.MinFeeRate ||
                    (this.MinFeeRate != null &&
                    this.MinFeeRate.Equals(input.MinFeeRate))
                ) && base.Equals(input) && 
                (
                    this.MaxFeeRate == input.MaxFeeRate ||
                    (this.MaxFeeRate != null &&
                    this.MaxFeeRate.Equals(input.MaxFeeRate))
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
                if (this.MinFeeRate != null)
                    hashCode = hashCode * 59 + this.MinFeeRate.GetHashCode();
                if (this.MaxFeeRate != null)
                    hashCode = hashCode * 59 + this.MaxFeeRate.GetHashCode();
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

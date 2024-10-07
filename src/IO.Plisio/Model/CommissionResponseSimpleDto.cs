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
    /// CommissionResponseSimpleDto
    /// </summary>
    [DataContract]
        public partial class CommissionResponseSimpleDto :  IEquatable<CommissionResponseSimpleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionResponseSimpleDto" /> class.
        /// </summary>
        /// <param name="commission">Plisio commission value.</param>
        /// <param name="fee">Cryptocurrency fee value.</param>
        /// <param name="feeUnit">Cryptocurrency feeUnit value.</param>
        /// <param name="feeFiat">Cryptocurrency fee value in selected fiat currency.</param>
        /// <param name="feeFiatUnit">Selected fiat currency.</param>
        /// <param name="maxAmount">Maximum allowed amount to withdrawal.</param>
        /// <param name="plan">Plisio&#x27;s cryptocurrency fee estimation plan.</param>
        /// <param name="useWallet">Pay fee from wallet.</param>
        /// <param name="useWalletBalance">Balance of wallet that will be used to pay fee.</param>
        /// <param name="plans">plans.</param>
        /// <param name="custom">Cryptocurrency fee limits.</param>
        /// <param name="errors">errors.</param>
        /// <param name="customFeeRate">customFeeRate.</param>
        public CommissionResponseSimpleDto(
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
            )
        {
            this.Commission = commission;
            this.Fee = fee;
            this.FeeUnit = feeUnit;
            this.FeeFiat = feeFiat;
            this.FeeFiatUnit = feeFiatUnit;
            this.MaxAmount = maxAmount;
            this.Plan = plan;
            this.UseWallet = useWallet;
            this.UseWalletBalance = useWalletBalance;
            this.Plans = plans;
            this.Custom = custom;
            this.Errors = errors;
            this.CustomFeeRate = customFeeRate;
        }
        
        /// <summary>
        /// Plisio commission value
        /// </summary>
        /// <value>Plisio commission value</value>
        [DataMember(Name="commission", EmitDefaultValue=false)]
        public string Commission { get; set; }

        /// <summary>
        /// Cryptocurrency fee value
        /// </summary>
        /// <value>Cryptocurrency fee value</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// Cryptocurrency feeUnit value
        /// </summary>
        /// <value>Cryptocurrency feeUnit value</value>
        [DataMember(Name="feeUnit", EmitDefaultValue=false)]
        public string FeeUnit { get; set; }

        /// <summary>
        /// Cryptocurrency fee value in selected fiat currency
        /// </summary>
        /// <value>Cryptocurrency fee value in selected fiat currency</value>
        [DataMember(Name="feeFiat", EmitDefaultValue=false)]
        public string FeeFiat { get; set; }

        /// <summary>
        /// Selected fiat currency
        /// </summary>
        /// <value>Selected fiat currency</value>
        [DataMember(Name="feeFiatUnit", EmitDefaultValue=false)]
        public string FeeFiatUnit { get; set; }

        /// <summary>
        /// Maximum allowed amount to withdrawal
        /// </summary>
        /// <value>Maximum allowed amount to withdrawal</value>
        [DataMember(Name="maxAmount", EmitDefaultValue=false)]
        public string MaxAmount { get; set; }

        /// <summary>
        /// Plisio&#x27;s cryptocurrency fee estimation plan
        /// </summary>
        /// <value>Plisio&#x27;s cryptocurrency fee estimation plan</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// Pay fee from wallet
        /// </summary>
        /// <value>Pay fee from wallet</value>
        [DataMember(Name="useWallet", EmitDefaultValue=false)]
        public string UseWallet { get; set; }

        /// <summary>
        /// Balance of wallet that will be used to pay fee
        /// </summary>
        /// <value>Balance of wallet that will be used to pay fee</value>
        [DataMember(Name="useWalletBalance", EmitDefaultValue=false)]
        public string UseWalletBalance { get; set; }

        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public FeeSimplePlanDto Plans { get; set; }

        /// <summary>
        /// Cryptocurrency fee limits
        /// </summary>
        /// <value>Cryptocurrency fee limits</value>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public List<FeePlanCustomDto> Custom { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<CommissionResponseSimpleErrorDto> Errors { get; set; }

        /// <summary>
        /// Gets or Sets CustomFeeRate
        /// </summary>
        [DataMember(Name="customFeeRate", EmitDefaultValue=false)]
        public float? CustomFeeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionResponseSimpleDto {\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
            sb.Append("  FeeFiat: ").Append(FeeFiat).Append("\n");
            sb.Append("  FeeFiatUnit: ").Append(FeeFiatUnit).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  UseWallet: ").Append(UseWallet).Append("\n");
            sb.Append("  UseWalletBalance: ").Append(UseWalletBalance).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  CustomFeeRate: ").Append(CustomFeeRate).Append("\n");
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
            return this.Equals(input as CommissionResponseSimpleDto);
        }

        /// <summary>
        /// Returns true if CommissionResponseSimpleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionResponseSimpleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionResponseSimpleDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Commission == input.Commission ||
                    (this.Commission != null &&
                    this.Commission.Equals(input.Commission))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FeeUnit == input.FeeUnit ||
                    (this.FeeUnit != null &&
                    this.FeeUnit.Equals(input.FeeUnit))
                ) && 
                (
                    this.FeeFiat == input.FeeFiat ||
                    (this.FeeFiat != null &&
                    this.FeeFiat.Equals(input.FeeFiat))
                ) && 
                (
                    this.FeeFiatUnit == input.FeeFiatUnit ||
                    (this.FeeFiatUnit != null &&
                    this.FeeFiatUnit.Equals(input.FeeFiatUnit))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.UseWallet == input.UseWallet ||
                    (this.UseWallet != null &&
                    this.UseWallet.Equals(input.UseWallet))
                ) && 
                (
                    this.UseWalletBalance == input.UseWalletBalance ||
                    (this.UseWalletBalance != null &&
                    this.UseWalletBalance.Equals(input.UseWalletBalance))
                ) && 
                (
                    this.Plans == input.Plans ||
                    (this.Plans != null &&
                    this.Plans.Equals(input.Plans))
                ) && 
                (
                    this.Custom == input.Custom ||
                    this.Custom != null &&
                    input.Custom != null &&
                    this.Custom.SequenceEqual(input.Custom)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.CustomFeeRate == input.CustomFeeRate ||
                    (this.CustomFeeRate != null &&
                    this.CustomFeeRate.Equals(input.CustomFeeRate))
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
                if (this.Commission != null)
                    hashCode = hashCode * 59 + this.Commission.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.FeeUnit != null)
                    hashCode = hashCode * 59 + this.FeeUnit.GetHashCode();
                if (this.FeeFiat != null)
                    hashCode = hashCode * 59 + this.FeeFiat.GetHashCode();
                if (this.FeeFiatUnit != null)
                    hashCode = hashCode * 59 + this.FeeFiatUnit.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.UseWallet != null)
                    hashCode = hashCode * 59 + this.UseWallet.GetHashCode();
                if (this.UseWalletBalance != null)
                    hashCode = hashCode * 59 + this.UseWalletBalance.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.CustomFeeRate != null)
                    hashCode = hashCode * 59 + this.CustomFeeRate.GetHashCode();
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

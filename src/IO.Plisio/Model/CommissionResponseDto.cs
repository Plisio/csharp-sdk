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
    /// CommissionResponseDto
    /// </summary>
    [DataContract]
        public partial class CommissionResponseDto :  IEquatable<CommissionResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionResponseDto" /> class.
        /// </summary>
        /// <param name="commission">Plisio commission value.</param>
        /// <param name="fee">Cryptocurrency fee value.</param>
        /// <param name="feeUnit">Cryptocurrency feeUnit value.</param>
        /// <param name="plan">Plisio&#x27;s cryptocurrency fee estimation plan.</param>
        /// <param name="useWallet">Pay fee from wallet.</param>
        /// <param name="useWalletBalance">Balance of wallet that will be used to pay fee.</param>
        /// <param name="plans">Cryptocurrency fee plans.</param>
        public CommissionResponseDto(
            string commission = default(string), 
            string fee = default(string), 
            string feeUnit = default(string), 
            string plan = default(string), 
            string useWallet = default(string), 
            string useWalletBalance = default(string), 
            List<FeePlanDto> plans = default(List<FeePlanDto>)
            )
        {
            this.Commission = commission;
            this.Fee = fee;
            this.FeeUnit = feeUnit;
            this.Plan = plan;
            this.UseWallet = useWallet;
            this.UseWalletBalance = useWalletBalance;
            this.Plans = plans;
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
        /// Cryptocurrency fee plans
        /// </summary>
        /// <value>Cryptocurrency fee plans</value>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<FeePlanDto> Plans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionResponseDto {\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  UseWallet: ").Append(UseWallet).Append("\n");
            sb.Append("  UseWalletBalance: ").Append(UseWalletBalance).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
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
            return this.Equals(input as CommissionResponseDto);
        }

        /// <summary>
        /// Returns true if CommissionResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionResponseDto input)
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
                    this.Plans != null &&
                    input.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans)
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
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.UseWallet != null)
                    hashCode = hashCode * 59 + this.UseWallet.GetHashCode();
                if (this.UseWalletBalance != null)
                    hashCode = hashCode * 59 + this.UseWalletBalance.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
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

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
    /// FeePlanEthDto
    /// </summary>
    [DataContract]
        public partial class FeePlanEthDto : FeePlanCommonDto,  IEquatable<FeePlanEthDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanEthDto" /> class.
        /// </summary>
        /// <param name="gasLimit">Ethereum gas limit.</param>
        /// <param name="gasPrice">Ethereum gas price.</param>
        /// <param name="value">Fee value.</param>
        /// <param name="feeUnit">Fee unit value.</param>
        /// <param name="nonce">Nonce param to update tx.</param>
        public FeePlanEthDto(
            float? gasLimit = default(float?),
            float? gasPrice = default(float?), 
            string value = default(string), 
            string feeUnit = default(string), 
            Object nonce = default(Object), 
            string key = default(string), 
            string name = default(string),
            string description = default(string)
            ) : base(key, name, description)
        {
            this.GasLimit = gasLimit;
            this.GasPrice = gasPrice;
            this.Value = value;
            this.FeeUnit = feeUnit;
            this.Nonce = nonce;
        }
        
        /// <summary>
        /// Ethereum gas limit
        /// </summary>
        /// <value>Ethereum gas limit</value>
        [DataMember(Name="gasLimit", EmitDefaultValue=false)]
        public float? GasLimit { get; set; }

        /// <summary>
        /// Ethereum gas price
        /// </summary>
        /// <value>Ethereum gas price</value>
        [DataMember(Name="gasPrice", EmitDefaultValue=false)]
        public float? GasPrice { get; set; }

        /// <summary>
        /// Fee value
        /// </summary>
        /// <value>Fee value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Fee unit value
        /// </summary>
        /// <value>Fee unit value</value>
        [DataMember(Name="feeUnit", EmitDefaultValue=false)]
        public string FeeUnit { get; set; }

        /// <summary>
        /// Nonce param to update tx
        /// </summary>
        /// <value>Nonce param to update tx</value>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public Object Nonce { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanEthDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  FeeUnit: ").Append(FeeUnit).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as FeePlanEthDto);
        }

        /// <summary>
        /// Returns true if FeePlanEthDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanEthDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanEthDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && base.Equals(input) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
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
                ) && base.Equals(input) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
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
                if (this.GasLimit != null)
                    hashCode = hashCode * 59 + this.GasLimit.GetHashCode();
                if (this.GasPrice != null)
                    hashCode = hashCode * 59 + this.GasPrice.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.FeeUnit != null)
                    hashCode = hashCode * 59 + this.FeeUnit.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
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

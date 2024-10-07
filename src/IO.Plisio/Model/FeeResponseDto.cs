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
    /// FeeResponseDto
    /// </summary>
    [DataContract]
        public partial class FeeResponseDto :  IEquatable<FeeResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeResponseDto" /> class.
        /// </summary>
        /// <param name="fee">Fee value.</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="plan">normal or priority (https://plisio.net/documentation/endpoints/fee-plans).</param>
        public FeeResponseDto(string fee = default(string), string psysCid = default(string), string currency = default(string), string plan = default(string))
        {
            this.Fee = fee;
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.Plan = plan;
        }
        
        /// <summary>
        /// Fee value
        /// </summary>
        /// <value>Fee value</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
        /// </summary>
        /// <value>ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
        [DataMember(Name="psys_cid", EmitDefaultValue=false)]
        public string PsysCid { get; set; }

        /// <summary>
        /// Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
        /// </summary>
        /// <value>Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// normal or priority (https://plisio.net/documentation/endpoints/fee-plans)
        /// </summary>
        /// <value>normal or priority (https://plisio.net/documentation/endpoints/fee-plans)</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeResponseDto {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
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
            return this.Equals(input as FeeResponseDto);
        }

        /// <summary>
        /// Returns true if FeeResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeResponseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.PsysCid == input.PsysCid ||
                    (this.PsysCid != null &&
                    this.PsysCid.Equals(input.PsysCid))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
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
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.PsysCid != null)
                    hashCode = hashCode * 59 + this.PsysCid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
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

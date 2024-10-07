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
    /// BalanceResponseDto
    /// </summary>
    [DataContract]
        public partial class BalanceResponseDto :  IEquatable<BalanceResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseDto" /> class.
        /// </summary>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="balance">Balance in cryptocurrency.</param>
        public BalanceResponseDto(string psysCid = default(string), string currency = default(string), string balance = default(string))
        {
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.Balance = balance;
        }
        
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
        /// Balance in cryptocurrency
        /// </summary>
        /// <value>Balance in cryptocurrency</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceResponseDto {\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as BalanceResponseDto);
        }

        /// <summary>
        /// Returns true if BalanceResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceResponseDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.PsysCid != null)
                    hashCode = hashCode * 59 + this.PsysCid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
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

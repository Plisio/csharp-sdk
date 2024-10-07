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
    /// CommissionResponseSimpleErrorDto
    /// </summary>
    [DataContract]
        public partial class CommissionResponseSimpleErrorDto :  IEquatable<CommissionResponseSimpleErrorDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionResponseSimpleErrorDto" /> class.
        /// </summary>
        /// <param name="amount">Amount.</param>
        /// <param name="to">Plisio commission value.</param>
        /// <param name="balance">Balance in cryptocurrency.</param>
        /// <param name="cid">Cryptocurrency Plisio Abbr.</param>
        public CommissionResponseSimpleErrorDto(
            string amount = default(string), 
            string to = default(string), 
            string balance = default(string), 
            string cid = default(string)
            )
        {
            this.Amount = amount;
            this.To = to;
            this.Balance = balance;
            this.Cid = cid;
        }
        
        /// <summary>
        /// Amount
        /// </summary>
        /// <value>Amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Plisio commission value
        /// </summary>
        /// <value>Plisio commission value</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Balance in cryptocurrency
        /// </summary>
        /// <value>Balance in cryptocurrency</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Cryptocurrency Plisio Abbr
        /// </summary>
        /// <value>Cryptocurrency Plisio Abbr</value>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionResponseSimpleErrorDto {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
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
            return this.Equals(input as CommissionResponseSimpleErrorDto);
        }

        /// <summary>
        /// Returns true if CommissionResponseSimpleErrorDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionResponseSimpleErrorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionResponseSimpleErrorDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Cid == input.Cid ||
                    (this.Cid != null &&
                    this.Cid.Equals(input.Cid))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Cid != null)
                    hashCode = hashCode * 59 + this.Cid.GetHashCode();
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

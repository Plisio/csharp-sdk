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
    /// InvoicePaysysDto
    /// </summary>
    [DataContract]
        public partial class InvoicePaysysDto : PaysysDto,  IEquatable<InvoicePaysysDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaysysDto" /> class.
        /// </summary>
        /// <param name="amount">Invoice amount in this crypto.</param>
        public InvoicePaysysDto(
            string amount = default(string), 
            string name = default(string), 
            string cid = default(string), 
            string currency = default(string), 
            string icon = default(string), 
            string rateUsd = default(string), 
            string priceUsd = default(string), 
            string precision = default(string), 
            string outputPrecision = default(string), 
            Object fiat = default(Object), 
            Object fiatRate = default(Object), 
            Object minSumIn = default(Object), 
            string invoiceCommissionPercentage = default(string), 
            int? hidden = default(int?), 
            bool? maintenance = default(bool?), 
            Object contractOf = default(Object), 
            Object contractStandard = default(Object)
            ) : base(name, cid, currency, icon, rateUsd, priceUsd, precision, outputPrecision, fiat, fiatRate, minSumIn, invoiceCommissionPercentage, hidden, maintenance, contractOf, contractStandard)
        {
            this.Amount = amount;
        }
        
        /// <summary>
        /// Invoice amount in this crypto
        /// </summary>
        /// <value>Invoice amount in this crypto</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicePaysysDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as InvoicePaysysDto);
        }

        /// <summary>
        /// Returns true if InvoicePaysysDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicePaysysDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePaysysDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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

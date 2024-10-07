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
    /// InvoiceSimpleResponseDto
    /// </summary>
    [DataContract]
        public partial class InvoiceSimpleResponseDto :  IEquatable<InvoiceSimpleResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSimpleResponseDto" /> class.
        /// </summary>
        /// <param name="txnId">Plisio’s intertnal ID.</param>
        /// <param name="invoiceUrl">Invoice URL.</param>
        /// <param name="invoiceTotalSum">shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum.</param>
        public InvoiceSimpleResponseDto(string txnId = default(string), string invoiceUrl = default(string), string invoiceTotalSum = default(string))
        {
            this.TxnId = txnId;
            this.InvoiceUrl = invoiceUrl;
            this.InvoiceTotalSum = invoiceTotalSum;
        }
        
        /// <summary>
        /// Plisio’s intertnal ID
        /// </summary>
        /// <value>Plisio’s intertnal ID</value>
        [DataMember(Name="txn_id", EmitDefaultValue=false)]
        public string TxnId { get; set; }

        /// <summary>
        /// Invoice URL
        /// </summary>
        /// <value>Invoice URL</value>
        [DataMember(Name="invoice_url", EmitDefaultValue=false)]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum
        /// </summary>
        /// <value>shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum</value>
        [DataMember(Name="invoice_total_sum", EmitDefaultValue=false)]
        public string InvoiceTotalSum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceSimpleResponseDto {\n");
            sb.Append("  TxnId: ").Append(TxnId).Append("\n");
            sb.Append("  InvoiceUrl: ").Append(InvoiceUrl).Append("\n");
            sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
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
            return this.Equals(input as InvoiceSimpleResponseDto);
        }

        /// <summary>
        /// Returns true if InvoiceSimpleResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceSimpleResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceSimpleResponseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TxnId == input.TxnId ||
                    (this.TxnId != null &&
                    this.TxnId.Equals(input.TxnId))
                ) && 
                (
                    this.InvoiceUrl == input.InvoiceUrl ||
                    (this.InvoiceUrl != null &&
                    this.InvoiceUrl.Equals(input.InvoiceUrl))
                ) && 
                (
                    this.InvoiceTotalSum == input.InvoiceTotalSum ||
                    (this.InvoiceTotalSum != null &&
                    this.InvoiceTotalSum.Equals(input.InvoiceTotalSum))
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
                if (this.TxnId != null)
                    hashCode = hashCode * 59 + this.TxnId.GetHashCode();
                if (this.InvoiceUrl != null)
                    hashCode = hashCode * 59 + this.InvoiceUrl.GetHashCode();
                if (this.InvoiceTotalSum != null)
                    hashCode = hashCode * 59 + this.InvoiceTotalSum.GetHashCode();
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

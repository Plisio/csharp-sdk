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
    /// OperationSimpleDto
    /// </summary>
    [DataContract]
        public partial class OperationSimpleDto : InvoiceSimpleResponseDto,  IEquatable<OperationSimpleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationSimpleDto" /> class.
        /// </summary>
        /// <param name="shopId">Shop ID.</param>
        /// <param name="type">cash_in, cash_out, mass_cash_out, invoice.</param>
        /// <param name="status">pending, completed, error, new, expired, mismatch, cancelled.</param>
        /// <param name="txUrl">link to the cryptocurrency block explorer.</param>
        /// <param name="id">internal Plisio operation ID.</param>
        public OperationSimpleDto(
            string shopId = default(string), 
            string type = default(string), 
            string status = default(string), 
            string txUrl = default(string), 
            string id = default(string), 
            string txnId = default(string), 
            string invoiceUrl = default(string), 
            string invoiceTotalSum = default(string)
            ) : base(txnId, invoiceUrl, invoiceTotalSum)
        {
            this.ShopId = shopId;
            this.Type = type;
            this.Status = status;
            this.TxUrl = txUrl;
            this.Id = id;
        }
        
        /// <summary>
        /// Shop ID
        /// </summary>
        /// <value>Shop ID</value>
        [DataMember(Name="shop_id", EmitDefaultValue=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// cash_in, cash_out, mass_cash_out, invoice
        /// </summary>
        /// <value>cash_in, cash_out, mass_cash_out, invoice</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// pending, completed, error, new, expired, mismatch, cancelled
        /// </summary>
        /// <value>pending, completed, error, new, expired, mismatch, cancelled</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// link to the cryptocurrency block explorer
        /// </summary>
        /// <value>link to the cryptocurrency block explorer</value>
        [DataMember(Name="tx_url", EmitDefaultValue=false)]
        public string TxUrl { get; set; }

        /// <summary>
        /// internal Plisio operation ID
        /// </summary>
        /// <value>internal Plisio operation ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationSimpleDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as OperationSimpleDto);
        }

        /// <summary>
        /// Returns true if OperationSimpleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationSimpleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationSimpleDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TxUrl == input.TxUrl ||
                    (this.TxUrl != null &&
                    this.TxUrl.Equals(input.TxUrl))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ShopId != null)
                    hashCode = hashCode * 59 + this.ShopId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TxUrl != null)
                    hashCode = hashCode * 59 + this.TxUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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

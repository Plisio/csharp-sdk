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
    /// InvoiceDetailsResponseDto
    /// </summary>
    [DataContract]
        public partial class InvoiceDetailsResponseDto :  IEquatable<InvoiceDetailsResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDetailsResponseDto" /> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        /// <param name="activeInvoiceId">Current active invoice ID. Invoice ID with the last selected cryptocurrency.</param>
        /// <param name="shop">shop.</param>
        /// <param name="paysys">paysys.</param>
        /// <param name="allowedPsysCids">Allowed cryptocurrencies for select.</param>
        public InvoiceDetailsResponseDto(
            InvoiceExtendedResponseDto invoice = default(InvoiceExtendedResponseDto), 
            string activeInvoiceId = default(string), 
            ShopInfoDto shop = default(ShopInfoDto), 
            InvoicePaysysDto paysys = default(InvoicePaysysDto), 
            List<InvoicePaysysDto> allowedPsysCids = default(List<InvoicePaysysDto>)
            )
        {
            this.Invoice = invoice;
            this.ActiveInvoiceId = activeInvoiceId;
            this.Shop = shop;
            this.Paysys = paysys;
            this.AllowedPsysCids = allowedPsysCids;
        }
        
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public InvoiceExtendedResponseDto Invoice { get; set; }

        /// <summary>
        /// Current active invoice ID. Invoice ID with the last selected cryptocurrency
        /// </summary>
        /// <value>Current active invoice ID. Invoice ID with the last selected cryptocurrency</value>
        [DataMember(Name="active_invoice_id", EmitDefaultValue=false)]
        public string ActiveInvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=false)]
        public ShopInfoDto Shop { get; set; }

        /// <summary>
        /// Gets or Sets Paysys
        /// </summary>
        [DataMember(Name="paysys", EmitDefaultValue=false)]
        public InvoicePaysysDto Paysys { get; set; }

        /// <summary>
        /// Allowed cryptocurrencies for select
        /// </summary>
        /// <value>Allowed cryptocurrencies for select</value>
        [DataMember(Name="allowed_psys_cids", EmitDefaultValue=false)]
        public List<InvoicePaysysDto> AllowedPsysCids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceDetailsResponseDto {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  ActiveInvoiceId: ").Append(ActiveInvoiceId).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  Paysys: ").Append(Paysys).Append("\n");
            sb.Append("  AllowedPsysCids: ").Append(AllowedPsysCids).Append("\n");
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
            return this.Equals(input as InvoiceDetailsResponseDto);
        }

        /// <summary>
        /// Returns true if InvoiceDetailsResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceDetailsResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceDetailsResponseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.ActiveInvoiceId == input.ActiveInvoiceId ||
                    (this.ActiveInvoiceId != null &&
                    this.ActiveInvoiceId.Equals(input.ActiveInvoiceId))
                ) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
                ) && 
                (
                    this.Paysys == input.Paysys ||
                    (this.Paysys != null &&
                    this.Paysys.Equals(input.Paysys))
                ) && 
                (
                    this.AllowedPsysCids == input.AllowedPsysCids ||
                    this.AllowedPsysCids != null &&
                    input.AllowedPsysCids != null &&
                    this.AllowedPsysCids.SequenceEqual(input.AllowedPsysCids)
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
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.ActiveInvoiceId != null)
                    hashCode = hashCode * 59 + this.ActiveInvoiceId.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                if (this.Paysys != null)
                    hashCode = hashCode * 59 + this.Paysys.GetHashCode();
                if (this.AllowedPsysCids != null)
                    hashCode = hashCode * 59 + this.AllowedPsysCids.GetHashCode();
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

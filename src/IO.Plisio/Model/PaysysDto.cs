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
    /// PaysysDto
    /// </summary>
    [DataContract]
        public partial class PaysysDto :  IEquatable<PaysysDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaysysDto" /> class.
        /// </summary>
        /// <param name="name">Cryptocurrency name.</param>
        /// <param name="cid">Cryptocurrency Plisio Abbr.</param>
        /// <param name="currency">Cryptocurrency Abbr.</param>
        /// <param name="icon">Cryptocurrency icon.</param>
        /// <param name="rateUsd">Cryptocurrency USD rate.</param>
        /// <param name="priceUsd">Cryptocurrency USD price.</param>
        /// <param name="precision">Cryptocurrency precision.</param>
        /// <param name="outputPrecision">Cryptocurrency output precision.</param>
        /// <param name="fiat">Fiat abbr.</param>
        /// <param name="fiatRate">Cryptocurrency fiat rate (default USD).</param>
        /// <param name="minSumIn">Invoice amount minimum.</param>
        /// <param name="invoiceCommissionPercentage">Plisio commission percentage.</param>
        /// <param name="hidden">Is cryptocurrency enabled (1 - disable, 0 - enabled).</param>
        /// <param name="maintenance">Cryptocurrency node temporary on maintenance.</param>
        /// <param name="contractOf">Pay fee from another crypto.</param>
        /// <param name="contractStandard">Standard of contract.</param>
        public PaysysDto(
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
            )
        {
            this.Name = name;
            this.Cid = cid;
            this.Currency = currency;
            this.Icon = icon;
            this.RateUsd = rateUsd;
            this.PriceUsd = priceUsd;
            this.Precision = precision;
            this.OutputPrecision = outputPrecision;
            this.Fiat = fiat;
            this.FiatRate = fiatRate;
            this.MinSumIn = minSumIn;
            this.InvoiceCommissionPercentage = invoiceCommissionPercentage;
            this.Hidden = hidden;
            this.Maintenance = maintenance;
            this.ContractOf = contractOf;
            this.ContractStandard = contractStandard;
        }
        
        /// <summary>
        /// Cryptocurrency name
        /// </summary>
        /// <value>Cryptocurrency name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Cryptocurrency Plisio Abbr
        /// </summary>
        /// <value>Cryptocurrency Plisio Abbr</value>
        [DataMember(Name="cid", EmitDefaultValue=false)]
        public string Cid { get; set; }

        /// <summary>
        /// Cryptocurrency Abbr
        /// </summary>
        /// <value>Cryptocurrency Abbr</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Cryptocurrency icon
        /// </summary>
        /// <value>Cryptocurrency icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Cryptocurrency USD rate
        /// </summary>
        /// <value>Cryptocurrency USD rate</value>
        [DataMember(Name="rate_usd", EmitDefaultValue=false)]
        public string RateUsd { get; set; }

        /// <summary>
        /// Cryptocurrency USD price
        /// </summary>
        /// <value>Cryptocurrency USD price</value>
        [DataMember(Name="price_usd", EmitDefaultValue=false)]
        public string PriceUsd { get; set; }

        /// <summary>
        /// Cryptocurrency precision
        /// </summary>
        /// <value>Cryptocurrency precision</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public string Precision { get; set; }

        /// <summary>
        /// Cryptocurrency output precision
        /// </summary>
        /// <value>Cryptocurrency output precision</value>
        [DataMember(Name="output_precision", EmitDefaultValue=false)]
        public string OutputPrecision { get; set; }

        /// <summary>
        /// Fiat abbr
        /// </summary>
        /// <value>Fiat abbr</value>
        [DataMember(Name="fiat", EmitDefaultValue=false)]
        public Object Fiat { get; set; }

        /// <summary>
        /// Cryptocurrency fiat rate (default USD)
        /// </summary>
        /// <value>Cryptocurrency fiat rate (default USD)</value>
        [DataMember(Name="fiat_rate", EmitDefaultValue=false)]
        public Object FiatRate { get; set; }

        /// <summary>
        /// Invoice amount minimum
        /// </summary>
        /// <value>Invoice amount minimum</value>
        [DataMember(Name="min_sum_in", EmitDefaultValue=false)]
        public Object MinSumIn { get; set; }

        /// <summary>
        /// Plisio commission percentage
        /// </summary>
        /// <value>Plisio commission percentage</value>
        [DataMember(Name="invoice_commission_percentage", EmitDefaultValue=false)]
        public string InvoiceCommissionPercentage { get; set; }

        /// <summary>
        /// Is cryptocurrency enabled (1 - disable, 0 - enabled)
        /// </summary>
        /// <value>Is cryptocurrency enabled (1 - disable, 0 - enabled)</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public int? Hidden { get; set; }

        /// <summary>
        /// Cryptocurrency node temporary on maintenance
        /// </summary>
        /// <value>Cryptocurrency node temporary on maintenance</value>
        [DataMember(Name="maintenance", EmitDefaultValue=false)]
        public bool? Maintenance { get; set; }

        /// <summary>
        /// Pay fee from another crypto
        /// </summary>
        /// <value>Pay fee from another crypto</value>
        [DataMember(Name="contractOf", EmitDefaultValue=false)]
        public Object ContractOf { get; set; }

        /// <summary>
        /// Standard of contract
        /// </summary>
        /// <value>Standard of contract</value>
        [DataMember(Name="contractStandard", EmitDefaultValue=false)]
        public Object ContractStandard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaysysDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  RateUsd: ").Append(RateUsd).Append("\n");
            sb.Append("  PriceUsd: ").Append(PriceUsd).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  OutputPrecision: ").Append(OutputPrecision).Append("\n");
            sb.Append("  Fiat: ").Append(Fiat).Append("\n");
            sb.Append("  FiatRate: ").Append(FiatRate).Append("\n");
            sb.Append("  MinSumIn: ").Append(MinSumIn).Append("\n");
            sb.Append("  InvoiceCommissionPercentage: ").Append(InvoiceCommissionPercentage).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Maintenance: ").Append(Maintenance).Append("\n");
            sb.Append("  ContractOf: ").Append(ContractOf).Append("\n");
            sb.Append("  ContractStandard: ").Append(ContractStandard).Append("\n");
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
            return this.Equals(input as PaysysDto);
        }

        /// <summary>
        /// Returns true if PaysysDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PaysysDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaysysDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Cid == input.Cid ||
                    (this.Cid != null &&
                    this.Cid.Equals(input.Cid))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.RateUsd == input.RateUsd ||
                    (this.RateUsd != null &&
                    this.RateUsd.Equals(input.RateUsd))
                ) && 
                (
                    this.PriceUsd == input.PriceUsd ||
                    (this.PriceUsd != null &&
                    this.PriceUsd.Equals(input.PriceUsd))
                ) && 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
                ) && 
                (
                    this.OutputPrecision == input.OutputPrecision ||
                    (this.OutputPrecision != null &&
                    this.OutputPrecision.Equals(input.OutputPrecision))
                ) && 
                (
                    this.Fiat == input.Fiat ||
                    (this.Fiat != null &&
                    this.Fiat.Equals(input.Fiat))
                ) && 
                (
                    this.FiatRate == input.FiatRate ||
                    (this.FiatRate != null &&
                    this.FiatRate.Equals(input.FiatRate))
                ) && 
                (
                    this.MinSumIn == input.MinSumIn ||
                    (this.MinSumIn != null &&
                    this.MinSumIn.Equals(input.MinSumIn))
                ) && 
                (
                    this.InvoiceCommissionPercentage == input.InvoiceCommissionPercentage ||
                    (this.InvoiceCommissionPercentage != null &&
                    this.InvoiceCommissionPercentage.Equals(input.InvoiceCommissionPercentage))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Maintenance == input.Maintenance ||
                    (this.Maintenance != null &&
                    this.Maintenance.Equals(input.Maintenance))
                ) && 
                (
                    this.ContractOf == input.ContractOf ||
                    (this.ContractOf != null &&
                    this.ContractOf.Equals(input.ContractOf))
                ) && 
                (
                    this.ContractStandard == input.ContractStandard ||
                    (this.ContractStandard != null &&
                    this.ContractStandard.Equals(input.ContractStandard))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cid != null)
                    hashCode = hashCode * 59 + this.Cid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.RateUsd != null)
                    hashCode = hashCode * 59 + this.RateUsd.GetHashCode();
                if (this.PriceUsd != null)
                    hashCode = hashCode * 59 + this.PriceUsd.GetHashCode();
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.OutputPrecision != null)
                    hashCode = hashCode * 59 + this.OutputPrecision.GetHashCode();
                if (this.Fiat != null)
                    hashCode = hashCode * 59 + this.Fiat.GetHashCode();
                if (this.FiatRate != null)
                    hashCode = hashCode * 59 + this.FiatRate.GetHashCode();
                if (this.MinSumIn != null)
                    hashCode = hashCode * 59 + this.MinSumIn.GetHashCode();
                if (this.InvoiceCommissionPercentage != null)
                    hashCode = hashCode * 59 + this.InvoiceCommissionPercentage.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Maintenance != null)
                    hashCode = hashCode * 59 + this.Maintenance.GetHashCode();
                if (this.ContractOf != null)
                    hashCode = hashCode * 59 + this.ContractOf.GetHashCode();
                if (this.ContractStandard != null)
                    hashCode = hashCode * 59 + this.ContractStandard.GetHashCode();
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

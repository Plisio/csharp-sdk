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
    /// OperationParamsDto
    /// </summary>
    [DataContract]
        public partial class OperationParamsDto :  IEquatable<OperationParamsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationParamsDto" /> class.
        /// </summary>
        /// <param name="fee">fee.</param>
        /// <param name="orderNumber">Invoice order number. Must be unique number in your store for each new store&#x60;s order!!!.</param>
        /// <param name="orderName">Order name.</param>
        /// <param name="description">Order description.</param>
        /// <param name="sourceAmount">Invoice amount in fiat currency.</param>
        /// <param name="sourceCurrency">Invoice fiat currency.</param>
        /// <param name="value">fee value.</param>
        /// <param name="avatar">Custom invoice avatar.</param>
        /// <param name="store">Custom invoice store name.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="amount">Invoice amount in selected cryptocurrency.</param>
        /// <param name="sourceRate">Cryptocurrency rate.</param>
        /// <param name="email">Email of payer.</param>
        /// <param name="donateHash">Donation hash.</param>
        public OperationParamsDto(
            FeeParamsDto fee = default(FeeParamsDto), 
            string orderNumber = default(string), 
            string orderName = default(string), 
            string description = default(string), 
            string sourceAmount = default(string),
            string sourceCurrency = default(string), 
            string value = default(string),
            string avatar = default(string), 
            string store = default(string), 
            string currency = default(string),
            string psysCid = default(string),
            string amount = default(string),
            string sourceRate = default(string),
            string email = default(string),
            string donateHash = default(string)
            )
        {
            this.Fee = fee;
            this.OrderNumber = orderNumber;
            this.OrderName = orderName;
            this.Description = description;
            this.SourceAmount = sourceAmount;
            this.SourceCurrency = sourceCurrency;
            this.Value = value;
            this.Avatar = avatar;
            this.Store = store;
            this.Currency = currency;
            this.PsysCid = psysCid;
            this.Amount = amount;
            this.SourceRate = sourceRate;
            this.Email = email;
            this.DonateHash = donateHash;
        }
        
        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public FeeParamsDto Fee { get; set; }

        /// <summary>
        /// Invoice order number. Must be unique number in your store for each new store&#x60;s order!!!
        /// </summary>
        /// <value>Invoice order number. Must be unique number in your store for each new store&#x60;s order!!!</value>
        [DataMember(Name="order_number", EmitDefaultValue=false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Order name
        /// </summary>
        /// <value>Order name</value>
        [DataMember(Name="order_name", EmitDefaultValue=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// Order description
        /// </summary>
        /// <value>Order description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Invoice amount in fiat currency
        /// </summary>
        /// <value>Invoice amount in fiat currency</value>
        [DataMember(Name="source_amount", EmitDefaultValue=false)]
        public string SourceAmount { get; set; }

        /// <summary>
        /// Invoice fiat currency
        /// </summary>
        /// <value>Invoice fiat currency</value>
        [DataMember(Name="source_currency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// fee value
        /// </summary>
        /// <value>fee value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Custom invoice avatar
        /// </summary>
        /// <value>Custom invoice avatar</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Custom invoice store name
        /// </summary>
        /// <value>Custom invoice store name</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public string Store { get; set; }

        /// <summary>
        /// Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
        /// </summary>
        /// <value>Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies
        /// </summary>
        /// <value>ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies</value>
        [DataMember(Name="psys_cid", EmitDefaultValue=false)]
        public string PsysCid { get; set; }

        /// <summary>
        /// Invoice amount in selected cryptocurrency
        /// </summary>
        /// <value>Invoice amount in selected cryptocurrency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Cryptocurrency rate
        /// </summary>
        /// <value>Cryptocurrency rate</value>
        [DataMember(Name="source_rate", EmitDefaultValue=false)]
        public string SourceRate { get; set; }

        /// <summary>
        /// Email of payer
        /// </summary>
        /// <value>Email of payer</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Donation hash
        /// </summary>
        /// <value>Donation hash</value>
        [DataMember(Name="donate_hash", EmitDefaultValue=false)]
        public string DonateHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationParamsDto {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  OrderName: ").Append(OrderName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SourceAmount: ").Append(SourceAmount).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DonateHash: ").Append(DonateHash).Append("\n");
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
            return this.Equals(input as OperationParamsDto);
        }

        /// <summary>
        /// Returns true if OperationParamsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationParamsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationParamsDto input)
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
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.OrderName == input.OrderName ||
                    (this.OrderName != null &&
                    this.OrderName.Equals(input.OrderName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SourceAmount == input.SourceAmount ||
                    (this.SourceAmount != null &&
                    this.SourceAmount.Equals(input.SourceAmount))
                ) && 
                (
                    this.SourceCurrency == input.SourceCurrency ||
                    (this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(input.SourceCurrency))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PsysCid == input.PsysCid ||
                    (this.PsysCid != null &&
                    this.PsysCid.Equals(input.PsysCid))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.SourceRate == input.SourceRate ||
                    (this.SourceRate != null &&
                    this.SourceRate.Equals(input.SourceRate))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.DonateHash == input.DonateHash ||
                    (this.DonateHash != null &&
                    this.DonateHash.Equals(input.DonateHash))
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
                if (this.OrderNumber != null)
                    hashCode = hashCode * 59 + this.OrderNumber.GetHashCode();
                if (this.OrderName != null)
                    hashCode = hashCode * 59 + this.OrderName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceAmount != null)
                    hashCode = hashCode * 59 + this.SourceAmount.GetHashCode();
                if (this.SourceCurrency != null)
                    hashCode = hashCode * 59 + this.SourceCurrency.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.PsysCid != null)
                    hashCode = hashCode * 59 + this.PsysCid.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.SourceRate != null)
                    hashCode = hashCode * 59 + this.SourceRate.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DonateHash != null)
                    hashCode = hashCode * 59 + this.DonateHash.GetHashCode();
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

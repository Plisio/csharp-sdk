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
    /// InvoiceCallbackExtendedResponseDto
    /// </summary>
    [DataContract]
        public partial class InvoiceCallbackExtendedResponseDto : InvoiceExtendedResponseDto,  IEquatable<InvoiceCallbackExtendedResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceCallbackExtendedResponseDto" /> class.
        /// </summary>
        /// <param name="amount">Invoice amount in the selected cryptocurrency.</param>
        /// <param name="pendingAmount">Remained amount in the selected cryptocurrency.</param>
        /// <param name="walletHash">Invoice hash.</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="sourceCurrency">Fiat currency - only USD available for the moment.</param>
        /// <param name="sourceRate">Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer.</param>
        /// <param name="expectedConfirmations">How many confirmations expected to mark invoice completed.</param>
        /// <param name="qrCode">QR code image in base64 format.</param>
        /// <param name="verifyHash">Hash to verify the “POST” data signed with your SHOP_API_KEY.</param>
        /// <param name="invoiceCommission">Plisio commission.</param>
        /// <param name="invoiceSum">shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount.</param>
        /// <param name="invoiceTotalSum">shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum.</param>
        public InvoiceCallbackExtendedResponseDto(
            string amount = default(string), 
            string pendingAmount = default(string), 
            string walletHash = default(string), 
            string psysCid = default(string), 
            string currency = default(string), 
            string sourceCurrency = default(string), 
            string sourceRate = default(string), 
            string expectedConfirmations = default(string), 
            string qrCode = default(string), 
            string verifyHash = default(string), 
            string invoiceCommission = default(string), 
            string invoiceSum = default(string), 
            string invoiceTotalSum = default(string), 
            string id = default(string), 
            string receivedAmount = default(string), 
            string remainingAmount = default(string), 
            bool? emailAlreadySet = default(bool?), 
            string txUrl = default(string), 
            List<string> txId = default(List<string>), 
            string switchId = default(string), 
            string paidId = default(string), 
            OperationParamsDto _params = default(OperationParamsDto), 
            string viewKey = default(string)
            ) : base(id, amount, receivedAmount, pendingAmount, remainingAmount, walletHash, psysCid, currency, sourceCurrency, sourceRate, expectedConfirmations, invoiceCommission, invoiceSum, invoiceTotalSum, emailAlreadySet, txUrl, txId, switchId, paidId, _params, viewKey)
        {
            this.Amount = amount;
            this.PendingAmount = pendingAmount;
            this.WalletHash = walletHash;
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.SourceCurrency = sourceCurrency;
            this.SourceRate = sourceRate;
            this.ExpectedConfirmations = expectedConfirmations;
            this.QrCode = qrCode;
            this.VerifyHash = verifyHash;
            this.InvoiceCommission = invoiceCommission;
            this.InvoiceSum = invoiceSum;
            this.InvoiceTotalSum = invoiceTotalSum;
        }
        
        /// <summary>
        /// Invoice amount in the selected cryptocurrency
        /// </summary>
        /// <value>Invoice amount in the selected cryptocurrency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Remained amount in the selected cryptocurrency
        /// </summary>
        /// <value>Remained amount in the selected cryptocurrency</value>
        [DataMember(Name="pending_amount", EmitDefaultValue=false)]
        public string PendingAmount { get; set; }

        /// <summary>
        /// Invoice hash
        /// </summary>
        /// <value>Invoice hash</value>
        [DataMember(Name="wallet_hash", EmitDefaultValue=false)]
        public string WalletHash { get; set; }

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
        /// Fiat currency - only USD available for the moment
        /// </summary>
        /// <value>Fiat currency - only USD available for the moment</value>
        [DataMember(Name="source_currency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer
        /// </summary>
        /// <value>Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer</value>
        [DataMember(Name="source_rate", EmitDefaultValue=false)]
        public string SourceRate { get; set; }

        /// <summary>
        /// How many confirmations expected to mark invoice completed
        /// </summary>
        /// <value>How many confirmations expected to mark invoice completed</value>
        [DataMember(Name="expected_confirmations", EmitDefaultValue=false)]
        public string ExpectedConfirmations { get; set; }

        /// <summary>
        /// QR code image in base64 format
        /// </summary>
        /// <value>QR code image in base64 format</value>
        [DataMember(Name="qr_code", EmitDefaultValue=false)]
        public string QrCode { get; set; }

        /// <summary>
        /// Hash to verify the “POST” data signed with your SHOP_API_KEY
        /// </summary>
        /// <value>Hash to verify the “POST” data signed with your SHOP_API_KEY</value>
        [DataMember(Name="verify_hash", EmitDefaultValue=false)]
        public string VerifyHash { get; set; }

        /// <summary>
        /// Plisio commission
        /// </summary>
        /// <value>Plisio commission</value>
        [DataMember(Name="invoice_commission", EmitDefaultValue=false)]
        public string InvoiceCommission { get; set; }

        /// <summary>
        /// shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount
        /// </summary>
        /// <value>shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount</value>
        [DataMember(Name="invoice_sum", EmitDefaultValue=false)]
        public string InvoiceSum { get; set; }

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
            sb.Append("class InvoiceCallbackExtendedResponseDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PendingAmount: ").Append(PendingAmount).Append("\n");
            sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
            sb.Append("  ExpectedConfirmations: ").Append(ExpectedConfirmations).Append("\n");
            sb.Append("  QrCode: ").Append(QrCode).Append("\n");
            sb.Append("  VerifyHash: ").Append(VerifyHash).Append("\n");
            sb.Append("  InvoiceCommission: ").Append(InvoiceCommission).Append("\n");
            sb.Append("  InvoiceSum: ").Append(InvoiceSum).Append("\n");
            sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
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
            return this.Equals(input as InvoiceCallbackExtendedResponseDto);
        }

        /// <summary>
        /// Returns true if InvoiceCallbackExtendedResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceCallbackExtendedResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceCallbackExtendedResponseDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.PendingAmount == input.PendingAmount ||
                    (this.PendingAmount != null &&
                    this.PendingAmount.Equals(input.PendingAmount))
                ) && base.Equals(input) && 
                (
                    this.WalletHash == input.WalletHash ||
                    (this.WalletHash != null &&
                    this.WalletHash.Equals(input.WalletHash))
                ) && base.Equals(input) && 
                (
                    this.PsysCid == input.PsysCid ||
                    (this.PsysCid != null &&
                    this.PsysCid.Equals(input.PsysCid))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.SourceCurrency == input.SourceCurrency ||
                    (this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(input.SourceCurrency))
                ) && base.Equals(input) && 
                (
                    this.SourceRate == input.SourceRate ||
                    (this.SourceRate != null &&
                    this.SourceRate.Equals(input.SourceRate))
                ) && base.Equals(input) && 
                (
                    this.ExpectedConfirmations == input.ExpectedConfirmations ||
                    (this.ExpectedConfirmations != null &&
                    this.ExpectedConfirmations.Equals(input.ExpectedConfirmations))
                ) && base.Equals(input) && 
                (
                    this.QrCode == input.QrCode ||
                    (this.QrCode != null &&
                    this.QrCode.Equals(input.QrCode))
                ) && base.Equals(input) && 
                (
                    this.VerifyHash == input.VerifyHash ||
                    (this.VerifyHash != null &&
                    this.VerifyHash.Equals(input.VerifyHash))
                ) && base.Equals(input) && 
                (
                    this.InvoiceCommission == input.InvoiceCommission ||
                    (this.InvoiceCommission != null &&
                    this.InvoiceCommission.Equals(input.InvoiceCommission))
                ) && base.Equals(input) && 
                (
                    this.InvoiceSum == input.InvoiceSum ||
                    (this.InvoiceSum != null &&
                    this.InvoiceSum.Equals(input.InvoiceSum))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PendingAmount != null)
                    hashCode = hashCode * 59 + this.PendingAmount.GetHashCode();
                if (this.WalletHash != null)
                    hashCode = hashCode * 59 + this.WalletHash.GetHashCode();
                if (this.PsysCid != null)
                    hashCode = hashCode * 59 + this.PsysCid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.SourceCurrency != null)
                    hashCode = hashCode * 59 + this.SourceCurrency.GetHashCode();
                if (this.SourceRate != null)
                    hashCode = hashCode * 59 + this.SourceRate.GetHashCode();
                if (this.ExpectedConfirmations != null)
                    hashCode = hashCode * 59 + this.ExpectedConfirmations.GetHashCode();
                if (this.QrCode != null)
                    hashCode = hashCode * 59 + this.QrCode.GetHashCode();
                if (this.VerifyHash != null)
                    hashCode = hashCode * 59 + this.VerifyHash.GetHashCode();
                if (this.InvoiceCommission != null)
                    hashCode = hashCode * 59 + this.InvoiceCommission.GetHashCode();
                if (this.InvoiceSum != null)
                    hashCode = hashCode * 59 + this.InvoiceSum.GetHashCode();
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

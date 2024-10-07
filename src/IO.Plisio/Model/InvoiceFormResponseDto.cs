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
    /// InvoiceFormResponseDto
    /// </summary>
    [DataContract]
        public partial class InvoiceFormResponseDto : InvoiceSimpleResponseDto,  IEquatable<InvoiceFormResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceFormResponseDto" /> class.
        /// </summary>
        /// <param name="id">Plisio’s intertnal ID (copy of txn_id).</param>
        /// <param name="amount">Invoice amount in the selected cryptocurrency.</param>
        /// <param name="receivedAmount">Received and approved amount in the selected cryptocurrency.</param>
        /// <param name="pendingAmount">Pending (not approve) amount in the selected cryptocurrency.</param>
        /// <param name="remainingAmount">Remaining amount in the selected cryptocurrency.</param>
        /// <param name="walletHash">Invoice hash.</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="sourceCurrency">Fiat currency - only USD available for the moment.</param>
        /// <param name="sourceRate">Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer.</param>
        /// <param name="expectedConfirmations">How many confirmations expected to mark invoice completed.</param>
        /// <param name="invoiceCommission">Plisio commission.</param>
        /// <param name="invoiceSum">shop pays commission: invoice amount - invoice_commission client pays commission: invoice amount.</param>
        /// <param name="invoiceTotalSum">shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum.</param>
        /// <param name="emailAlreadySet">If email has been set.</param>
        /// <param name="txUrl">link to the cryptocurrency block explorer.</param>
        /// <param name="txId">array of transaction ids.</param>
        /// <param name="switchId">Initial invoice ID.</param>
        /// <param name="paidId">ID of invoice that has money.</param>
        /// <param name="_params">_params.</param>
        /// <param name="donateHash">Donation hash.</param>
        /// <param name="returnUrl">Invoice return url.</param>
        /// <param name="psysCidUnsupported">True when psys_cid not in supported by shop.</param>
        public InvoiceFormResponseDto(
            string id = default(string), 
            string amount = default(string), 
            string receivedAmount = default(string), 
            string pendingAmount = default(string), 
            string remainingAmount = default(string), 
            string walletHash = default(string), 
            string psysCid = default(string), 
            string currency = default(string), 
            string sourceCurrency = default(string), 
            string sourceRate = default(string), 
            string expectedConfirmations = default(string), 
            string invoiceCommission = default(string), 
            string invoiceSum = default(string), 
            string invoiceTotalSum = default(string), 
            bool? emailAlreadySet = default(bool?), 
            string txUrl = default(string), 
            List<string> txId = default(List<string>), 
            string switchId = default(string), 
            string paidId = default(string), 
            OperationParamsDto _params = default(OperationParamsDto), 
            string donateHash = default(string), 
            string returnUrl = default(string), 
            bool? psysCidUnsupported = default(bool?), 
            string txnId = default(string), 
            string invoiceUrl = default(string)
            ) : base(txnId, invoiceUrl, invoiceTotalSum)
        {
            this.Id = id;
            this.Amount = amount;
            this.ReceivedAmount = receivedAmount;
            this.PendingAmount = pendingAmount;
            this.RemainingAmount = remainingAmount;
            this.WalletHash = walletHash;
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.SourceCurrency = sourceCurrency;
            this.SourceRate = sourceRate;
            this.ExpectedConfirmations = expectedConfirmations;
            this.InvoiceCommission = invoiceCommission;
            this.InvoiceSum = invoiceSum;
            this.InvoiceTotalSum = invoiceTotalSum;
            this.EmailAlreadySet = emailAlreadySet;
            this.TxUrl = txUrl;
            this.TxId = txId;
            this.SwitchId = switchId;
            this.PaidId = paidId;
            this._Params = _params;
            this.DonateHash = donateHash;
            this.ReturnUrl = returnUrl;
            this.PsysCidUnsupported = psysCidUnsupported;
        }
        
        /// <summary>
        /// Plisio’s intertnal ID (copy of txn_id)
        /// </summary>
        /// <value>Plisio’s intertnal ID (copy of txn_id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Invoice amount in the selected cryptocurrency
        /// </summary>
        /// <value>Invoice amount in the selected cryptocurrency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Received and approved amount in the selected cryptocurrency
        /// </summary>
        /// <value>Received and approved amount in the selected cryptocurrency</value>
        [DataMember(Name="received_amount", EmitDefaultValue=false)]
        public string ReceivedAmount { get; set; }

        /// <summary>
        /// Pending (not approve) amount in the selected cryptocurrency
        /// </summary>
        /// <value>Pending (not approve) amount in the selected cryptocurrency</value>
        [DataMember(Name="pending_amount", EmitDefaultValue=false)]
        public string PendingAmount { get; set; }

        /// <summary>
        /// Remaining amount in the selected cryptocurrency
        /// </summary>
        /// <value>Remaining amount in the selected cryptocurrency</value>
        [DataMember(Name="remaining_amount", EmitDefaultValue=false)]
        public string RemainingAmount { get; set; }

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
        /// If email has been set
        /// </summary>
        /// <value>If email has been set</value>
        [DataMember(Name="email_already_set", EmitDefaultValue=false)]
        public bool? EmailAlreadySet { get; set; }

        /// <summary>
        /// link to the cryptocurrency block explorer
        /// </summary>
        /// <value>link to the cryptocurrency block explorer</value>
        [DataMember(Name="tx_url", EmitDefaultValue=false)]
        public string TxUrl { get; set; }

        /// <summary>
        /// array of transaction ids
        /// </summary>
        /// <value>array of transaction ids</value>
        [DataMember(Name="tx_id", EmitDefaultValue=false)]
        public List<string> TxId { get; set; }

        /// <summary>
        /// Initial invoice ID
        /// </summary>
        /// <value>Initial invoice ID</value>
        [DataMember(Name="switch_id", EmitDefaultValue=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// ID of invoice that has money
        /// </summary>
        /// <value>ID of invoice that has money</value>
        [DataMember(Name="paid_id", EmitDefaultValue=false)]
        public string PaidId { get; set; }

        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public OperationParamsDto _Params { get; set; }

        /// <summary>
        /// Donation hash
        /// </summary>
        /// <value>Donation hash</value>
        [DataMember(Name="donate_hash", EmitDefaultValue=false)]
        public string DonateHash { get; set; }

        /// <summary>
        /// Invoice return url
        /// </summary>
        /// <value>Invoice return url</value>
        [DataMember(Name="return_url", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// True when psys_cid not in supported by shop
        /// </summary>
        /// <value>True when psys_cid not in supported by shop</value>
        [DataMember(Name="psys_cid_unsupported", EmitDefaultValue=false)]
        public bool? PsysCidUnsupported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceFormResponseDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ReceivedAmount: ").Append(ReceivedAmount).Append("\n");
            sb.Append("  PendingAmount: ").Append(PendingAmount).Append("\n");
            sb.Append("  RemainingAmount: ").Append(RemainingAmount).Append("\n");
            sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
            sb.Append("  ExpectedConfirmations: ").Append(ExpectedConfirmations).Append("\n");
            sb.Append("  InvoiceCommission: ").Append(InvoiceCommission).Append("\n");
            sb.Append("  InvoiceSum: ").Append(InvoiceSum).Append("\n");
            sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
            sb.Append("  EmailAlreadySet: ").Append(EmailAlreadySet).Append("\n");
            sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  SwitchId: ").Append(SwitchId).Append("\n");
            sb.Append("  PaidId: ").Append(PaidId).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  DonateHash: ").Append(DonateHash).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  PsysCidUnsupported: ").Append(PsysCidUnsupported).Append("\n");
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
            return this.Equals(input as InvoiceFormResponseDto);
        }

        /// <summary>
        /// Returns true if InvoiceFormResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceFormResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceFormResponseDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.ReceivedAmount == input.ReceivedAmount ||
                    (this.ReceivedAmount != null &&
                    this.ReceivedAmount.Equals(input.ReceivedAmount))
                ) && base.Equals(input) && 
                (
                    this.PendingAmount == input.PendingAmount ||
                    (this.PendingAmount != null &&
                    this.PendingAmount.Equals(input.PendingAmount))
                ) && base.Equals(input) && 
                (
                    this.RemainingAmount == input.RemainingAmount ||
                    (this.RemainingAmount != null &&
                    this.RemainingAmount.Equals(input.RemainingAmount))
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
                ) && base.Equals(input) && 
                (
                    this.EmailAlreadySet == input.EmailAlreadySet ||
                    (this.EmailAlreadySet != null &&
                    this.EmailAlreadySet.Equals(input.EmailAlreadySet))
                ) && base.Equals(input) && 
                (
                    this.TxUrl == input.TxUrl ||
                    (this.TxUrl != null &&
                    this.TxUrl.Equals(input.TxUrl))
                ) && base.Equals(input) && 
                (
                    this.TxId == input.TxId ||
                    this.TxId != null &&
                    input.TxId != null &&
                    this.TxId.SequenceEqual(input.TxId)
                ) && base.Equals(input) && 
                (
                    this.SwitchId == input.SwitchId ||
                    (this.SwitchId != null &&
                    this.SwitchId.Equals(input.SwitchId))
                ) && base.Equals(input) && 
                (
                    this.PaidId == input.PaidId ||
                    (this.PaidId != null &&
                    this.PaidId.Equals(input.PaidId))
                ) && base.Equals(input) && 
                (
                    this._Params == input._Params ||
                    (this._Params != null &&
                    this._Params.Equals(input._Params))
                ) && base.Equals(input) && 
                (
                    this.DonateHash == input.DonateHash ||
                    (this.DonateHash != null &&
                    this.DonateHash.Equals(input.DonateHash))
                ) && base.Equals(input) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) && base.Equals(input) && 
                (
                    this.PsysCidUnsupported == input.PsysCidUnsupported ||
                    (this.PsysCidUnsupported != null &&
                    this.PsysCidUnsupported.Equals(input.PsysCidUnsupported))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ReceivedAmount != null)
                    hashCode = hashCode * 59 + this.ReceivedAmount.GetHashCode();
                if (this.PendingAmount != null)
                    hashCode = hashCode * 59 + this.PendingAmount.GetHashCode();
                if (this.RemainingAmount != null)
                    hashCode = hashCode * 59 + this.RemainingAmount.GetHashCode();
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
                if (this.InvoiceCommission != null)
                    hashCode = hashCode * 59 + this.InvoiceCommission.GetHashCode();
                if (this.InvoiceSum != null)
                    hashCode = hashCode * 59 + this.InvoiceSum.GetHashCode();
                if (this.InvoiceTotalSum != null)
                    hashCode = hashCode * 59 + this.InvoiceTotalSum.GetHashCode();
                if (this.EmailAlreadySet != null)
                    hashCode = hashCode * 59 + this.EmailAlreadySet.GetHashCode();
                if (this.TxUrl != null)
                    hashCode = hashCode * 59 + this.TxUrl.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.SwitchId != null)
                    hashCode = hashCode * 59 + this.SwitchId.GetHashCode();
                if (this.PaidId != null)
                    hashCode = hashCode * 59 + this.PaidId.GetHashCode();
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
                if (this.DonateHash != null)
                    hashCode = hashCode * 59 + this.DonateHash.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.PsysCidUnsupported != null)
                    hashCode = hashCode * 59 + this.PsysCidUnsupported.GetHashCode();
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

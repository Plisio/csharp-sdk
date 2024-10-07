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
    /// OperationDto
    /// </summary>
    [DataContract]
        public partial class OperationDto :  IEquatable<OperationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDto" /> class.
        /// </summary>
        /// <param name="userId">Profile ID.</param>
        /// <param name="shopId">Shop ID.</param>
        /// <param name="type">cash_in, cash_out, mass_cash_out, invoice.</param>
        /// <param name="status">pending, completed, error, new, expired, mismatch, cancelled.</param>
        /// <param name="pendingSum">unconfirmed amount (mempool).</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="sourceCurrency">fiat currency - USD by default or source_currency was set.</param>
        /// <param name="sourceRate">Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer.</param>
        /// <param name="fee">transaction fee stated in the transfer.</param>
        /// <param name="walletHash">destination hash (type&#x3D;cash_out) or invoice hash.</param>
        /// <param name="sendmany">Pairs of hashes and values (type&#x3D;mass_cash_out).</param>
        /// <param name="_params">_params.</param>
        /// <param name="expireAtUtc">timestamp in UTC timezone; it may need to be divided by 1000.</param>
        /// <param name="createdAtUtc">timestamp in the UTC timezone; it may need to be divided by 1000.</param>
        /// <param name="amount">amount received/transferred by an operation (invoice, cash-in/cash-out).</param>
        /// <param name="sum">Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount.</param>
        /// <param name="commission">Plisio commission.</param>
        /// <param name="txUrl">link to the cryptocurrency block explorer.</param>
        /// <param name="txId">array of transaction ids.</param>
        /// <param name="id">internal Plisio operation ID.</param>
        /// <param name="actualSum">Real incoming amount.</param>
        /// <param name="actualCommission">Plisio commission taken.</param>
        /// <param name="actualFee">Network fee (move invoice to wallet).</param>
        /// <param name="actualInvoiceSum">actual_sum - actual_commis_sim - actual_fee.</param>
        /// <param name="tx">array of transaction payment items.</param>
        /// <param name="confirmations">Number of confirmations of this transaction. We don&#x27;t update confirmation after operation is confirmed.</param>
        /// <param name="statusCode">Status code.</param>
        /// <param name="parentId">ID of parent invoice.</param>
        public OperationDto(
            string userId = default(string), 
            string shopId = default(string), 
            string type = default(string), 
            string status = default(string), 
            string pendingSum = default(string),
            string psysCid = default(string), 
            string currency = default(string), 
            string sourceCurrency = default(string), 
            string sourceRate = default(string), 
            string fee = default(string),
            string walletHash = default(string), 
            List<string> sendmany = default(List<string>), 
            OperationParamsDto _params = default(OperationParamsDto),
            int? expireAtUtc = default(int?), 
            int? createdAtUtc = default(int?), 
            string amount = default(string), 
            string sum = default(string), 
            string commission = default(string), 
            string txUrl = default(string), 
            List<string> txId = default(List<string>),
            string id = default(string), 
            string actualSum = default(string), 
            string actualCommission = default(string), 
            string actualFee = default(string), 
            string actualInvoiceSum = default(string), 
            List<Object> tx = default(List<Object>), 
            int? confirmations = default(int?),
            int? statusCode = default(int?), 
            string parentId = default(string)
            )
        {
            this.UserId = userId;
            this.ShopId = shopId;
            this.Type = type;
            this.Status = status;
            this.PendingSum = pendingSum;
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.SourceCurrency = sourceCurrency;
            this.SourceRate = sourceRate;
            this.Fee = fee;
            this.WalletHash = walletHash;
            this.Sendmany = sendmany;
            this._Params = _params;
            this.ExpireAtUtc = expireAtUtc;
            this.CreatedAtUtc = createdAtUtc;
            this.Amount = amount;
            this.Sum = sum;
            this.Commission = commission;
            this.TxUrl = txUrl;
            this.TxId = txId;
            this.Id = id;
            this.ActualSum = actualSum;
            this.ActualCommission = actualCommission;
            this.ActualFee = actualFee;
            this.ActualInvoiceSum = actualInvoiceSum;
            this.Tx = tx;
            this.Confirmations = confirmations;
            this.StatusCode = statusCode;
            this.ParentId = parentId;
        }
        
        /// <summary>
        /// Profile ID
        /// </summary>
        /// <value>Profile ID</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

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
        /// unconfirmed amount (mempool)
        /// </summary>
        /// <value>unconfirmed amount (mempool)</value>
        [DataMember(Name="pending_sum", EmitDefaultValue=false)]
        public string PendingSum { get; set; }

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
        /// fiat currency - USD by default or source_currency was set
        /// </summary>
        /// <value>fiat currency - USD by default or source_currency was set</value>
        [DataMember(Name="source_currency", EmitDefaultValue=false)]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer
        /// </summary>
        /// <value>Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer</value>
        [DataMember(Name="source_rate", EmitDefaultValue=false)]
        public string SourceRate { get; set; }

        /// <summary>
        /// transaction fee stated in the transfer
        /// </summary>
        /// <value>transaction fee stated in the transfer</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// destination hash (type&#x3D;cash_out) or invoice hash
        /// </summary>
        /// <value>destination hash (type&#x3D;cash_out) or invoice hash</value>
        [DataMember(Name="wallet_hash", EmitDefaultValue=false)]
        public string WalletHash { get; set; }

        /// <summary>
        /// Pairs of hashes and values (type&#x3D;mass_cash_out)
        /// </summary>
        /// <value>Pairs of hashes and values (type&#x3D;mass_cash_out)</value>
        [DataMember(Name="sendmany", EmitDefaultValue=false)]
        public List<string> Sendmany { get; set; }

        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public OperationParamsDto _Params { get; set; }

        /// <summary>
        /// timestamp in UTC timezone; it may need to be divided by 1000
        /// </summary>
        /// <value>timestamp in UTC timezone; it may need to be divided by 1000</value>
        [DataMember(Name="expire_at_utc", EmitDefaultValue=false)]
        public int? ExpireAtUtc { get; set; }

        /// <summary>
        /// timestamp in the UTC timezone; it may need to be divided by 1000
        /// </summary>
        /// <value>timestamp in the UTC timezone; it may need to be divided by 1000</value>
        [DataMember(Name="created_at_utc", EmitDefaultValue=false)]
        public int? CreatedAtUtc { get; set; }

        /// <summary>
        /// amount received/transferred by an operation (invoice, cash-in/cash-out)
        /// </summary>
        /// <value>amount received/transferred by an operation (invoice, cash-in/cash-out)</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount
        /// </summary>
        /// <value>Invoice: params.amount + Plisio commission (if customer pays commission) or params.amount (if merchant pays commission) Cash-out: transfer amount + network fee Cash-in: received amount</value>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public string Sum { get; set; }

        /// <summary>
        /// Plisio commission
        /// </summary>
        /// <value>Plisio commission</value>
        [DataMember(Name="commission", EmitDefaultValue=false)]
        public string Commission { get; set; }

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
        /// internal Plisio operation ID
        /// </summary>
        /// <value>internal Plisio operation ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Real incoming amount
        /// </summary>
        /// <value>Real incoming amount</value>
        [DataMember(Name="actual_sum", EmitDefaultValue=false)]
        public string ActualSum { get; set; }

        /// <summary>
        /// Plisio commission taken
        /// </summary>
        /// <value>Plisio commission taken</value>
        [DataMember(Name="actual_commission", EmitDefaultValue=false)]
        public string ActualCommission { get; set; }

        /// <summary>
        /// Network fee (move invoice to wallet)
        /// </summary>
        /// <value>Network fee (move invoice to wallet)</value>
        [DataMember(Name="actual_fee", EmitDefaultValue=false)]
        public string ActualFee { get; set; }

        /// <summary>
        /// actual_sum - actual_commis_sim - actual_fee
        /// </summary>
        /// <value>actual_sum - actual_commis_sim - actual_fee</value>
        [DataMember(Name="actual_invoice_sum", EmitDefaultValue=false)]
        public string ActualInvoiceSum { get; set; }

        /// <summary>
        /// array of transaction payment items
        /// </summary>
        /// <value>array of transaction payment items</value>
        [DataMember(Name="tx", EmitDefaultValue=false)]
        public List<Object> Tx { get; set; }

        /// <summary>
        /// Number of confirmations of this transaction. We don&#x27;t update confirmation after operation is confirmed
        /// </summary>
        /// <value>Number of confirmations of this transaction. We don&#x27;t update confirmation after operation is confirmed</value>
        [DataMember(Name="confirmations", EmitDefaultValue=false)]
        public int? Confirmations { get; set; }

        /// <summary>
        /// Status code
        /// </summary>
        /// <value>Status code</value>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// ID of parent invoice
        /// </summary>
        /// <value>ID of parent invoice</value>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationDto {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PendingSum: ").Append(PendingSum).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
            sb.Append("  Sendmany: ").Append(Sendmany).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  ExpireAtUtc: ").Append(ExpireAtUtc).Append("\n");
            sb.Append("  CreatedAtUtc: ").Append(CreatedAtUtc).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActualSum: ").Append(ActualSum).Append("\n");
            sb.Append("  ActualCommission: ").Append(ActualCommission).Append("\n");
            sb.Append("  ActualFee: ").Append(ActualFee).Append("\n");
            sb.Append("  ActualInvoiceSum: ").Append(ActualInvoiceSum).Append("\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
            sb.Append("  Confirmations: ").Append(Confirmations).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(input as OperationDto);
        }

        /// <summary>
        /// Returns true if OperationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PendingSum == input.PendingSum ||
                    (this.PendingSum != null &&
                    this.PendingSum.Equals(input.PendingSum))
                ) && 
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
                    this.SourceCurrency == input.SourceCurrency ||
                    (this.SourceCurrency != null &&
                    this.SourceCurrency.Equals(input.SourceCurrency))
                ) && 
                (
                    this.SourceRate == input.SourceRate ||
                    (this.SourceRate != null &&
                    this.SourceRate.Equals(input.SourceRate))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.WalletHash == input.WalletHash ||
                    (this.WalletHash != null &&
                    this.WalletHash.Equals(input.WalletHash))
                ) && 
                (
                    this.Sendmany == input.Sendmany ||
                    this.Sendmany != null &&
                    input.Sendmany != null &&
                    this.Sendmany.SequenceEqual(input.Sendmany)
                ) && 
                (
                    this._Params == input._Params ||
                    (this._Params != null &&
                    this._Params.Equals(input._Params))
                ) && 
                (
                    this.ExpireAtUtc == input.ExpireAtUtc ||
                    (this.ExpireAtUtc != null &&
                    this.ExpireAtUtc.Equals(input.ExpireAtUtc))
                ) && 
                (
                    this.CreatedAtUtc == input.CreatedAtUtc ||
                    (this.CreatedAtUtc != null &&
                    this.CreatedAtUtc.Equals(input.CreatedAtUtc))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
                ) && 
                (
                    this.Commission == input.Commission ||
                    (this.Commission != null &&
                    this.Commission.Equals(input.Commission))
                ) && 
                (
                    this.TxUrl == input.TxUrl ||
                    (this.TxUrl != null &&
                    this.TxUrl.Equals(input.TxUrl))
                ) && 
                (
                    this.TxId == input.TxId ||
                    this.TxId != null &&
                    input.TxId != null &&
                    this.TxId.SequenceEqual(input.TxId)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ActualSum == input.ActualSum ||
                    (this.ActualSum != null &&
                    this.ActualSum.Equals(input.ActualSum))
                ) && 
                (
                    this.ActualCommission == input.ActualCommission ||
                    (this.ActualCommission != null &&
                    this.ActualCommission.Equals(input.ActualCommission))
                ) && 
                (
                    this.ActualFee == input.ActualFee ||
                    (this.ActualFee != null &&
                    this.ActualFee.Equals(input.ActualFee))
                ) && 
                (
                    this.ActualInvoiceSum == input.ActualInvoiceSum ||
                    (this.ActualInvoiceSum != null &&
                    this.ActualInvoiceSum.Equals(input.ActualInvoiceSum))
                ) && 
                (
                    this.Tx == input.Tx ||
                    this.Tx != null &&
                    input.Tx != null &&
                    this.Tx.SequenceEqual(input.Tx)
                ) && 
                (
                    this.Confirmations == input.Confirmations ||
                    (this.Confirmations != null &&
                    this.Confirmations.Equals(input.Confirmations))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ShopId != null)
                    hashCode = hashCode * 59 + this.ShopId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PendingSum != null)
                    hashCode = hashCode * 59 + this.PendingSum.GetHashCode();
                if (this.PsysCid != null)
                    hashCode = hashCode * 59 + this.PsysCid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.SourceCurrency != null)
                    hashCode = hashCode * 59 + this.SourceCurrency.GetHashCode();
                if (this.SourceRate != null)
                    hashCode = hashCode * 59 + this.SourceRate.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.WalletHash != null)
                    hashCode = hashCode * 59 + this.WalletHash.GetHashCode();
                if (this.Sendmany != null)
                    hashCode = hashCode * 59 + this.Sendmany.GetHashCode();
                if (this._Params != null)
                    hashCode = hashCode * 59 + this._Params.GetHashCode();
                if (this.ExpireAtUtc != null)
                    hashCode = hashCode * 59 + this.ExpireAtUtc.GetHashCode();
                if (this.CreatedAtUtc != null)
                    hashCode = hashCode * 59 + this.CreatedAtUtc.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Commission != null)
                    hashCode = hashCode * 59 + this.Commission.GetHashCode();
                if (this.TxUrl != null)
                    hashCode = hashCode * 59 + this.TxUrl.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ActualSum != null)
                    hashCode = hashCode * 59 + this.ActualSum.GetHashCode();
                if (this.ActualCommission != null)
                    hashCode = hashCode * 59 + this.ActualCommission.GetHashCode();
                if (this.ActualFee != null)
                    hashCode = hashCode * 59 + this.ActualFee.GetHashCode();
                if (this.ActualInvoiceSum != null)
                    hashCode = hashCode * 59 + this.ActualInvoiceSum.GetHashCode();
                if (this.Tx != null)
                    hashCode = hashCode * 59 + this.Tx.GetHashCode();
                if (this.Confirmations != null)
                    hashCode = hashCode * 59 + this.Confirmations.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
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

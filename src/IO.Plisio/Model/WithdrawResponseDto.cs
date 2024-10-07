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
    /// WithdrawResponseDto
    /// </summary>
    [DataContract]
        public partial class WithdrawResponseDto :  IEquatable<WithdrawResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawResponseDto" /> class.
        /// </summary>
        /// <param name="type">&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; depending on the request.</param>
        /// <param name="status">Cash-out status &#x27;competed&#x27;, &#x27;error&#x27;.</param>
        /// <param name="psysCid">ID column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="currency">Code column from https://plisio.net/documentation/appendices/supported-cryptocurrencies.</param>
        /// <param name="sourceCurrency">Fiat currency - only USD available for the moment.</param>
        /// <param name="sourceRate">Exchange rate from the “psys_cid” to the “source_currency” at the moment of transfer.</param>
        /// <param name="fee">Transaction fee stated in the transfer.</param>
        /// <param name="walletHash">Destination hash (type&#x3D;cash_out).</param>
        /// <param name="sendmany">Pairs of hashes and values (type&#x3D;mass_cash_out).</param>
        /// <param name="_params">_params.</param>
        /// <param name="createdAtUtc">timestamp in the UTC timezone; it may need to be divided by 1000.</param>
        /// <param name="amount">transfer amount in cryptocurrency.</param>
        /// <param name="txUrl">link to the cryptocurrency block explorer.</param>
        /// <param name="txId">array of transaction ids.</param>
        /// <param name="id">internal Plisio operation ID.</param>
        /// <param name="txnId">internal Plisio operation ID.</param>
        public WithdrawResponseDto(
            string type = default(string), 
            string status = default(string),
            string psysCid = default(string),
            string currency = default(string),
            string sourceCurrency = default(string),
            string sourceRate = default(string),
            string fee = default(string),
            string walletHash = default(string),
            List<string> sendmany = default(List<string>),
            FeeParamsDto _params = default(FeeParamsDto),
            int? createdAtUtc = default(int?),
            string amount = default(string),
            string txUrl = default(string),
            List<string> txId = default(List<string>),
            string id = default(string),
            string txnId = default(string)
            )
        {
            this.Type = type;
            this.Status = status;
            this.PsysCid = psysCid;
            this.Currency = currency;
            this.SourceCurrency = sourceCurrency;
            this.SourceRate = sourceRate;
            this.Fee = fee;
            this.WalletHash = walletHash;
            this.Sendmany = sendmany;
            this._Params = _params;
            this.CreatedAtUtc = createdAtUtc;
            this.Amount = amount;
            this.TxUrl = txUrl;
            this.TxId = txId;
            this.Id = id;
            this.TxnId = txnId;
        }
        
        /// <summary>
        /// &#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; depending on the request
        /// </summary>
        /// <value>&#x27;cash_out&#x27; or &#x27;mass_cash_out&#x27; depending on the request</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Cash-out status &#x27;competed&#x27;, &#x27;error&#x27;
        /// </summary>
        /// <value>Cash-out status &#x27;competed&#x27;, &#x27;error&#x27;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

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
        /// Transaction fee stated in the transfer
        /// </summary>
        /// <value>Transaction fee stated in the transfer</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public string Fee { get; set; }

        /// <summary>
        /// Destination hash (type&#x3D;cash_out)
        /// </summary>
        /// <value>Destination hash (type&#x3D;cash_out)</value>
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
        public FeeParamsDto _Params { get; set; }

        /// <summary>
        /// timestamp in the UTC timezone; it may need to be divided by 1000
        /// </summary>
        /// <value>timestamp in the UTC timezone; it may need to be divided by 1000</value>
        [DataMember(Name="created_at_utc", EmitDefaultValue=false)]
        public int? CreatedAtUtc { get; set; }

        /// <summary>
        /// transfer amount in cryptocurrency
        /// </summary>
        /// <value>transfer amount in cryptocurrency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

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
        /// internal Plisio operation ID
        /// </summary>
        /// <value>internal Plisio operation ID</value>
        [DataMember(Name="txn_id", EmitDefaultValue=false)]
        public string TxnId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithdrawResponseDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PsysCid: ").Append(PsysCid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
            sb.Append("  SourceRate: ").Append(SourceRate).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  WalletHash: ").Append(WalletHash).Append("\n");
            sb.Append("  Sendmany: ").Append(Sendmany).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  CreatedAtUtc: ").Append(CreatedAtUtc).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TxUrl: ").Append(TxUrl).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TxnId: ").Append(TxnId).Append("\n");
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
            return this.Equals(input as WithdrawResponseDto);
        }

        /// <summary>
        /// Returns true if WithdrawResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawResponseDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.TxnId == input.TxnId ||
                    (this.TxnId != null &&
                    this.TxnId.Equals(input.TxnId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
                if (this.CreatedAtUtc != null)
                    hashCode = hashCode * 59 + this.CreatedAtUtc.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TxUrl != null)
                    hashCode = hashCode * 59 + this.TxUrl.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TxnId != null)
                    hashCode = hashCode * 59 + this.TxnId.GetHashCode();
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

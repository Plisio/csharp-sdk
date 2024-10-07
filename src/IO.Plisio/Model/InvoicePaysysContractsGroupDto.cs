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
    /// InvoicePaysysContractsGroupDto
    /// </summary>
    [DataContract]
        public partial class InvoicePaysysContractsGroupDto : InvoicePaysysDto,  IEquatable<InvoicePaysysContractsGroupDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaysysContractsGroupDto" /> class.
        /// </summary>
        /// <param name="contractGroupCid">Contract group cid.</param>
        /// <param name="contractGroupIcon">Contract group icon.</param>
        /// <param name="contractGroupName">Contract group name.</param>
        public InvoicePaysysContractsGroupDto(
            string contractGroupCid = default(string), 
            string contractGroupIcon = default(string), 
            string contractGroupName = default(string), 
            string amount = default(string)
            ) : base(amount)
        {
            this.ContractGroupCid = contractGroupCid;
            this.ContractGroupIcon = contractGroupIcon;
            this.ContractGroupName = contractGroupName;
        }
        
        /// <summary>
        /// Contract group cid
        /// </summary>
        /// <value>Contract group cid</value>
        [DataMember(Name="contractGroupCid", EmitDefaultValue=false)]
        public string ContractGroupCid { get; set; }

        /// <summary>
        /// Contract group icon
        /// </summary>
        /// <value>Contract group icon</value>
        [DataMember(Name="contractGroupIcon", EmitDefaultValue=false)]
        public string ContractGroupIcon { get; set; }

        /// <summary>
        /// Contract group name
        /// </summary>
        /// <value>Contract group name</value>
        [DataMember(Name="contractGroupName", EmitDefaultValue=false)]
        public string ContractGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicePaysysContractsGroupDto {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ContractGroupCid: ").Append(ContractGroupCid).Append("\n");
            sb.Append("  ContractGroupIcon: ").Append(ContractGroupIcon).Append("\n");
            sb.Append("  ContractGroupName: ").Append(ContractGroupName).Append("\n");
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
            return this.Equals(input as InvoicePaysysContractsGroupDto);
        }

        /// <summary>
        /// Returns true if InvoicePaysysContractsGroupDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicePaysysContractsGroupDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicePaysysContractsGroupDto input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ContractGroupCid == input.ContractGroupCid ||
                    (this.ContractGroupCid != null &&
                    this.ContractGroupCid.Equals(input.ContractGroupCid))
                ) && base.Equals(input) && 
                (
                    this.ContractGroupIcon == input.ContractGroupIcon ||
                    (this.ContractGroupIcon != null &&
                    this.ContractGroupIcon.Equals(input.ContractGroupIcon))
                ) && base.Equals(input) && 
                (
                    this.ContractGroupName == input.ContractGroupName ||
                    (this.ContractGroupName != null &&
                    this.ContractGroupName.Equals(input.ContractGroupName))
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
                if (this.ContractGroupCid != null)
                    hashCode = hashCode * 59 + this.ContractGroupCid.GetHashCode();
                if (this.ContractGroupIcon != null)
                    hashCode = hashCode * 59 + this.ContractGroupIcon.GetHashCode();
                if (this.ContractGroupName != null)
                    hashCode = hashCode * 59 + this.ContractGroupName.GetHashCode();
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

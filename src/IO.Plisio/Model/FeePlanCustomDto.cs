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
    /// FeePlanCustomDto
    /// </summary>
    [DataContract]
        public partial class FeePlanCustomDto :  IEquatable<FeePlanCustomDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeePlanCustomDto" /> class.
        /// </summary>
        /// <param name="min">minimal custom fee plan value.</param>
        /// <param name="max">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        /// <param name="_default">estimated fee parameter to confirm the transaction in the “conf_target” blocks.</param>
        /// <param name="borders">comma-separated rates of supported plans.</param>
        /// <param name="unit">Fee unit.</param>
        /// <param name="field">Fee unit.</param>
        public FeePlanCustomDto(
            int? min = default(int?), 
            int? max = default(int?), 
            int? _default = default(int?), 
            string borders = default(string), 
            string unit = default(string), 
            string field = default(string)
            )
        {
            this.Min = min;
            this.Max = max;
            this._Default = _default;
            this.Borders = borders;
            this.Unit = unit;
            this.Field = field;
        }
        
        /// <summary>
        /// minimal custom fee plan value
        /// </summary>
        /// <value>minimal custom fee plan value</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public int? Min { get; set; }

        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public int? Max { get; set; }

        /// <summary>
        /// estimated fee parameter to confirm the transaction in the “conf_target” blocks
        /// </summary>
        /// <value>estimated fee parameter to confirm the transaction in the “conf_target” blocks</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public int? _Default { get; set; }

        /// <summary>
        /// comma-separated rates of supported plans
        /// </summary>
        /// <value>comma-separated rates of supported plans</value>
        [DataMember(Name="borders", EmitDefaultValue=false)]
        public string Borders { get; set; }

        /// <summary>
        /// Fee unit
        /// </summary>
        /// <value>Fee unit</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Fee unit
        /// </summary>
        /// <value>Fee unit</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeePlanCustomDto {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  Borders: ").Append(Borders).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as FeePlanCustomDto);
        }

        /// <summary>
        /// Returns true if FeePlanCustomDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FeePlanCustomDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeePlanCustomDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this._Default == input._Default ||
                    (this._Default != null &&
                    this._Default.Equals(input._Default))
                ) && 
                (
                    this.Borders == input.Borders ||
                    (this.Borders != null &&
                    this.Borders.Equals(input.Borders))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this._Default != null)
                    hashCode = hashCode * 59 + this._Default.GetHashCode();
                if (this.Borders != null)
                    hashCode = hashCode * 59 + this.Borders.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
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

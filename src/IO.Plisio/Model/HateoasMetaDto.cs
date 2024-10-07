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
    /// HateoasMetaDto
    /// </summary>
    [DataContract]
        public partial class HateoasMetaDto :  IEquatable<HateoasMetaDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HateoasMetaDto" /> class.
        /// </summary>
        /// <param name="totalCount">HATEOAS pagination items count.</param>
        /// <param name="pageCount">HATEOAS pagination pages count.</param>
        /// <param name="currentPage">HATEOAS pagination current page.</param>
        /// <param name="perPage">HATEOAS pagination items per page.</param>
        public HateoasMetaDto(int? totalCount = default(int?), int? pageCount = default(int?), int? currentPage = default(int?), int? perPage = default(int?))
        {
            this.TotalCount = totalCount;
            this.PageCount = pageCount;
            this.CurrentPage = currentPage;
            this.PerPage = perPage;
        }
        
        /// <summary>
        /// HATEOAS pagination items count
        /// </summary>
        /// <value>HATEOAS pagination items count</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// HATEOAS pagination pages count
        /// </summary>
        /// <value>HATEOAS pagination pages count</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// HATEOAS pagination current page
        /// </summary>
        /// <value>HATEOAS pagination current page</value>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// HATEOAS pagination items per page
        /// </summary>
        /// <value>HATEOAS pagination items per page</value>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HateoasMetaDto {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
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
            return this.Equals(input as HateoasMetaDto);
        }

        /// <summary>
        /// Returns true if HateoasMetaDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HateoasMetaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HateoasMetaDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
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

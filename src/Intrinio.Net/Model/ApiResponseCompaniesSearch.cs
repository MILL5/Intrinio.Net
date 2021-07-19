using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseCompaniesSearch
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseCompaniesSearch : IEquatable<ApiResponseCompaniesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompaniesSearch" /> class.
        /// </summary>
        /// <param name="Companies">Companies.</param>
        public ApiResponseCompaniesSearch(List<CompanySummary> Companies = default)
        {
            this.Companies = Companies;
        }

        /// <summary>
        /// Gets or Sets Companies
        /// </summary>
        [DataMember(Name = "companies", EmitDefaultValue = false)]
        public List<CompanySummary> Companies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompaniesSearch {\n");
            sb.Append("  Companies: ").Append(Companies).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResponseCompaniesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseCompaniesSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseCompaniesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompaniesSearch other)
        {
            if (other == null)
                return false;

            return
                (
                    Companies == other.Companies ||
                    Companies != null &&
                    Companies.SequenceEqual(other.Companies)
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
                if (Companies != null)
                    hashCode = hashCode * 59 + Companies.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
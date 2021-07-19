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
    /// ApiResponseCompanyFundamentals
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseCompanyFundamentals : IEquatable<ApiResponseCompanyFundamentals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyFundamentals" /> class.
        /// </summary>
        /// <param name="Fundamentals">Fundamentals.</param>
        /// <param name="Company">Company.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseCompanyFundamentals(List<FundamentalSummary> Fundamentals = default, CompanySummary Company = default, string NextPage = default)
        {
            this.Fundamentals = Fundamentals;
            this.Company = Company;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets Fundamentals
        /// </summary>
        [DataMember(Name = "fundamentals", EmitDefaultValue = false)]
        public List<FundamentalSummary> Fundamentals { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name = "next_page", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompanyFundamentals {\n");
            sb.Append("  Fundamentals: ").Append(Fundamentals).Append('\n');
            sb.Append("  Company: ").Append(Company).Append('\n');
            sb.Append("  NextPage: ").Append(NextPage).Append('\n');
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
            return Equals(obj as ApiResponseCompanyFundamentals);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyFundamentals instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseCompanyFundamentals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyFundamentals other)
        {
            if (other == null)
                return false;

            return
                (
                    Fundamentals == other.Fundamentals ||
                    Fundamentals != null &&
                    Fundamentals.SequenceEqual(other.Fundamentals)
                ) &&
                (
                    Company == other.Company ||
                    (Company != null &&
                    Company.Equals(other.Company))
                ) &&
                (
                    NextPage == other.NextPage ||
                    (NextPage != null &&
                    NextPage.Equals(other.NextPage))
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
                if (Fundamentals != null)
                    hashCode = hashCode * 59 + Fundamentals.GetHashCode();
                if (Company != null)
                    hashCode = hashCode * 59 + Company.GetHashCode();
                if (NextPage != null)
                    hashCode = hashCode * 59 + NextPage.GetHashCode();
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
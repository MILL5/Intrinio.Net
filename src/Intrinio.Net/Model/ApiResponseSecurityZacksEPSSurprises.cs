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
    /// ApiResponseSecurityZacksEPSSurprises
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSecurityZacksEpsSurprises : IEquatable<ApiResponseSecurityZacksEpsSurprises>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityZacksEpsSurprises" /> class.
        /// </summary>
        /// <param name="EpsSurprises">EpsSurprises.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityZacksEpsSurprises(List<ZacksEpsSurpriseSummary> EpsSurprises = default, SecuritySummary Security = default, string NextPage = default)
        {
            this.EpsSurprises = EpsSurprises;
            this.Security = Security;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets EpsSurprises
        /// </summary>
        [DataMember(Name = "eps_surprises", EmitDefaultValue = false)]
        public List<ZacksEpsSurpriseSummary> EpsSurprises { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public SecuritySummary Security { get; set; }

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
            sb.Append("class ApiResponseSecurityZacksEPSSurprises {\n");
            sb.Append("  EpsSurprises: ").Append(EpsSurprises).Append('\n');
            sb.Append("  Security: ").Append(Security).Append('\n');
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
            return Equals(obj as ApiResponseSecurityZacksEpsSurprises);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityZacksEPSSurprises instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityZacksEPSSurprises to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityZacksEpsSurprises input)
        {
            if (input == null)
                return false;

            return
                (
                    EpsSurprises == input.EpsSurprises ||
                    EpsSurprises != null &&
                    EpsSurprises.SequenceEqual(input.EpsSurprises)
                ) &&
                (
                    Security == input.Security ||
                    (Security != null &&
                    Security.Equals(input.Security))
                ) &&
                (
                    NextPage == input.NextPage ||
                    (NextPage != null &&
                    NextPage.Equals(input.NextPage))
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
                if (EpsSurprises != null)
                    hashCode = hashCode * 59 + EpsSurprises.GetHashCode();
                if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
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
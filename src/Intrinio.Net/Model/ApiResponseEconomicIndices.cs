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
    /// ApiResponseEconomicIndices
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseEconomicIndices : IEquatable<ApiResponseEconomicIndices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseEconomicIndices" /> class.
        /// </summary>
        /// <param name="Indices">Indices.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseEconomicIndices(List<EconomicIndexSummary> Indices = default, string NextPage = default)
        {
            this.Indices = Indices;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets Indices
        /// </summary>
        [DataMember(Name = "indices", EmitDefaultValue = false)]
        public List<EconomicIndexSummary> Indices { get; set; }

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
            sb.Append("class ApiResponseEconomicIndices {\n");
            sb.Append("  Indices: ").Append(Indices).Append('\n');
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
            return Equals(obj as ApiResponseEconomicIndices);
        }

        /// <summary>
        /// Returns true if ApiResponseEconomicIndices instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseEconomicIndices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseEconomicIndices other)
        {
            if (other == null)
                return false;

            return
                (
                    Indices == other.Indices ||
                    Indices != null &&
                    Indices.SequenceEqual(other.Indices)
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
                if (Indices != null)
                    hashCode = hashCode * 59 + Indices.GetHashCode();
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
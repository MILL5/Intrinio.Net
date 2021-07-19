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
    /// ApiResponseZacksAnalystRatings
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseZacksAnalystRatings : IEquatable<ApiResponseZacksAnalystRatings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksAnalystRatings" /> class.
        /// </summary>
        /// <param name="AnalystRatings">AnalystRatings.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksAnalystRatings(List<ZacksAnalystRating> AnalystRatings = default, string NextPage = default)
        {
            this.AnalystRatings = AnalystRatings;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets AnalystRatings
        /// </summary>
        [DataMember(Name = "analyst_ratings", EmitDefaultValue = false)]
        public List<ZacksAnalystRating> AnalystRatings { get; set; }

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
            sb.Append("class ApiResponseZacksAnalystRatings {\n");
            sb.Append("  AnalystRatings: ").Append(AnalystRatings).Append('\n');
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
            return Equals(obj as ApiResponseZacksAnalystRatings);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksAnalystRatings instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksAnalystRatings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksAnalystRatings input)
        {
            if (input == null)
                return false;

            return
                (
                    AnalystRatings == input.AnalystRatings ||
                    AnalystRatings != null &&
                    AnalystRatings.SequenceEqual(input.AnalystRatings)
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
                if (AnalystRatings != null)
                    hashCode = hashCode * 59 + AnalystRatings.GetHashCode();
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
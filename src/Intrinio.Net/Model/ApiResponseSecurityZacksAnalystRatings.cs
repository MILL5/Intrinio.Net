

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
using SwaggerDateConverter = Intrinio.Net.Client.SwaggerDateConverter;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseSecurityZacksAnalystRatings
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityZacksAnalystRatings :  IEquatable<ApiResponseSecurityZacksAnalystRatings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityZacksAnalystRatings" /> class.
        /// </summary>
        /// <param name="AnalystRatings">AnalystRatings.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityZacksAnalystRatings(List<ZacksAnalystRatingSummary> AnalystRatings = default(List<ZacksAnalystRatingSummary>), SecuritySummary Security = default(SecuritySummary), string NextPage = default(string))
        {
            this.AnalystRatings = AnalystRatings;
            this.Security = Security;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets AnalystRatings
        /// </summary>
        [DataMember(Name="analyst_ratings", EmitDefaultValue=false)]
        public List<ZacksAnalystRatingSummary> AnalystRatings { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityZacksAnalystRatings {\n");
            sb.Append("  AnalystRatings: ").Append(AnalystRatings).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ApiResponseSecurityZacksAnalystRatings);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityZacksAnalystRatings instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityZacksAnalystRatings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityZacksAnalystRatings input)
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
                if (AnalystRatings != null)
                    hashCode = hashCode * 59 + AnalystRatings.GetHashCode();
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

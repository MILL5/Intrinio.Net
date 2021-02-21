

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
    /// ApiResponseFilingFundamentals
    /// </summary>
    [DataContract]
    public partial class ApiResponseFilingFundamentals :  IEquatable<ApiResponseFilingFundamentals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseFilingFundamentals" /> class.
        /// </summary>
        /// <param name="Fundamentals">Fundamentals.</param>
        /// <param name="Filing">Filing.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseFilingFundamentals(List<FundamentalSummary> Fundamentals = default(List<FundamentalSummary>), FilingSummary Filing = default(FilingSummary), string NextPage = default(string))
        {
            this.Fundamentals = Fundamentals;
            this.Filing = Filing;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Fundamentals
        /// </summary>
        [DataMember(Name="fundamentals", EmitDefaultValue=false)]
        public List<FundamentalSummary> Fundamentals { get; set; }

        /// <summary>
        /// Gets or Sets Filing
        /// </summary>
        [DataMember(Name="filing", EmitDefaultValue=false)]
        public FilingSummary Filing { get; set; }

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
            sb.Append("class ApiResponseFilingFundamentals {\n");
            sb.Append("  Fundamentals: ").Append(Fundamentals).Append("\n");
            sb.Append("  Filing: ").Append(Filing).Append("\n");
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
            return Equals(input as ApiResponseFilingFundamentals);
        }

        /// <summary>
        /// Returns true if ApiResponseFilingFundamentals instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseFilingFundamentals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseFilingFundamentals input)
        {
            if (input == null)
                return false;

            return 
                (
                    Fundamentals == input.Fundamentals ||
                    Fundamentals != null &&
                    Fundamentals.SequenceEqual(input.Fundamentals)
                ) && 
                (
                    Filing == input.Filing ||
                    (Filing != null &&
                    Filing.Equals(input.Filing))
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
                if (Fundamentals != null)
                    hashCode = hashCode * 59 + Fundamentals.GetHashCode();
                if (Filing != null)
                    hashCode = hashCode * 59 + Filing.GetHashCode();
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseSecurityHistoricalData
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSecurityHistoricalData : IEquatable<ApiResponseSecurityHistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityHistoricalData" /> class.
        /// </summary>
        /// <param name="HistoricalData">HistoricalData.</param>
        /// <param name="Security">Security.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityHistoricalData(List<HistoricalData> HistoricalData = default, SecuritySummary Security = default, string NextPage = default)
        {
            this.HistoricalData = HistoricalData;
            this.Security = Security;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets HistoricalData
        /// </summary>
        [DataMember(Name = "historical_data", EmitDefaultValue = false)]
        public List<HistoricalData> HistoricalData { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
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
            sb.Append("class ApiResponseSecurityHistoricalData {\n");
            sb.Append("  HistoricalData: ").Append(HistoricalData).Append('\n');
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
            return Equals(obj as ApiResponseSecurityHistoricalData);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityHistoricalData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityHistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityHistoricalData input)
        {
            if (input == null)
                return false;

            return
                (
                    HistoricalData == input.HistoricalData ||
                    HistoricalData != null &&
                    HistoricalData.SequenceEqual(input.HistoricalData)
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
                if (HistoricalData != null)
                    hashCode = hashCode * 59 + HistoricalData.GetHashCode();
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
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
    /// ApiResponseHistoricalData
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseHistoricalData : IEquatable<ApiResponseHistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseHistoricalData" /> class.
        /// </summary>
        /// <param name="HistoricalData">HistoricalData.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseHistoricalData(List<HistoricalData> HistoricalData = default, string NextPage = default)
        {
            this.HistoricalData = HistoricalData;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets HistoricalData
        /// </summary>
        [DataMember(Name = "historical_data", EmitDefaultValue = false)]
        public List<HistoricalData> HistoricalData { get; set; }

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
            sb.Append("class ApiResponseHistoricalData {\n");
            sb.Append("  HistoricalData: ").Append(HistoricalData).Append('\n');
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
            return Equals(obj as ApiResponseHistoricalData);
        }

        /// <summary>
        /// Returns true if ApiResponseHistoricalData instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseHistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseHistoricalData other)
        {
            if (other == null)
                return false;

            return
                (
                    HistoricalData == other.HistoricalData ||
                    HistoricalData != null &&
                    HistoricalData.SequenceEqual(other.HistoricalData)
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
                if (HistoricalData != null)
                    hashCode = hashCode * 59 + HistoricalData.GetHashCode();
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
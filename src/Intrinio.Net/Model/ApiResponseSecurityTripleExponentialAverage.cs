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
    /// The Triple Exponential Average calculations for the Stock Prices of the given Security
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSecurityTripleExponentialAverage : IEquatable<ApiResponseSecurityTripleExponentialAverage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityTripleExponentialAverage" /> class.
        /// </summary>
        /// <param name="Technicals">Technicals.</param>
        /// <param name="Indicator">The name and symbol of the technical indicator.</param>
        /// <param name="Security">The Security of the Stock Price.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityTripleExponentialAverage(List<TripleExponentialAverageTechnicalValue> Technicals = default, TechnicalIndicator Indicator = default, SecuritySummary Security = default, string NextPage = default)
        {
            this.Technicals = Technicals;
            this.Indicator = Indicator;
            this.Security = Security;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// Gets or Sets Technicals
        /// </summary>
        [DataMember(Name = "technicals", EmitDefaultValue = false)]
        public List<TripleExponentialAverageTechnicalValue> Technicals { get; set; }

        /// <summary>
        /// The name and symbol of the technical indicator
        /// </summary>
        /// <value>The name and symbol of the technical indicator</value>
        [DataMember(Name = "indicator", EmitDefaultValue = false)]
        public TechnicalIndicator Indicator { get; set; }

        /// <summary>
        /// The Security of the Stock Price
        /// </summary>
        /// <value>The Security of the Stock Price</value>
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
            sb.Append("class ApiResponseSecurityTripleExponentialAverage {\n");
            sb.Append("  Technicals: ").Append(Technicals).Append('\n');
            sb.Append("  Indicator: ").Append(Indicator).Append('\n');
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
            return Equals(obj as ApiResponseSecurityTripleExponentialAverage);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityTripleExponentialAverage instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityTripleExponentialAverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityTripleExponentialAverage input)
        {
            if (input == null)
                return false;

            return
                (
                    Technicals == input.Technicals ||
                    Technicals != null &&
                    Technicals.SequenceEqual(input.Technicals)
                ) &&
                (
                    Indicator == input.Indicator ||
                    (Indicator != null &&
                    Indicator.Equals(input.Indicator))
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
                if (Technicals != null)
                    hashCode = hashCode * 59 + Technicals.GetHashCode();
                if (Indicator != null)
                    hashCode = hashCode * 59 + Indicator.GetHashCode();
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
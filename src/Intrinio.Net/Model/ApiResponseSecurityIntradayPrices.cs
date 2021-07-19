using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseSecurityIntradayPrices
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSecurityIntradayPrices : IEquatable<ApiResponseSecurityIntradayPrices>, IValidatableObject
    {
        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataSource
        {
            /// <summary>
            /// Enum Iex for value: iex
            /// </summary>
            [EnumMember(Value = "iex")]
            Iex = 1,

            /// <summary>
            /// Enum Bats for value: bats
            /// </summary>
            [EnumMember(Value = "bats")]
            Bats = 2
        }

        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public DataSource? Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityIntradayPrices" /> class.
        /// </summary>
        /// <param name="IntradayPrices">The intraday stock prices for the Security.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="Source">The source of the data.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityIntradayPrices(List<IntradayStockPrice> IntradayPrices = default, SecuritySummary Security = default, DataSource? Source = default, string NextPage = default)
        {
            this.IntradayPrices = IntradayPrices;
            this.Security = Security;
            this.Source = Source;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// The intraday stock prices for the Security
        /// </summary>
        /// <value>The intraday stock prices for the Security</value>
        [DataMember(Name = "intraday_prices", EmitDefaultValue = false)]
        public List<IntradayStockPrice> IntradayPrices { get; set; }

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
            sb.Append("class ApiResponseSecurityIntradayPrices {\n");
            sb.Append("  IntradayPrices: ").Append(IntradayPrices).Append('\n');
            sb.Append("  Security: ").Append(Security).Append('\n');
            sb.Append("  Source: ").Append(Source).Append('\n');
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as ApiResponseSecurityIntradayPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityIntradayPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityIntradayPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityIntradayPrices input)
        {
            if (input == null)
                return false;

            return
                (
                    IntradayPrices == input.IntradayPrices ||
                    IntradayPrices != null &&
                    IntradayPrices.SequenceEqual(input.IntradayPrices)
                ) &&
                (
                    Security == input.Security ||
                    (Security != null &&
                    Security.Equals(input.Security))
                ) &&
                (
                    Source == input.Source ||
                    (Source != null &&
                    Source.Equals(input.Source))
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
                if (IntradayPrices != null)
                    hashCode = hashCode * 59 + IntradayPrices.GetHashCode();
                if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
                if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
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
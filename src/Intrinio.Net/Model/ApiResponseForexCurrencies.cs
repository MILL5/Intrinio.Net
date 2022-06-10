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
    /// ApiResponseForexCurrencies
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseForexCurrencies : IEquatable<ApiResponseForexCurrencies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseForexCurrencies" /> class.
        /// </summary>
        /// <param name="Currencies">Currencies.</param>
        public ApiResponseForexCurrencies(List<ForexCurrency> Currencies = default)
        {
            this.Currencies = Currencies;
        }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name = "currencies", EmitDefaultValue = false)]
        public List<ForexCurrency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseForexCurrencies {\n");
            sb.Append("  Currencies: ").Append(Currencies).Append('\n');
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
            return Equals(obj as ApiResponseForexCurrencies);
        }

        /// <summary>
        /// Returns true if ApiResponseForexCurrencies instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseForexCurrencies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseForexCurrencies other)
        {
            if (other == null)
                return false;

            return
                (
                    Currencies == other.Currencies ||
                    Currencies != null &&
                    Currencies.SequenceEqual(other.Currencies)
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
                if (Currencies != null)
                    hashCode = hashCode * 59 + Currencies.GetHashCode();
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
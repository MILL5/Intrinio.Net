

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
    /// A Forex Currency Pair
    /// </summary>
    [DataContract]
    public partial class ForexPair :  IEquatable<ForexPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexPair" /> class.
        /// </summary>
        /// <param name="Code">The common code of the currency pair.</param>
        /// <param name="BaseCurrency">The ISO 4217 currency code of the base currency.</param>
        /// <param name="QuoteCurrency">The ISO 4217 currency code of the quote currency.</param>
        public ForexPair(string Code = default(string), string BaseCurrency = default(string), string QuoteCurrency = default(string))
        {
            this.Code = Code;
            this.BaseCurrency = BaseCurrency;
            this.QuoteCurrency = QuoteCurrency;
        }
        
        /// <summary>
        /// The common code of the currency pair
        /// </summary>
        /// <value>The common code of the currency pair</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ISO 4217 currency code of the base currency
        /// </summary>
        /// <value>The ISO 4217 currency code of the base currency</value>
        [DataMember(Name="base_currency", EmitDefaultValue=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// The ISO 4217 currency code of the quote currency
        /// </summary>
        /// <value>The ISO 4217 currency code of the quote currency</value>
        [DataMember(Name="quote_currency", EmitDefaultValue=false)]
        public string QuoteCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForexPair {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  QuoteCurrency: ").Append(QuoteCurrency).Append("\n");
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
            return Equals(input as ForexPair);
        }

        /// <summary>
        /// Returns true if ForexPair instances are equal
        /// </summary>
        /// <param name="input">Instance of ForexPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForexPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    Code == input.Code ||
                    (Code != null &&
                    Code.Equals(input.Code))
                ) && 
                (
                    BaseCurrency == input.BaseCurrency ||
                    (BaseCurrency != null &&
                    BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    QuoteCurrency == input.QuoteCurrency ||
                    (QuoteCurrency != null &&
                    QuoteCurrency.Equals(input.QuoteCurrency))
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
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (BaseCurrency != null)
                    hashCode = hashCode * 59 + BaseCurrency.GetHashCode();
                if (QuoteCurrency != null)
                    hashCode = hashCode * 59 + QuoteCurrency.GetHashCode();
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

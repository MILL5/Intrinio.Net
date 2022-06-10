using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// A Forex Currency
    /// </summary>
    [DataContract]
    public sealed partial class ForexCurrency : IEquatable<ForexCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexCurrency" /> class.
        /// </summary>
        /// <param name="Code">The ISO 4217 currency code.</param>
        /// <param name="Name">The name of the currency.</param>
        /// <param name="Country">The country in which the currency is used.</param>
        public ForexCurrency(string Code = default, string Name = default, string Country = default)
        {
            this.Code = Code;
            this.Name = Name;
            this.Country = Country;
        }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        /// <value>The ISO 4217 currency code</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the currency
        /// </summary>
        /// <value>The name of the currency</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The country in which the currency is used
        /// </summary>
        /// <value>The country in which the currency is used</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForexCurrency {\n");
            sb.Append("  Code: ").Append(Code).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Country: ").Append(Country).Append('\n');
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
            return Equals(obj as ForexCurrency);
        }

        /// <summary>
        /// Returns true if ForexCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of ForexCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForexCurrency input)
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
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) &&
                (
                    Country == input.Country ||
                    (Country != null &&
                    Country.Equals(input.Country))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
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
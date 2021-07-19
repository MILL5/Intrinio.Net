using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// An option chain contains an options contract and corresponding price data for that contract on a given date.
    /// </summary>
    [DataContract]
    public sealed partial class OptionChain : IEquatable<OptionChain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionChain" /> class.
        /// </summary>
        /// <param name="Option">Option.</param>
        /// <param name="Price">Price.</param>
        public OptionChain(Option Option = default, OptionPrice Price = default)
        {
            this.Option = Option;
            this.Price = Price;
        }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public Option Option { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public OptionPrice Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionChain {\n");
            sb.Append("  Option: ").Append(Option).Append('\n');
            sb.Append("  Price: ").Append(Price).Append('\n');
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
            return Equals(obj as OptionChain);
        }

        /// <summary>
        /// Returns true if OptionChain instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionChain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionChain input)
        {
            if (input == null)
                return false;

            return
                (
                    Option == input.Option ||
                    (Option != null &&
                    Option.Equals(input.Option))
                ) &&
                (
                    Price == input.Price ||
                    (Price != null &&
                    Price.Equals(input.Price))
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
                if (Option != null)
                    hashCode = hashCode * 59 + Option.GetHashCode();
                if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
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
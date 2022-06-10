using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseOptionsPriceRealtime
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseOptionsPriceRealtime : IEquatable<ApiResponseOptionsPriceRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsPriceRealtime" /> class.
        /// </summary>
        /// <param name="Price">Price.</param>
        /// <param name="Stats">Stats.</param>
        /// <param name="Option">Option.</param>
        public ApiResponseOptionsPriceRealtime(OptionPriceRealtime Price = default, OptionStatsRealtime Stats = default, OptionRealtime Option = default)
        {
            this.Price = Price;
            this.Stats = Stats;
            this.Option = Option;
        }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public OptionPriceRealtime Price { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public OptionStatsRealtime Stats { get; set; }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public OptionRealtime Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsPriceRealtime {\n");
            sb.Append("  Price: ").Append(Price).Append('\n');
            sb.Append("  Stats: ").Append(Stats).Append('\n');
            sb.Append("  Option: ").Append(Option).Append('\n');
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
            return Equals(obj as ApiResponseOptionsPriceRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsPriceRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsPriceRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsPriceRealtime input)
        {
            if (input == null)
                return false;

            return
                (
                    Price == input.Price ||
                    (Price != null &&
                    Price.Equals(input.Price))
                ) &&
                (
                    Stats == input.Stats ||
                    (Stats != null &&
                    Stats.Equals(input.Stats))
                ) &&
                (
                    Option == input.Option ||
                    (Option != null &&
                    Option.Equals(input.Option))
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
                if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                if (Stats != null)
                    hashCode = hashCode * 59 + Stats.GetHashCode();
                if (Option != null)
                    hashCode = hashCode * 59 + Option.GetHashCode();
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


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
    /// An realtime option chain contains an options contract and corresponding price data for that contract on a given date.
    /// </summary>
    [DataContract]
    public partial class OptionChainRealtime :  IEquatable<OptionChainRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionChainRealtime" /> class.
        /// </summary>
        /// <param name="Option">Option.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Stats">Stats.</param>
        public OptionChainRealtime(OptionRealtime Option = default(OptionRealtime), OptionPriceRealtime Price = default(OptionPriceRealtime), OptionStatsRealtime Stats = default(OptionStatsRealtime))
        {
            this.Option = Option;
            this.Price = Price;
            this.Stats = Stats;
        }
        
        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public OptionRealtime Option { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public OptionPriceRealtime Price { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public OptionStatsRealtime Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionChainRealtime {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return Equals(input as OptionChainRealtime);
        }

        /// <summary>
        /// Returns true if OptionChainRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionChainRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionChainRealtime input)
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
                ) && 
                (
                    Stats == input.Stats ||
                    (Stats != null &&
                    Stats.Equals(input.Stats))
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
                if (Stats != null)
                    hashCode = hashCode * 59 + Stats.GetHashCode();
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

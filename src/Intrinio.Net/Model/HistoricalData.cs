using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// A historcial value for the identifier/item combination a specific date
    /// </summary>
    [DataContract]
    public sealed partial class HistoricalData : IEquatable<HistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalData" /> class.
        /// </summary>
        /// <param name="Date">The date that the value is present.</param>
        /// <param name="Value">The historical value.</param>
        public HistoricalData(DateTime? Date = default, decimal? Value = default)
        {
            this.Date = Date;
            this.Value = Value;
        }

        /// <summary>
        /// The date that the value is present
        /// </summary>
        /// <value>The date that the value is present</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The historical value
        /// </summary>
        /// <value>The historical value</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalData {\n");
            sb.Append("  Date: ").Append(Date).Append('\n');
            sb.Append("  Value: ").Append(Value).Append('\n');
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
            return Equals(obj as HistoricalData);
        }

        /// <summary>
        /// Returns true if HistoricalData instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalData input)
        {
            if (input == null)
                return false;

            return
                (
                    Date == input.Date ||
                    (Date != null &&
                    Date.Equals(input.Date))
                ) &&
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
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
                if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
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
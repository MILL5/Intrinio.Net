using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time and sma values of a Simple Moving Average technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class SimpleMovingAverageTechnicalValue : IEquatable<SimpleMovingAverageTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleMovingAverageTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Sma">The Simple Moving Average calculation value.</param>
        public SimpleMovingAverageTechnicalValue(DateTime? DateTime = default, float? Sma = default)
        {
            this.DateTime = DateTime;
            this.Sma = Sma;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Simple Moving Average calculation value
        /// </summary>
        /// <value>The Simple Moving Average calculation value</value>
        [DataMember(Name = "sma", EmitDefaultValue = false)]
        public float? Sma { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleMovingAverageTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  Sma: ").Append(Sma).Append('\n');
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
            return Equals(obj as SimpleMovingAverageTechnicalValue);
        }

        /// <summary>
        /// Returns true if SimpleMovingAverageTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleMovingAverageTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleMovingAverageTechnicalValue input)
        {
            if (input == null)
                return false;

            return
                (
                    DateTime == input.DateTime ||
                    (DateTime != null &&
                    DateTime.Equals(input.DateTime))
                ) &&
                (
                    Sma == input.Sma ||
                    (Sma != null &&
                    Sma.Equals(input.Sma))
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
                if (DateTime != null)
                    hashCode = hashCode * 59 + DateTime.GetHashCode();
                if (Sma != null)
                    hashCode = hashCode * 59 + Sma.GetHashCode();
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
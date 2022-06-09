using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time and trix values of a Triple Exponential Average technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class TripleExponentialAverageTechnicalValue : IEquatable<TripleExponentialAverageTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TripleExponentialAverageTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Trix">The Triple Exponential Average calculation value.</param>
        public TripleExponentialAverageTechnicalValue(DateTime? DateTime = default, float? Trix = default)
        {
            this.DateTime = DateTime;
            this.Trix = Trix;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Triple Exponential Average calculation value
        /// </summary>
        /// <value>The Triple Exponential Average calculation value</value>
        [DataMember(Name = "trix", EmitDefaultValue = false)]
        public float? Trix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TripleExponentialAverageTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  Trix: ").Append(Trix).Append('\n');
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
            return Equals(obj as TripleExponentialAverageTechnicalValue);
        }

        /// <summary>
        /// Returns true if TripleExponentialAverageTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of TripleExponentialAverageTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TripleExponentialAverageTechnicalValue input)
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
                    Trix == input.Trix ||
                    (Trix != null &&
                    Trix.Equals(input.Trix))
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
                if (Trix != null)
                    hashCode = hashCode * 59 + Trix.GetHashCode();
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
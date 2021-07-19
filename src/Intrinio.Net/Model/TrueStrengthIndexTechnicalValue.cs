using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time and tsi values of a True Strength Index technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class TrueStrengthIndexTechnicalValue : IEquatable<TrueStrengthIndexTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueStrengthIndexTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Tsi">The True Strength Index calculation value.</param>
        public TrueStrengthIndexTechnicalValue(DateTime? DateTime = default, float? Tsi = default)
        {
            this.DateTime = DateTime;
            this.Tsi = Tsi;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The True Strength Index calculation value
        /// </summary>
        /// <value>The True Strength Index calculation value</value>
        [DataMember(Name = "tsi", EmitDefaultValue = false)]
        public float? Tsi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrueStrengthIndexTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  Tsi: ").Append(Tsi).Append('\n');
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
            return Equals(obj as TrueStrengthIndexTechnicalValue);
        }

        /// <summary>
        /// Returns true if TrueStrengthIndexTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of TrueStrengthIndexTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrueStrengthIndexTechnicalValue input)
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
                    Tsi == input.Tsi ||
                    (Tsi != null &&
                    Tsi.Equals(input.Tsi))
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
                if (Tsi != null)
                    hashCode = hashCode * 59 + Tsi.GetHashCode();
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
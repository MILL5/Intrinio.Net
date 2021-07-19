using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time, lower_band, middle_band, and upper_band values of a Keltner Channel technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class KeltnerChannelTechnicalValue : IEquatable<KeltnerChannelTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeltnerChannelTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="LowerBand">The lower band value of the Keltner Channel calculation.</param>
        /// <param name="MiddleBand">The middle band value of the Keltner Channel calculation.</param>
        /// <param name="UpperBand">The upper band value of the Keltner Channel calculation.</param>
        public KeltnerChannelTechnicalValue(DateTime? DateTime = default, float? LowerBand = default, float? MiddleBand = default, float? UpperBand = default)
        {
            this.DateTime = DateTime;
            this.LowerBand = LowerBand;
            this.MiddleBand = MiddleBand;
            this.UpperBand = UpperBand;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The lower band value of the Keltner Channel calculation
        /// </summary>
        /// <value>The lower band value of the Keltner Channel calculation</value>
        [DataMember(Name = "lower_band", EmitDefaultValue = false)]
        public float? LowerBand { get; set; }

        /// <summary>
        /// The middle band value of the Keltner Channel calculation
        /// </summary>
        /// <value>The middle band value of the Keltner Channel calculation</value>
        [DataMember(Name = "middle_band", EmitDefaultValue = false)]
        public float? MiddleBand { get; set; }

        /// <summary>
        /// The upper band value of the Keltner Channel calculation
        /// </summary>
        /// <value>The upper band value of the Keltner Channel calculation</value>
        [DataMember(Name = "upper_band", EmitDefaultValue = false)]
        public float? UpperBand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeltnerChannelTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  LowerBand: ").Append(LowerBand).Append('\n');
            sb.Append("  MiddleBand: ").Append(MiddleBand).Append('\n');
            sb.Append("  UpperBand: ").Append(UpperBand).Append('\n');
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
            return Equals(obj as KeltnerChannelTechnicalValue);
        }

        /// <summary>
        /// Returns true if KeltnerChannelTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of KeltnerChannelTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeltnerChannelTechnicalValue input)
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
                    LowerBand == input.LowerBand ||
                    (LowerBand != null &&
                    LowerBand.Equals(input.LowerBand))
                ) &&
                (
                    MiddleBand == input.MiddleBand ||
                    (MiddleBand != null &&
                    MiddleBand.Equals(input.MiddleBand))
                ) &&
                (
                    UpperBand == input.UpperBand ||
                    (UpperBand != null &&
                    UpperBand.Equals(input.UpperBand))
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
                if (LowerBand != null)
                    hashCode = hashCode * 59 + LowerBand.GetHashCode();
                if (MiddleBand != null)
                    hashCode = hashCode * 59 + MiddleBand.GetHashCode();
                if (UpperBand != null)
                    hashCode = hashCode * 59 + UpperBand.GetHashCode();
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
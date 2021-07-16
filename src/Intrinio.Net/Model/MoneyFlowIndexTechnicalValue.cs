using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time and mfi value of a Money Flow Index technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class MoneyFlowIndexTechnicalValue : IEquatable<MoneyFlowIndexTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyFlowIndexTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Mfi">The Money Flow Index calculation value.</param>
        public MoneyFlowIndexTechnicalValue(DateTime? DateTime = default, float? Mfi = default)
        {
            this.DateTime = DateTime;
            this.Mfi = Mfi;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Money Flow Index calculation value
        /// </summary>
        /// <value>The Money Flow Index calculation value</value>
        [DataMember(Name = "mfi", EmitDefaultValue = false)]
        public float? Mfi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoneyFlowIndexTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  Mfi: ").Append(Mfi).Append('\n');
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
            return Equals(obj as MoneyFlowIndexTechnicalValue);
        }

        /// <summary>
        /// Returns true if MoneyFlowIndexTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of MoneyFlowIndexTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoneyFlowIndexTechnicalValue input)
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
                    Mfi == input.Mfi ||
                    (Mfi != null &&
                    Mfi.Equals(input.Mfi))
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
                if (Mfi != null)
                    hashCode = hashCode * 59 + Mfi.GetHashCode();
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The date_time and mi values of a Mass Index technical indicator calculation
    /// </summary>
    [DataContract]
    public sealed partial class MassIndexTechnicalValue : IEquatable<MassIndexTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassIndexTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Mi">The Mass Index calculation value.</param>
        public MassIndexTechnicalValue(DateTime? DateTime = default, float? Mi = default)
        {
            this.DateTime = DateTime;
            this.Mi = Mi;
        }

        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name = "date_time", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Mass Index calculation value
        /// </summary>
        /// <value>The Mass Index calculation value</value>
        [DataMember(Name = "mi", EmitDefaultValue = false)]
        public float? Mi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MassIndexTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append('\n');
            sb.Append("  Mi: ").Append(Mi).Append('\n');
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
            return Equals(obj as MassIndexTechnicalValue);
        }

        /// <summary>
        /// Returns true if MassIndexTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of MassIndexTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MassIndexTechnicalValue input)
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
                    Mi == input.Mi ||
                    (Mi != null &&
                    Mi.Equals(input.Mi))
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
                if (Mi != null)
                    hashCode = hashCode * 59 + Mi.GetHashCode();
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
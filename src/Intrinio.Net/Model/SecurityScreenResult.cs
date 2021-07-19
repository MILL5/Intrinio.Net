using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// A security that matches the screen and its corresponding screened properties
    /// </summary>
    [DataContract]
    public sealed partial class SecurityScreenResult : IEquatable<SecurityScreenResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityScreenResult" /> class.
        /// </summary>
        /// <param name="Security">Security.</param>
        /// <param name="Data">Data.</param>
        public SecurityScreenResult(SecuritySummary Security = default, List<SecurityScreenResultData> Data = default)
        {
            this.Security = Security;
            this.Data = Data;
        }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<SecurityScreenResultData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityScreenResult {\n");
            sb.Append("  Security: ").Append(Security).Append('\n');
            sb.Append("  Data: ").Append(Data).Append('\n');
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
            return Equals(obj as SecurityScreenResult);
        }

        /// <summary>
        /// Returns true if SecurityScreenResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityScreenResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityScreenResult input)
        {
            if (input == null)
                return false;

            return
                (
                    Security == input.Security ||
                    (Security != null &&
                    Security.Equals(input.Security))
                ) &&
                (
                    Data == input.Data ||
                    Data != null &&
                    Data.SequenceEqual(input.Data)
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
                if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The summary of a financial instrument representing shares of ownership in a publicly-traded company
    /// </summary>
    [DataContract]
    public sealed partial class SecurityType : IEquatable<SecurityType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityType" /> class.
        /// </summary>
        /// <param name="Name">The name of the Security.</param>
        /// <param name="Code">A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;).</param>

        public SecurityType(string Code = default, string Name = default)
        {
            this.Code = Code;
            this.Name = Name;
        }

        /// <summary>
        /// A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)
        /// </summary>
        /// <value>A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the Security
        /// </summary>
        /// <value>The name of the Security</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityType {\n");
            sb.Append("  Code: ").Append(Code).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
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
            return Equals(obj as SecurityType);
        }

        /// <summary>
        /// Returns true if SecurityType instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityType input)
        {
            if (input == null)
                return false;

            return
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) &&
                (
                    Code == input.Code ||
                    (Code != null &&
                    Code.Equals(input.Code))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
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

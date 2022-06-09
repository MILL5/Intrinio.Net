using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseSecuritiesSearch
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSecuritiesSearch : IEquatable<ApiResponseSecuritiesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecuritiesSearch" /> class.
        /// </summary>
        /// <param name="Securities">Securities.</param>
        public ApiResponseSecuritiesSearch(List<SecuritySummary> Securities = default)
        {
            this.Securities = Securities;
        }

        /// <summary>
        /// Gets or Sets Securities
        /// </summary>
        [DataMember(Name = "securities", EmitDefaultValue = false)]
        public List<SecuritySummary> Securities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecuritiesSearch {\n");
            sb.Append("  Securities: ").Append(Securities).Append('\n');
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
            return Equals(obj as ApiResponseSecuritiesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseSecuritiesSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecuritiesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecuritiesSearch input)
        {
            if (input == null)
                return false;

            return
                (
                    Securities == input.Securities ||
                    Securities != null &&
                    Securities.SequenceEqual(input.Securities)
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
                if (Securities != null)
                    hashCode = hashCode * 59 + Securities.GetHashCode();
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
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
    /// ApiResponseSICIndicesSearch
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseSicIndicesSearch : IEquatable<ApiResponseSicIndicesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSicIndicesSearch" /> class.
        /// </summary>
        /// <param name="Indices">Indices.</param>
        public ApiResponseSicIndicesSearch(List<SicIndex> Indices = default)
        {
            this.Indices = Indices;
        }

        /// <summary>
        /// Gets or Sets Indices
        /// </summary>
        [DataMember(Name = "indices", EmitDefaultValue = false)]
        public List<SicIndex> Indices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSICIndicesSearch {\n");
            sb.Append("  Indices: ").Append(Indices).Append('\n');
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
            return Equals(obj as ApiResponseSicIndicesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseSICIndicesSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSICIndicesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSicIndicesSearch input)
        {
            if (input == null)
                return false;

            return
                (
                    Indices == input.Indices ||
                    Indices != null &&
                    Indices.SequenceEqual(input.Indices)
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
                if (Indices != null)
                    hashCode = hashCode * 59 + Indices.GetHashCode();
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
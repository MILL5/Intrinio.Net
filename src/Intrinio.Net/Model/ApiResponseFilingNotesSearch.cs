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
    /// ApiResponseFilingNotesSearch
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseFilingNotesSearch : IEquatable<ApiResponseFilingNotesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseFilingNotesSearch" /> class.
        /// </summary>
        /// <param name="FilingNotes">FilingNotes.</param>
        public ApiResponseFilingNotesSearch(List<FilingNoteSummary> FilingNotes = default)
        {
            this.FilingNotes = FilingNotes;
        }

        /// <summary>
        /// Gets or Sets FilingNotes
        /// </summary>
        [DataMember(Name = "filing_notes", EmitDefaultValue = false)]
        public List<FilingNoteSummary> FilingNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseFilingNotesSearch {\n");
            sb.Append("  FilingNotes: ").Append(FilingNotes).Append('\n');
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
            return Equals(obj as ApiResponseFilingNotesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseFilingNotesSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiResponseFilingNotesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseFilingNotesSearch other)
        {
            if (other == null)
                return false;

            return
                (
                    FilingNotes == other.FilingNotes ||
                    FilingNotes != null &&
                    FilingNotes.SequenceEqual(other.FilingNotes)
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
                if (FilingNotes != null)
                    hashCode = hashCode * 59 + FilingNotes.GetHashCode();
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
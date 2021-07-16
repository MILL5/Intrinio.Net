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
    /// ApiResponseOptions
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseOptions : IEquatable<ApiResponseOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptions" /> class.
        /// </summary>
        /// <param name="Options">A list of options contracts with the given symbol.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseOptions(List<Option> Options = default, string NextPage = default)
        {
            this.Options = Options;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// A list of options contracts with the given symbol
        /// </summary>
        /// <value>A list of options contracts with the given symbol</value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Option> Options { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name = "next_page", EmitDefaultValue = false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptions {\n");
            sb.Append("  Options: ").Append(Options).Append('\n');
            sb.Append("  NextPage: ").Append(NextPage).Append('\n');
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
            return Equals(obj as ApiResponseOptions);
        }

        /// <summary>
        /// Returns true if ApiResponseOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptions input)
        {
            if (input == null)
                return false;

            return
                (
                    Options == input.Options ||
                    Options != null &&
                    Options.SequenceEqual(input.Options)
                ) &&
                (
                    NextPage == input.NextPage ||
                    (NextPage != null &&
                    NextPage.Equals(input.NextPage))
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
                if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                if (NextPage != null)
                    hashCode = hashCode * 59 + NextPage.GetHashCode();
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
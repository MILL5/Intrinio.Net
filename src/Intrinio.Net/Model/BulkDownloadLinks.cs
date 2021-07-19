using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The url and name of a bulk download link
    /// </summary>
    [DataContract]
    public sealed partial class BulkDownloadLinks : IEquatable<BulkDownloadLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDownloadLinks" /> class.
        /// </summary>
        /// <param name="Name">The name of the file.</param>
        /// <param name="Url">Link for accessing the bulk download. Expires in 24 hours..</param>
        public BulkDownloadLinks(string Name = default, string Url = default)
        {
            this.Name = Name;
            this.Url = Url;
        }

        /// <summary>
        /// The name of the file
        /// </summary>
        /// <value>The name of the file</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Link for accessing the bulk download. Expires in 24 hours.
        /// </summary>
        /// <value>Link for accessing the bulk download. Expires in 24 hours.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkDownloadLinks {\n");
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Url: ").Append(Url).Append('\n');
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
            return Equals(obj as BulkDownloadLinks);
        }

        /// <summary>
        /// Returns true if BulkDownloadLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkDownloadLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkDownloadLinks input)
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
                    Url == input.Url ||
                    (Url != null &&
                    Url.Equals(input.Url))
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
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
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
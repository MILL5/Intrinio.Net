using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model;

/// <summary>
/// ApiResponseDataTags
/// </summary>
[DataContract]
public sealed partial class ApiResponseDataTags : IEquatable<ApiResponseDataTags>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponseDataTags" /> class.
    /// </summary>
    /// <param name="Tags">DataTags.</param>
    /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
    public ApiResponseDataTags(List<DataTag> DataTags = default, string NextPage = default)
    {
        this.Tags = DataTags;
        this.NextPage = NextPage;
    }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<DataTag> Tags { get; set; }

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
        sb.Append("class ApiResponseDataTags {\n");
        sb.Append("  Tags: ").Append(Tags).Append('\n');
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
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        return Equals(obj as ApiResponseDataTags);
    }

    /// <summary>
    /// Returns true if ApiResponseDataTags instances are equal
    /// </summary>
    /// <param name="other">Instance of ApiResponseDataTags to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ApiResponseDataTags other)
    {
        if (other == null)
            return false;

        return
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                NextPage == other.NextPage ||
                (NextPage != null &&
                NextPage.Equals(other.NextPage))
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
            if (Tags != null)
                hashCode = hashCode * 59 + Tags.GetHashCode();
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

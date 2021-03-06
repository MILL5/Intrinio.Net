

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Intrinio.Net.Client.SwaggerDateConverter;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseOptionsChainRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsChainRealtime :  IEquatable<ApiResponseOptionsChainRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsChainRealtime" /> class.
        /// </summary>
        /// <param name="Chain">A list of realtime options for the provided expiration date their respective option prices..</param>
        public ApiResponseOptionsChainRealtime(List<OptionChainRealtime> Chain = default(List<OptionChainRealtime>))
        {
            this.Chain = Chain;
        }
        
        /// <summary>
        /// A list of realtime options for the provided expiration date their respective option prices.
        /// </summary>
        /// <value>A list of realtime options for the provided expiration date their respective option prices.</value>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public List<OptionChainRealtime> Chain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsChainRealtime {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
        public override bool Equals(object input)
        {
            return Equals(input as ApiResponseOptionsChainRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsChainRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsChainRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsChainRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    Chain == input.Chain ||
                    Chain != null &&
                    Chain.SequenceEqual(input.Chain)
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
                if (Chain != null)
                    hashCode = hashCode * 59 + Chain.GetHashCode();
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

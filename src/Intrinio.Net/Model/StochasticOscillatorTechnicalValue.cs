

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
    /// The date_time, sr, and sr_signal values of a Stochastic Oscillator technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class StochasticOscillatorTechnicalValue :  IEquatable<StochasticOscillatorTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StochasticOscillatorTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Sr">The Stochastic Oscillator calculation value.</param>
        /// <param name="SrSignal">The Stochastic Oscillator signal line value.</param>
        public StochasticOscillatorTechnicalValue(DateTime? DateTime = default(DateTime?), float? Sr = default(float?), float? SrSignal = default(float?))
        {
            this.DateTime = DateTime;
            this.Sr = Sr;
            this.SrSignal = SrSignal;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Stochastic Oscillator calculation value
        /// </summary>
        /// <value>The Stochastic Oscillator calculation value</value>
        [DataMember(Name="sr", EmitDefaultValue=false)]
        public float? Sr { get; set; }

        /// <summary>
        /// The Stochastic Oscillator signal line value
        /// </summary>
        /// <value>The Stochastic Oscillator signal line value</value>
        [DataMember(Name="sr_signal", EmitDefaultValue=false)]
        public float? SrSignal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StochasticOscillatorTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Sr: ").Append(Sr).Append("\n");
            sb.Append("  SrSignal: ").Append(SrSignal).Append("\n");
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
            return Equals(input as StochasticOscillatorTechnicalValue);
        }

        /// <summary>
        /// Returns true if StochasticOscillatorTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of StochasticOscillatorTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StochasticOscillatorTechnicalValue input)
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
                    Sr == input.Sr ||
                    (Sr != null &&
                    Sr.Equals(input.Sr))
                ) && 
                (
                    SrSignal == input.SrSignal ||
                    (SrSignal != null &&
                    SrSignal.Equals(input.SrSignal))
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
                if (Sr != null)
                    hashCode = hashCode * 59 + Sr.GetHashCode();
                if (SrSignal != null)
                    hashCode = hashCode * 59 + SrSignal.GetHashCode();
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

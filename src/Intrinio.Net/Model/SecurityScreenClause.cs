

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
    /// A conditional clause used tp screen securities
    /// </summary>
    [DataContract]
    public partial class SecurityScreenClause :  IEquatable<SecurityScreenClause>, IValidatableObject
    {
        /// <summary>
        /// The logic operator to use when screening
        /// </summary>
        /// <value>The logic operator to use when screening</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum Eq for value: eq
            /// </summary>
            [EnumMember(Value = "eq")]
            Eq = 1,
            
            /// <summary>
            /// Enum Gt for value: gt
            /// </summary>
            [EnumMember(Value = "gt")]
            Gt = 2,
            
            /// <summary>
            /// Enum Gte for value: gte
            /// </summary>
            [EnumMember(Value = "gte")]
            Gte = 3,
            
            /// <summary>
            /// Enum Lt for value: lt
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt = 4,
            
            /// <summary>
            /// Enum Lte for value: lte
            /// </summary>
            [EnumMember(Value = "lte")]
            Lte = 5,
            
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 6
        }

        /// <summary>
        /// The logic operator to use when screening
        /// </summary>
        /// <value>The logic operator to use when screening</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityScreenClause" /> class.
        /// </summary>
        /// <param name="Field">The field to use when screening, such as an Intrinio Data Tag.</param>
        /// <param name="Operator">The logic operator to use when screening.</param>
        /// <param name="Value">The value to screen by.</param>
        public SecurityScreenClause(string Field = default(string), OperatorEnum? Operator = default(OperatorEnum?), string Value = default(string))
        {
            this.Field = Field;
            this.Operator = Operator;
            this.Value = Value;
        }
        
        /// <summary>
        /// The field to use when screening, such as an Intrinio Data Tag
        /// </summary>
        /// <value>The field to use when screening, such as an Intrinio Data Tag</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }


        /// <summary>
        /// The value to screen by
        /// </summary>
        /// <value>The value to screen by</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityScreenClause {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as SecurityScreenClause);
        }

        /// <summary>
        /// Returns true if SecurityScreenClause instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityScreenClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityScreenClause input)
        {
            if (input == null)
                return false;

            return 
                (
                    Field == input.Field ||
                    (Field != null &&
                    Field.Equals(input.Field))
                ) && 
                (
                    Operator == input.Operator ||
                    (Operator != null &&
                    Operator.Equals(input.Operator))
                ) && 
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
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
                if (Field != null)
                    hashCode = hashCode * 59 + Field.GetHashCode();
                if (Operator != null)
                    hashCode = hashCode * 59 + Operator.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
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

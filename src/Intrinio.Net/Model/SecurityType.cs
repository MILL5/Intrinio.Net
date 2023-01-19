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
    public sealed partial class SecurityType : IEquatable<SecurityType>
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
    }
}

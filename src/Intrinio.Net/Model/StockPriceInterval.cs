using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// Open, High, Low, Close, and Volume for a particular interval
    /// </summary>
    [DataContract]
    public sealed partial class StockPriceInterval : IEquatable<StockPriceInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPriceInterval" /> class.
        /// </summary>
        /// <param name="Time">The timestamp that the &#x60;last_price&#x60; represents..</param>
        /// <param name="Open">The price at the beginning of the period.</param>
        /// <param name="Close">The price at the end of the period.</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The lowest price over the span of the period.</param>
        /// <param name="Volume">The number of shares exchanged during the period.</param>
        public StockPriceInterval(DateTime? Time = default, decimal? Open = default, decimal? Close = default, decimal? High = default, decimal? Low = default, decimal? Volume = default)
        {
            this.Time = Time;
            this.Open = Open;
            this.Close = Close;
            this.High = High;
            this.Low = Low;
            this.Volume = Volume;
        }

        /// <summary>
        /// The timestamp that the &#x60;last_price&#x60; represents.
        /// </summary>
        /// <value>The timestamp that the &#x60;last_price&#x60; represents.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The price at the beginning of the period
        /// </summary>
        /// <value>The price at the beginning of the period</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The price at the end of the period
        /// </summary>
        /// <value>The price at the end of the period</value>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The highest price over the span of the period
        /// </summary>
        /// <value>The highest price over the span of the period</value>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest price over the span of the period
        /// </summary>
        /// <value>The lowest price over the span of the period</value>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The number of shares exchanged during the period
        /// </summary>
        /// <value>The number of shares exchanged during the period</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockPriceInterval {\n");
            sb.Append("  Time: ").Append(Time).Append('\n');
            sb.Append("  Open: ").Append(Open).Append('\n');
            sb.Append("  Close: ").Append(Close).Append('\n');
            sb.Append("  High: ").Append(High).Append('\n');
            sb.Append("  Low: ").Append(Low).Append('\n');
            sb.Append("  Volume: ").Append(Volume).Append('\n');
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
            return Equals(obj as StockPriceInterval);
        }

        /// <summary>
        /// Returns true if StockPriceInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of StockPriceInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPriceInterval input)
        {
            if (input == null)
                return false;

            return
                (
                    Time == input.Time ||
                    (Time != null &&
                    Time.Equals(input.Time))
                ) &&
                (
                    Open == input.Open ||
                    (Open != null &&
                    Open.Equals(input.Open))
                ) &&
                (
                    Close == input.Close ||
                    (Close != null &&
                    Close.Equals(input.Close))
                ) &&
                (
                    High == input.High ||
                    (High != null &&
                    High.Equals(input.High))
                ) &&
                (
                    Low == input.Low ||
                    (Low != null &&
                    Low.Equals(input.Low))
                ) &&
                (
                    Volume == input.Volume ||
                    (Volume != null &&
                    Volume.Equals(input.Volume))
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
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                if (Open != null)
                    hashCode = hashCode * 59 + Open.GetHashCode();
                if (Close != null)
                    hashCode = hashCode * 59 + Close.GetHashCode();
                if (High != null)
                    hashCode = hashCode * 59 + High.GetHashCode();
                if (Low != null)
                    hashCode = hashCode * 59 + Low.GetHashCode();
                if (Volume != null)
                    hashCode = hashCode * 59 + Volume.GetHashCode();
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
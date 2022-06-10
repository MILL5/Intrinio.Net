using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// A stock price adjustment for a security on a given day, most frequently representing a split and/or dividend.
    /// </summary>
    [DataContract]
    public sealed partial class StockPriceAdjustment : IEquatable<StockPriceAdjustment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPriceAdjustment" /> class.
        /// </summary>
        /// <param name="Date">The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date..</param>
        /// <param name="Factor">The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices..</param>
        /// <param name="Dividend">The dividend amount, if a dividend was paid..</param>
        /// <param name="DividendCurrency">The currency of the dividend, if known..</param>
        /// <param name="SplitRatio">The ratio of the stock split, if a stock split occurred..</param>
        /// <param name="Security">The Security of the stock price.</param>
        public StockPriceAdjustment(DateTime? Date = default, decimal? Factor = default, decimal? Dividend = default, string DividendCurrency = default, decimal? SplitRatio = default, SecuritySummary Security = default)
        {
            this.Date = Date;
            this.Factor = Factor;
            this.Dividend = Dividend;
            this.DividendCurrency = DividendCurrency;
            this.SplitRatio = SplitRatio;
            this.Security = Security;
        }

        /// <summary>
        /// The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date.
        /// </summary>
        /// <value>The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.
        /// </summary>
        /// <value>The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.</value>
        [DataMember(Name = "factor", EmitDefaultValue = false)]
        public decimal? Factor { get; set; }

        /// <summary>
        /// The dividend amount, if a dividend was paid.
        /// </summary>
        /// <value>The dividend amount, if a dividend was paid.</value>
        [DataMember(Name = "dividend", EmitDefaultValue = false)]
        public decimal? Dividend { get; set; }

        /// <summary>
        /// The currency of the dividend, if known.
        /// </summary>
        /// <value>The currency of the dividend, if known.</value>
        [DataMember(Name = "dividend_currency", EmitDefaultValue = false)]
        public string DividendCurrency { get; set; }

        /// <summary>
        /// The ratio of the stock split, if a stock split occurred.
        /// </summary>
        /// <value>The ratio of the stock split, if a stock split occurred.</value>
        [DataMember(Name = "split_ratio", EmitDefaultValue = false)]
        public decimal? SplitRatio { get; set; }

        /// <summary>
        /// The Security of the stock price
        /// </summary>
        /// <value>The Security of the stock price</value>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockPriceAdjustment {\n");
            sb.Append("  Date: ").Append(Date).Append('\n');
            sb.Append("  Factor: ").Append(Factor).Append('\n');
            sb.Append("  Dividend: ").Append(Dividend).Append('\n');
            sb.Append("  DividendCurrency: ").Append(DividendCurrency).Append('\n');
            sb.Append("  SplitRatio: ").Append(SplitRatio).Append('\n');
            sb.Append("  Security: ").Append(Security).Append('\n');
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
            return Equals(obj as StockPriceAdjustment);
        }

        /// <summary>
        /// Returns true if StockPriceAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of StockPriceAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPriceAdjustment other)
        {
            if (other == null)
                return false;

            return
                (
                    Date == other.Date ||
                    (Date != null &&
                    Date.Equals(other.Date))
                ) &&
                (
                    Factor == other.Factor ||
                    (Factor != null &&
                    Factor.Equals(other.Factor))
                ) &&
                (
                    Dividend == other.Dividend ||
                    (Dividend != null &&
                    Dividend.Equals(other.Dividend))
                ) &&
                (
                    DividendCurrency == other.DividendCurrency ||
                    (DividendCurrency != null &&
                    DividendCurrency.Equals(other.DividendCurrency))
                ) &&
                (
                    SplitRatio == other.SplitRatio ||
                    (SplitRatio != null &&
                    SplitRatio.Equals(other.SplitRatio))
                ) &&
                (
                    Security == other.Security ||
                    (Security != null &&
                    Security.Equals(other.Security))
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
                if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                if (Factor != null)
                    hashCode = hashCode * 59 + Factor.GetHashCode();
                if (Dividend != null)
                    hashCode = hashCode * 59 + Dividend.GetHashCode();
                if (DividendCurrency != null)
                    hashCode = hashCode * 59 + DividendCurrency.GetHashCode();
                if (SplitRatio != null)
                    hashCode = hashCode * 59 + SplitRatio.GetHashCode();
                if (Security != null)
                    hashCode = hashCode * 59 + Security.GetHashCode();
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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// The stock price of a security on a given date.
    /// </summary>
    [DataContract]
    public sealed partial class StockPrice : IEquatable<StockPrice>, IValidatableObject
    {
        /// <summary>
        /// The type of period that the stock price represents
        /// </summary>
        /// <value>The type of period that the stock price represents</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodFrequency
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Quarterly for value: quarterly
            /// </summary>
            [EnumMember(Value = "quarterly")]
            Quarterly = 4,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 5
        }

        /// <summary>
        /// The type of period that the stock price represents
        /// </summary>
        /// <value>The type of period that the stock price represents</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public PeriodFrequency? Frequency { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockPrice" /> class.
        /// </summary>
        /// <param name="Date">The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc).</param>
        /// <param name="Intraperiod">If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period.</param>
        /// <param name="Frequency">The type of period that the stock price represents.</param>
        /// <param name="Open">The price at the beginning of the period.</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The lowest price over the span of the period.</param>
        /// <param name="Close">The price at the end of the period.</param>
        /// <param name="Volume">The number of shares exchanged during the period.</param>
        /// <param name="AdjOpen">The price at the beginning of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjHigh">The highest price over the span of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjLow">The lowest price over the span of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjClose">The price at the end of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjVolume">The number of shares exchanged during the period, adjusted for splits and dividends.</param>
        /// <param name="Factor">The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices..</param>
        /// <param name="SplitRatio">The ratio of the stock split, if a stock split occurred..</param>
        /// <param name="Dividend">The dividend amount, if a dividend was paid..</param>
        /// <param name="Change">The difference in price from the last price for this frequency.</param>
        /// <param name="PercentChange">The percent difference in price from the last price for this frequency.</param>
        /// <param name="FiftyTwoWeekHigh">The 52 week high price (daily only).</param>
        /// <param name="FiftyTwoWeekLow">The 52 week low price (daily only).</param>
        /// <param name="Security">The Security of the stock price.</param>
        public StockPrice(DateTime? Date = default, bool? Intraperiod = default, PeriodFrequency? Frequency = default, decimal? Open = default, decimal? High = default, decimal? Low = default, decimal? Close = default, decimal? Volume = default, decimal? AdjOpen = default, decimal? AdjHigh = default, decimal? AdjLow = default, decimal? AdjClose = default, decimal? AdjVolume = default, decimal? Factor = default, decimal? SplitRatio = default, decimal? Dividend = default, decimal? Change = default, decimal? PercentChange = default, decimal? FiftyTwoWeekHigh = default, decimal? FiftyTwoWeekLow = default, SecuritySummary Security = default)
        {
            this.Date = Date;
            this.Intraperiod = Intraperiod;
            this.Frequency = Frequency;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Close = Close;
            this.Volume = Volume;
            this.AdjOpen = AdjOpen;
            this.AdjHigh = AdjHigh;
            this.AdjLow = AdjLow;
            this.AdjClose = AdjClose;
            this.AdjVolume = AdjVolume;
            this.Factor = Factor;
            this.SplitRatio = SplitRatio;
            this.Dividend = Dividend;
            this.Change = Change;
            this.PercentChange = PercentChange;
            this.FiftyTwoWeekHigh = FiftyTwoWeekHigh;
            this.FiftyTwoWeekLow = FiftyTwoWeekLow;
            this.Security = Security;
        }

        /// <summary>
        /// The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc)
        /// </summary>
        /// <value>The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc)</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period
        /// </summary>
        /// <value>If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period</value>
        [DataMember(Name = "intraperiod", EmitDefaultValue = false)]
        public bool? Intraperiod { get; set; }

        /// <summary>
        /// The price at the beginning of the period
        /// </summary>
        /// <value>The price at the beginning of the period</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public decimal? Open { get; set; }

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
        /// The price at the end of the period
        /// </summary>
        /// <value>The price at the end of the period</value>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The number of shares exchanged during the period
        /// </summary>
        /// <value>The number of shares exchanged during the period</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The price at the beginning of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The price at the beginning of the period, adjusted for splits and dividends</value>
        [DataMember(Name = "adj_open", EmitDefaultValue = false)]
        public decimal? AdjOpen { get; set; }

        /// <summary>
        /// The highest price over the span of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The highest price over the span of the period, adjusted for splits and dividends</value>
        [DataMember(Name = "adj_high", EmitDefaultValue = false)]
        public decimal? AdjHigh { get; set; }

        /// <summary>
        /// The lowest price over the span of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The lowest price over the span of the period, adjusted for splits and dividends</value>
        [DataMember(Name = "adj_low", EmitDefaultValue = false)]
        public decimal? AdjLow { get; set; }

        /// <summary>
        /// The price at the end of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The price at the end of the period, adjusted for splits and dividends</value>
        [DataMember(Name = "adj_close", EmitDefaultValue = false)]
        public decimal? AdjClose { get; set; }

        /// <summary>
        /// The number of shares exchanged during the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The number of shares exchanged during the period, adjusted for splits and dividends</value>
        [DataMember(Name = "adj_volume", EmitDefaultValue = false)]
        public decimal? AdjVolume { get; set; }

        /// <summary>
        /// The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.
        /// </summary>
        /// <value>The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.</value>
        [DataMember(Name = "factor", EmitDefaultValue = false)]
        public decimal? Factor { get; set; }

        /// <summary>
        /// The ratio of the stock split, if a stock split occurred.
        /// </summary>
        /// <value>The ratio of the stock split, if a stock split occurred.</value>
        [DataMember(Name = "split_ratio", EmitDefaultValue = false)]
        public decimal? SplitRatio { get; set; }

        /// <summary>
        /// The dividend amount, if a dividend was paid.
        /// </summary>
        /// <value>The dividend amount, if a dividend was paid.</value>
        [DataMember(Name = "dividend", EmitDefaultValue = false)]
        public decimal? Dividend { get; set; }

        /// <summary>
        /// The difference in price from the last price for this frequency
        /// </summary>
        /// <value>The difference in price from the last price for this frequency</value>
        [DataMember(Name = "change", EmitDefaultValue = false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percent difference in price from the last price for this frequency
        /// </summary>
        /// <value>The percent difference in price from the last price for this frequency</value>
        [DataMember(Name = "percent_change", EmitDefaultValue = false)]
        public decimal? PercentChange { get; set; }

        /// <summary>
        /// The 52 week high price (daily only)
        /// </summary>
        /// <value>The 52 week high price (daily only)</value>
        [DataMember(Name = "fifty_two_week_high", EmitDefaultValue = false)]
        public decimal? FiftyTwoWeekHigh { get; set; }

        /// <summary>
        /// The 52 week low price (daily only)
        /// </summary>
        /// <value>The 52 week low price (daily only)</value>
        [DataMember(Name = "fifty_two_week_low", EmitDefaultValue = false)]
        public decimal? FiftyTwoWeekLow { get; set; }

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
            sb.Append("class StockPrice {\n");
            sb.Append("  Date: ").Append(Date).Append('\n');
            sb.Append("  Intraperiod: ").Append(Intraperiod).Append('\n');
            sb.Append("  Frequency: ").Append(Frequency).Append('\n');
            sb.Append("  Open: ").Append(Open).Append('\n');
            sb.Append("  High: ").Append(High).Append('\n');
            sb.Append("  Low: ").Append(Low).Append('\n');
            sb.Append("  Close: ").Append(Close).Append('\n');
            sb.Append("  Volume: ").Append(Volume).Append('\n');
            sb.Append("  AdjOpen: ").Append(AdjOpen).Append('\n');
            sb.Append("  AdjHigh: ").Append(AdjHigh).Append('\n');
            sb.Append("  AdjLow: ").Append(AdjLow).Append('\n');
            sb.Append("  AdjClose: ").Append(AdjClose).Append('\n');
            sb.Append("  AdjVolume: ").Append(AdjVolume).Append('\n');
            sb.Append("  Factor: ").Append(Factor).Append('\n');
            sb.Append("  SplitRatio: ").Append(SplitRatio).Append('\n');
            sb.Append("  Dividend: ").Append(Dividend).Append('\n');
            sb.Append("  Change: ").Append(Change).Append('\n');
            sb.Append("  PercentChange: ").Append(PercentChange).Append('\n');
            sb.Append("  FiftyTwoWeekHigh: ").Append(FiftyTwoWeekHigh).Append('\n');
            sb.Append("  FiftyTwoWeekLow: ").Append(FiftyTwoWeekLow).Append('\n');
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
            return Equals(obj as StockPrice);
        }

        /// <summary>
        /// Returns true if StockPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of StockPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPrice input)
        {
            if (input == null)
                return false;

            return
                (
                    Date == input.Date ||
                    (Date != null &&
                    Date.Equals(input.Date))
                ) &&
                (
                    Intraperiod == input.Intraperiod ||
                    (Intraperiod != null &&
                    Intraperiod.Equals(input.Intraperiod))
                ) &&
                (
                    Frequency == input.Frequency ||
                    (Frequency != null &&
                    Frequency.Equals(input.Frequency))
                ) &&
                (
                    Open == input.Open ||
                    (Open != null &&
                    Open.Equals(input.Open))
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
                    Close == input.Close ||
                    (Close != null &&
                    Close.Equals(input.Close))
                ) &&
                (
                    Volume == input.Volume ||
                    (Volume != null &&
                    Volume.Equals(input.Volume))
                ) &&
                (
                    AdjOpen == input.AdjOpen ||
                    (AdjOpen != null &&
                    AdjOpen.Equals(input.AdjOpen))
                ) &&
                (
                    AdjHigh == input.AdjHigh ||
                    (AdjHigh != null &&
                    AdjHigh.Equals(input.AdjHigh))
                ) &&
                (
                    AdjLow == input.AdjLow ||
                    (AdjLow != null &&
                    AdjLow.Equals(input.AdjLow))
                ) &&
                (
                    AdjClose == input.AdjClose ||
                    (AdjClose != null &&
                    AdjClose.Equals(input.AdjClose))
                ) &&
                (
                    AdjVolume == input.AdjVolume ||
                    (AdjVolume != null &&
                    AdjVolume.Equals(input.AdjVolume))
                ) &&
                (
                    Factor == input.Factor ||
                    (Factor != null &&
                    Factor.Equals(input.Factor))
                ) &&
                (
                    SplitRatio == input.SplitRatio ||
                    (SplitRatio != null &&
                    SplitRatio.Equals(input.SplitRatio))
                ) &&
                (
                    Dividend == input.Dividend ||
                    (Dividend != null &&
                    Dividend.Equals(input.Dividend))
                ) &&
                (
                    Change == input.Change ||
                    (Change != null &&
                    Change.Equals(input.Change))
                ) &&
                (
                    PercentChange == input.PercentChange ||
                    (PercentChange != null &&
                    PercentChange.Equals(input.PercentChange))
                ) &&
                (
                    FiftyTwoWeekHigh == input.FiftyTwoWeekHigh ||
                    (FiftyTwoWeekHigh != null &&
                    FiftyTwoWeekHigh.Equals(input.FiftyTwoWeekHigh))
                ) &&
                (
                    FiftyTwoWeekLow == input.FiftyTwoWeekLow ||
                    (FiftyTwoWeekLow != null &&
                    FiftyTwoWeekLow.Equals(input.FiftyTwoWeekLow))
                ) &&
                (
                    Security == input.Security ||
                    (Security != null &&
                    Security.Equals(input.Security))
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
                if (Intraperiod != null)
                    hashCode = hashCode * 59 + Intraperiod.GetHashCode();
                if (Frequency != null)
                    hashCode = hashCode * 59 + Frequency.GetHashCode();
                if (Open != null)
                    hashCode = hashCode * 59 + Open.GetHashCode();
                if (High != null)
                    hashCode = hashCode * 59 + High.GetHashCode();
                if (Low != null)
                    hashCode = hashCode * 59 + Low.GetHashCode();
                if (Close != null)
                    hashCode = hashCode * 59 + Close.GetHashCode();
                if (Volume != null)
                    hashCode = hashCode * 59 + Volume.GetHashCode();
                if (AdjOpen != null)
                    hashCode = hashCode * 59 + AdjOpen.GetHashCode();
                if (AdjHigh != null)
                    hashCode = hashCode * 59 + AdjHigh.GetHashCode();
                if (AdjLow != null)
                    hashCode = hashCode * 59 + AdjLow.GetHashCode();
                if (AdjClose != null)
                    hashCode = hashCode * 59 + AdjClose.GetHashCode();
                if (AdjVolume != null)
                    hashCode = hashCode * 59 + AdjVolume.GetHashCode();
                if (Factor != null)
                    hashCode = hashCode * 59 + Factor.GetHashCode();
                if (SplitRatio != null)
                    hashCode = hashCode * 59 + SplitRatio.GetHashCode();
                if (Dividend != null)
                    hashCode = hashCode * 59 + Dividend.GetHashCode();
                if (Change != null)
                    hashCode = hashCode * 59 + Change.GetHashCode();
                if (PercentChange != null)
                    hashCode = hashCode * 59 + PercentChange.GetHashCode();
                if (FiftyTwoWeekHigh != null)
                    hashCode = hashCode * 59 + FiftyTwoWeekHigh.GetHashCode();
                if (FiftyTwoWeekLow != null)
                    hashCode = hashCode * 59 + FiftyTwoWeekLow.GetHashCode();
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
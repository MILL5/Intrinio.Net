using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// A dividend record for the identifier
    /// </summary>
    [DataContract]
    public sealed partial class DividendRecord : IEquatable<DividendRecord>, IValidatableObject
    {
        /// <summary>
        /// Status of the dividend
        /// </summary>
        /// <value>Status of the dividend</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DividendStatus
        {
            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 1,

            /// <summary>
            /// Enum X for value: X
            /// </summary>
            [EnumMember(Value = "X")]
            X = 2,

            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 3,

            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 4
        }

        /// <summary>
        /// Status of the dividend
        /// </summary>
        /// <value>Status of the dividend</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DividendStatus? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DividendRecord" /> class.
        /// </summary>
        /// <param name="ExDividend">Amount of dividend in US dollars.</param>
        /// <param name="Currency">The 3-digit currency code the dividend amount was reported in.</param>
        /// <param name="AnnouncementDate">Date dividend was announced.</param>
        /// <param name="RecordDate">Date before which holders-of-record will receive the dividend.</param>
        /// <param name="PayDate">Date the divdiend was paid.</param>
        /// <param name="Frequency">Identifies payment frequency of announced dividend.</param>
        /// <param name="Status">Status of the dividend.</param>
        /// <param name="ForwardYield">The forward dividend yield.</param>
        /// <param name="ForwardRate">The forward dividend rate.</param>
        /// <param name="LastExDividendDate">The last reported day the stock starts trading without the value of its next dividend payment.</param>
        /// <param name="Security">Security.</param>
        public DividendRecord(decimal? ExDividend = default, string Currency = default, DateTime? AnnouncementDate = default, DateTime? RecordDate = default, DateTime? PayDate = default, string Frequency = default, DividendStatus? Status = default, decimal? ForwardYield = default, decimal? ForwardRate = default, DateTime? LastExDividendDate = default, SecuritySummary Security = default)
        {
            this.ExDividend = ExDividend;
            this.Currency = Currency;
            this.AnnouncementDate = AnnouncementDate;
            this.RecordDate = RecordDate;
            this.PayDate = PayDate;
            this.Frequency = Frequency;
            this.Status = Status;
            this.ForwardYield = ForwardYield;
            this.ForwardRate = ForwardRate;
            this.LastExDividendDate = LastExDividendDate;
            this.Security = Security;
        }

        /// <summary>
        /// Amount of dividend in US dollars
        /// </summary>
        /// <value>Amount of dividend in US dollars</value>
        [DataMember(Name = "ex_dividend", EmitDefaultValue = false)]
        public decimal? ExDividend { get; set; }

        /// <summary>
        /// The 3-digit currency code the dividend amount was reported in
        /// </summary>
        /// <value>The 3-digit currency code the dividend amount was reported in</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Date dividend was announced
        /// </summary>
        /// <value>Date dividend was announced</value>
        [DataMember(Name = "announcement_date", EmitDefaultValue = false)]        
        public DateTime? AnnouncementDate { get; set; }

        /// <summary>
        /// Date before which holders-of-record will receive the dividend
        /// </summary>
        /// <value>Date before which holders-of-record will receive the dividend</value>
        [DataMember(Name = "record_date", EmitDefaultValue = false)]
        public DateTime? RecordDate { get; set; }

        /// <summary>
        /// Date the divdiend was paid
        /// </summary>
        /// <value>Date the divdiend was paid</value>
        [DataMember(Name = "pay_date", EmitDefaultValue = false)]
        public DateTime? PayDate { get; set; }

        /// <summary>
        /// Identifies payment frequency of announced dividend
        /// </summary>
        /// <value>Identifies payment frequency of announced dividend</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The forward dividend yield
        /// </summary>
        /// <value>The forward dividend yield</value>
        [DataMember(Name = "forward_yield", EmitDefaultValue = false)]
        public decimal? ForwardYield { get; set; }

        /// <summary>
        /// The forward dividend rate
        /// </summary>
        /// <value>The forward dividend rate</value>
        [DataMember(Name = "forward_rate", EmitDefaultValue = false)]
        public decimal? ForwardRate { get; set; }

        /// <summary>
        /// The last reported day the stock starts trading without the value of its next dividend payment
        /// </summary>
        /// <value>The last reported day the stock starts trading without the value of its next dividend payment</value>
        [DataMember(Name = "last_ex_dividend_date", EmitDefaultValue = false)]
        public DateTime? LastExDividendDate { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DividendRecord {\n");
            sb.Append("  ExDividend: ").Append(ExDividend).Append('\n');
            sb.Append("  Currency: ").Append(Currency).Append('\n');
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append('\n');
            sb.Append("  RecordDate: ").Append(RecordDate).Append('\n');
            sb.Append("  PayDate: ").Append(PayDate).Append('\n');
            sb.Append("  Frequency: ").Append(Frequency).Append('\n');
            sb.Append("  Status: ").Append(Status).Append('\n');
            sb.Append("  ForwardYield: ").Append(ForwardYield).Append('\n');
            sb.Append("  ForwardRate: ").Append(ForwardRate).Append('\n');
            sb.Append("  LastExDividendDate: ").Append(LastExDividendDate).Append('\n');
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as DividendRecord);
        }

        /// <summary>
        /// Returns true if DividendRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of DividendRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DividendRecord input)
        {
            if (input == null)
                return false;

            return
                (
                    ExDividend == input.ExDividend ||
                    (ExDividend != null &&
                    ExDividend.Equals(input.ExDividend))
                ) &&
                (
                    Currency == input.Currency ||
                    (Currency != null &&
                    Currency.Equals(input.Currency))
                ) &&
                (
                    AnnouncementDate == input.AnnouncementDate ||
                    (AnnouncementDate != null &&
                    AnnouncementDate.Equals(input.AnnouncementDate))
                ) &&
                (
                    RecordDate == input.RecordDate ||
                    (RecordDate != null &&
                    RecordDate.Equals(input.RecordDate))
                ) &&
                (
                    PayDate == input.PayDate ||
                    (PayDate != null &&
                    PayDate.Equals(input.PayDate))
                ) &&
                (
                    Frequency == input.Frequency ||
                    (Frequency != null &&
                    Frequency.Equals(input.Frequency))
                ) &&
                (
                    Status == input.Status ||
                    (Status != null &&
                    Status.Equals(input.Status))
                ) &&
                (
                    ForwardYield == input.ForwardYield ||
                    (ForwardYield != null &&
                    ForwardYield.Equals(input.ForwardYield))
                ) &&
                (
                    ForwardRate == input.ForwardRate ||
                    (ForwardRate != null &&
                    ForwardRate.Equals(input.ForwardRate))
                ) &&
                (
                    LastExDividendDate == input.LastExDividendDate ||
                    (LastExDividendDate != null &&
                    LastExDividendDate.Equals(input.LastExDividendDate))
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
                if (ExDividend != null)
                    hashCode = hashCode * 59 + ExDividend.GetHashCode();
                if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                if (AnnouncementDate != null)
                    hashCode = hashCode * 59 + AnnouncementDate.GetHashCode();
                if (RecordDate != null)
                    hashCode = hashCode * 59 + RecordDate.GetHashCode();
                if (PayDate != null)
                    hashCode = hashCode * 59 + PayDate.GetHashCode();
                if (Frequency != null)
                    hashCode = hashCode * 59 + Frequency.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (ForwardYield != null)
                    hashCode = hashCode * 59 + ForwardYield.GetHashCode();
                if (ForwardRate != null)
                    hashCode = hashCode * 59 + ForwardRate.GetHashCode();
                if (LastExDividendDate != null)
                    hashCode = hashCode * 59 + LastExDividendDate.GetHashCode();
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


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
    /// Buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. A rating includes data about mean, strong buys, buys, holds, sells, strong sells, and total. Each rating includes metadata about the corresponding Security.
    /// </summary>
    [DataContract]
    public partial class ZacksAnalystRating :  IEquatable<ZacksAnalystRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksAnalystRating" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the record.</param>
        /// <param name="Date">The date of the Zacks Analyst Rating..</param>
        /// <param name="Mean">The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell)..</param>
        /// <param name="StrongBuys">The number of analysts recommending Strong Buy..</param>
        /// <param name="Buys">The number of analysts recommending Buy..</param>
        /// <param name="Holds">The number of analysts recommending Hold..</param>
        /// <param name="Sells">The number of analysts recommending Sell..</param>
        /// <param name="StrongSells">The number of analysts recommending Strong Sell..</param>
        /// <param name="Total">The total number of analyst recommendations..</param>
        /// <param name="Security">The Security of the Zacks Analyst Rating.</param>
        public ZacksAnalystRating(string Id = default(string), DateTime? Date = default(DateTime?), decimal? Mean = default(decimal?), int? StrongBuys = default(int?), int? Buys = default(int?), int? Holds = default(int?), int? Sells = default(int?), int? StrongSells = default(int?), int? Total = default(int?), SecuritySummary Security = default(SecuritySummary))
        {
            this.Id = Id;
            this.Date = Date;
            this.Mean = Mean;
            this.StrongBuys = StrongBuys;
            this.Buys = Buys;
            this.Holds = Holds;
            this.Sells = Sells;
            this.StrongSells = StrongSells;
            this.Total = Total;
            this.Security = Security;
        }
        
        /// <summary>
        /// The Intrinio ID for the record
        /// </summary>
        /// <value>The Intrinio ID for the record</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date of the Zacks Analyst Rating.
        /// </summary>
        /// <value>The date of the Zacks Analyst Rating.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).
        /// </summary>
        /// <value>The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The number of analysts recommending Strong Buy.
        /// </summary>
        /// <value>The number of analysts recommending Strong Buy.</value>
        [DataMember(Name="strong_buys", EmitDefaultValue=false)]
        public int? StrongBuys { get; set; }

        /// <summary>
        /// The number of analysts recommending Buy.
        /// </summary>
        /// <value>The number of analysts recommending Buy.</value>
        [DataMember(Name="buys", EmitDefaultValue=false)]
        public int? Buys { get; set; }

        /// <summary>
        /// The number of analysts recommending Hold.
        /// </summary>
        /// <value>The number of analysts recommending Hold.</value>
        [DataMember(Name="holds", EmitDefaultValue=false)]
        public int? Holds { get; set; }

        /// <summary>
        /// The number of analysts recommending Sell.
        /// </summary>
        /// <value>The number of analysts recommending Sell.</value>
        [DataMember(Name="sells", EmitDefaultValue=false)]
        public int? Sells { get; set; }

        /// <summary>
        /// The number of analysts recommending Strong Sell.
        /// </summary>
        /// <value>The number of analysts recommending Strong Sell.</value>
        [DataMember(Name="strong_sells", EmitDefaultValue=false)]
        public int? StrongSells { get; set; }

        /// <summary>
        /// The total number of analyst recommendations.
        /// </summary>
        /// <value>The total number of analyst recommendations.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// The Security of the Zacks Analyst Rating
        /// </summary>
        /// <value>The Security of the Zacks Analyst Rating</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksAnalystRating {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  StrongBuys: ").Append(StrongBuys).Append("\n");
            sb.Append("  Buys: ").Append(Buys).Append("\n");
            sb.Append("  Holds: ").Append(Holds).Append("\n");
            sb.Append("  Sells: ").Append(Sells).Append("\n");
            sb.Append("  StrongSells: ").Append(StrongSells).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return Equals(input as ZacksAnalystRating);
        }

        /// <summary>
        /// Returns true if ZacksAnalystRating instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksAnalystRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksAnalystRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Date == input.Date ||
                    (Date != null &&
                    Date.Equals(input.Date))
                ) && 
                (
                    Mean == input.Mean ||
                    (Mean != null &&
                    Mean.Equals(input.Mean))
                ) && 
                (
                    StrongBuys == input.StrongBuys ||
                    (StrongBuys != null &&
                    StrongBuys.Equals(input.StrongBuys))
                ) && 
                (
                    Buys == input.Buys ||
                    (Buys != null &&
                    Buys.Equals(input.Buys))
                ) && 
                (
                    Holds == input.Holds ||
                    (Holds != null &&
                    Holds.Equals(input.Holds))
                ) && 
                (
                    Sells == input.Sells ||
                    (Sells != null &&
                    Sells.Equals(input.Sells))
                ) && 
                (
                    StrongSells == input.StrongSells ||
                    (StrongSells != null &&
                    StrongSells.Equals(input.StrongSells))
                ) && 
                (
                    Total == input.Total ||
                    (Total != null &&
                    Total.Equals(input.Total))
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                if (Mean != null)
                    hashCode = hashCode * 59 + Mean.GetHashCode();
                if (StrongBuys != null)
                    hashCode = hashCode * 59 + StrongBuys.GetHashCode();
                if (Buys != null)
                    hashCode = hashCode * 59 + Buys.GetHashCode();
                if (Holds != null)
                    hashCode = hashCode * 59 + Holds.GetHashCode();
                if (Sells != null)
                    hashCode = hashCode * 59 + Sells.GetHashCode();
                if (StrongSells != null)
                    hashCode = hashCode * 59 + StrongSells.GetHashCode();
                if (Total != null)
                    hashCode = hashCode * 59 + Total.GetHashCode();
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

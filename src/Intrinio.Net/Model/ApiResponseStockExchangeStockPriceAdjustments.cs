using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model
{
    /// <summary>
    /// ApiResponseStockExchangeStockPriceAdjustments
    /// </summary>
    [DataContract]
    public sealed partial class ApiResponseStockExchangeStockPriceAdjustments : IEquatable<ApiResponseStockExchangeStockPriceAdjustments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeStockPriceAdjustments" /> class.
        /// </summary>
        /// <param name="StockPriceAdjustments">The stock price adjustments for all Securities traded on the Stock Exchange on the given date.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseStockExchangeStockPriceAdjustments(List<StockPriceAdjustment> StockPriceAdjustments = default, StockExchange StockExchange = default, string NextPage = default)
        {
            this.StockPriceAdjustments = StockPriceAdjustments;
            this.StockExchange = StockExchange;
            this.NextPage = NextPage;
        }

        /// <summary>
        /// The stock price adjustments for all Securities traded on the Stock Exchange on the given date
        /// </summary>
        /// <value>The stock price adjustments for all Securities traded on the Stock Exchange on the given date</value>
        [DataMember(Name = "stock_price_adjustments", EmitDefaultValue = false)]
        public List<StockPriceAdjustment> StockPriceAdjustments { get; set; }

        /// <summary>
        /// The Stock Exchange resolved from the given identifier
        /// </summary>
        /// <value>The Stock Exchange resolved from the given identifier</value>
        [DataMember(Name = "stock_exchange", EmitDefaultValue = false)]
        public StockExchange StockExchange { get; set; }

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
            sb.Append("class ApiResponseStockExchangeStockPriceAdjustments {\n");
            sb.Append("  StockPriceAdjustments: ").Append(StockPriceAdjustments).Append('\n');
            sb.Append("  StockExchange: ").Append(StockExchange).Append('\n');
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
            return Equals(obj as ApiResponseStockExchangeStockPriceAdjustments);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeStockPriceAdjustments instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeStockPriceAdjustments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeStockPriceAdjustments input)
        {
            if (input == null)
                return false;

            return
                (
                    StockPriceAdjustments == input.StockPriceAdjustments ||
                    StockPriceAdjustments != null &&
                    StockPriceAdjustments.SequenceEqual(input.StockPriceAdjustments)
                ) &&
                (
                    StockExchange == input.StockExchange ||
                    (StockExchange != null &&
                    StockExchange.Equals(input.StockExchange))
                ) &&
                (
                    NextPage == input.NextPage ||
                    (NextPage != null &&
                    NextPage.Equals(input.NextPage))
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
                if (StockPriceAdjustments != null)
                    hashCode = hashCode * 59 + StockPriceAdjustments.GetHashCode();
                if (StockExchange != null)
                    hashCode = hashCode * 59 + StockExchange.GetHashCode();
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
}
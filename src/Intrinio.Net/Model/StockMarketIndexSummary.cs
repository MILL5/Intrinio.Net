

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
    /// StockMarketIndexSummary
    /// </summary>
    [DataContract]
    public partial class StockMarketIndexSummary :  IEquatable<StockMarketIndexSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockMarketIndexSummary" /> class.
        /// </summary>
        /// <param name="Id">Intrinio ID for the Index.</param>
        /// <param name="Symbol">The symbol used to identify the Index.</param>
        /// <param name="Name">The name of the Index.</param>
        /// <param name="Continent">The continent of the country of focus for the Index.</param>
        /// <param name="Country">The country of focus for the Index.</param>
        /// <param name="UpdateFrequency">How often the Index is updated.</param>
        /// <param name="LastUpdated">When the Index was updated last.</param>
        /// <param name="ObservationStart">The earliest date for which data is available.</param>
        /// <param name="ObservationEnd">The latest date for which data is available.</param>
        public StockMarketIndexSummary(string Id = default(string), string Symbol = default(string), string Name = default(string), string Continent = default(string), string Country = default(string), string UpdateFrequency = default(string), DateTime? LastUpdated = default(DateTime?), DateTime? ObservationStart = default(DateTime?), DateTime? ObservationEnd = default(DateTime?))
        {
            this.Id = Id;
            this.Symbol = Symbol;
            this.Name = Name;
            this.Continent = Continent;
            this.Country = Country;
            this.UpdateFrequency = UpdateFrequency;
            this.LastUpdated = LastUpdated;
            this.ObservationStart = ObservationStart;
            this.ObservationEnd = ObservationEnd;
        }
        
        /// <summary>
        /// Intrinio ID for the Index
        /// </summary>
        /// <value>Intrinio ID for the Index</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The symbol used to identify the Index
        /// </summary>
        /// <value>The symbol used to identify the Index</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The name of the Index
        /// </summary>
        /// <value>The name of the Index</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The continent of the country of focus for the Index
        /// </summary>
        /// <value>The continent of the country of focus for the Index</value>
        [DataMember(Name="continent", EmitDefaultValue=false)]
        public string Continent { get; set; }

        /// <summary>
        /// The country of focus for the Index
        /// </summary>
        /// <value>The country of focus for the Index</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// How often the Index is updated
        /// </summary>
        /// <value>How often the Index is updated</value>
        [DataMember(Name="update_frequency", EmitDefaultValue=false)]
        public string UpdateFrequency { get; set; }

        /// <summary>
        /// When the Index was updated last
        /// </summary>
        /// <value>When the Index was updated last</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The earliest date for which data is available
        /// </summary>
        /// <value>The earliest date for which data is available</value>
        [DataMember(Name="observation_start", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ObservationStart { get; set; }

        /// <summary>
        /// The latest date for which data is available
        /// </summary>
        /// <value>The latest date for which data is available</value>
        [DataMember(Name="observation_end", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ObservationEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockMarketIndexSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  UpdateFrequency: ").Append(UpdateFrequency).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  ObservationStart: ").Append(ObservationStart).Append("\n");
            sb.Append("  ObservationEnd: ").Append(ObservationEnd).Append("\n");
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
            return Equals(input as StockMarketIndexSummary);
        }

        /// <summary>
        /// Returns true if StockMarketIndexSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of StockMarketIndexSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockMarketIndexSummary input)
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
                    Symbol == input.Symbol ||
                    (Symbol != null &&
                    Symbol.Equals(input.Symbol))
                ) && 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    Continent == input.Continent ||
                    (Continent != null &&
                    Continent.Equals(input.Continent))
                ) && 
                (
                    Country == input.Country ||
                    (Country != null &&
                    Country.Equals(input.Country))
                ) && 
                (
                    UpdateFrequency == input.UpdateFrequency ||
                    (UpdateFrequency != null &&
                    UpdateFrequency.Equals(input.UpdateFrequency))
                ) && 
                (
                    LastUpdated == input.LastUpdated ||
                    (LastUpdated != null &&
                    LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    ObservationStart == input.ObservationStart ||
                    (ObservationStart != null &&
                    ObservationStart.Equals(input.ObservationStart))
                ) && 
                (
                    ObservationEnd == input.ObservationEnd ||
                    (ObservationEnd != null &&
                    ObservationEnd.Equals(input.ObservationEnd))
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
                if (Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Continent != null)
                    hashCode = hashCode * 59 + Continent.GetHashCode();
                if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                if (UpdateFrequency != null)
                    hashCode = hashCode * 59 + UpdateFrequency.GetHashCode();
                if (LastUpdated != null)
                    hashCode = hashCode * 59 + LastUpdated.GetHashCode();
                if (ObservationStart != null)
                    hashCode = hashCode * 59 + ObservationStart.GetHashCode();
                if (ObservationEnd != null)
                    hashCode = hashCode * 59 + ObservationEnd.GetHashCode();
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

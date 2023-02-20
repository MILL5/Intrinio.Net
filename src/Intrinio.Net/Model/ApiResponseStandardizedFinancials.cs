using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Intrinio.Net.Model;

/// <summary>
/// ApiResponseStandardizedFinancials
/// </summary>
[DataContract]
public partial class ApiResponseStandardizedFinancials
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResponseStandardizedFinancials" /> class.
    /// </summary>
    /// <param name="StandardizedFinancials">StandardizedFinancials.</param>
    /// <param name="Fundamental">Fundamental.</param>
    /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
    public ApiResponseStandardizedFinancials(List<StandardizedFinancial> StandardizedFinancials = default(List<StandardizedFinancial>), Fundamental Fundamental = default(Fundamental), string NextPage = default(string))
    {
        this.StandardizedFinancials = StandardizedFinancials;
        this.Fundamental = Fundamental;
        this.NextPage = NextPage;
    }

    /// <summary>
    /// Gets or Sets StandardizedFinancials
    /// </summary>
    [DataMember(Name = "standardized_financials", EmitDefaultValue = false)]
    public List<StandardizedFinancial> StandardizedFinancials { get; set; }

    /// <summary>
    /// Gets or Sets Fundamental
    /// </summary>
    [DataMember(Name = "fundamental", EmitDefaultValue = false)]
    public Fundamental Fundamental { get; set; }

    /// <summary>
    /// The token required to request the next page of the data. If null, no further results are available.
    /// </summary>
    /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
    [DataMember(Name = "next_page", EmitDefaultValue = false)]
    public string NextPage { get; set; }
}

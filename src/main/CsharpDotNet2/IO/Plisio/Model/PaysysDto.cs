using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaysysDto {
    /// <summary>
    /// Cryptocurrency name
    /// </summary>
    /// <value>Cryptocurrency name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Cryptocurrency Plisio Abbr
    /// </summary>
    /// <value>Cryptocurrency Plisio Abbr</value>
    [DataMember(Name="cid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cid")]
    public string Cid { get; set; }

    /// <summary>
    /// Cryptocurrency Abbr
    /// </summary>
    /// <value>Cryptocurrency Abbr</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Cryptocurrency icon
    /// </summary>
    /// <value>Cryptocurrency icon</value>
    [DataMember(Name="icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Cryptocurrency USD rate
    /// </summary>
    /// <value>Cryptocurrency USD rate</value>
    [DataMember(Name="rate_usd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate_usd")]
    public string RateUsd { get; set; }

    /// <summary>
    /// Cryptocurrency USD price
    /// </summary>
    /// <value>Cryptocurrency USD price</value>
    [DataMember(Name="price_usd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price_usd")]
    public string PriceUsd { get; set; }

    /// <summary>
    /// Cryptocurrency precision
    /// </summary>
    /// <value>Cryptocurrency precision</value>
    [DataMember(Name="precision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "precision")]
    public string Precision { get; set; }

    /// <summary>
    /// Cryptocurrency output precision
    /// </summary>
    /// <value>Cryptocurrency output precision</value>
    [DataMember(Name="output_precision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output_precision")]
    public string OutputPrecision { get; set; }

    /// <summary>
    /// Fiat abbr
    /// </summary>
    /// <value>Fiat abbr</value>
    [DataMember(Name="fiat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fiat")]
    public Object Fiat { get; set; }

    /// <summary>
    /// Cryptocurrency fiat rate (default USD)
    /// </summary>
    /// <value>Cryptocurrency fiat rate (default USD)</value>
    [DataMember(Name="fiat_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fiat_rate")]
    public Object FiatRate { get; set; }

    /// <summary>
    /// Invoice amount minimum
    /// </summary>
    /// <value>Invoice amount minimum</value>
    [DataMember(Name="min_sum_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_sum_in")]
    public Object MinSumIn { get; set; }

    /// <summary>
    /// Plisio commission percentage
    /// </summary>
    /// <value>Plisio commission percentage</value>
    [DataMember(Name="invoice_commission_percentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_commission_percentage")]
    public string InvoiceCommissionPercentage { get; set; }

    /// <summary>
    /// Is cryptocurrency enabled (1 - disable, 0 - enabled)
    /// </summary>
    /// <value>Is cryptocurrency enabled (1 - disable, 0 - enabled)</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public int? Hidden { get; set; }

    /// <summary>
    /// Cryptocurrency node temporary on maintenance
    /// </summary>
    /// <value>Cryptocurrency node temporary on maintenance</value>
    [DataMember(Name="maintenance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenance")]
    public bool? Maintenance { get; set; }

    /// <summary>
    /// Pay fee from another crypto
    /// </summary>
    /// <value>Pay fee from another crypto</value>
    [DataMember(Name="contractOf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractOf")]
    public Object ContractOf { get; set; }

    /// <summary>
    /// Standard of contract
    /// </summary>
    /// <value>Standard of contract</value>
    [DataMember(Name="contractStandard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractStandard")]
    public Object ContractStandard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaysysDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Cid: ").Append(Cid).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  RateUsd: ").Append(RateUsd).Append("\n");
      sb.Append("  PriceUsd: ").Append(PriceUsd).Append("\n");
      sb.Append("  Precision: ").Append(Precision).Append("\n");
      sb.Append("  OutputPrecision: ").Append(OutputPrecision).Append("\n");
      sb.Append("  Fiat: ").Append(Fiat).Append("\n");
      sb.Append("  FiatRate: ").Append(FiatRate).Append("\n");
      sb.Append("  MinSumIn: ").Append(MinSumIn).Append("\n");
      sb.Append("  InvoiceCommissionPercentage: ").Append(InvoiceCommissionPercentage).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Maintenance: ").Append(Maintenance).Append("\n");
      sb.Append("  ContractOf: ").Append(ContractOf).Append("\n");
      sb.Append("  ContractStandard: ").Append(ContractStandard).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

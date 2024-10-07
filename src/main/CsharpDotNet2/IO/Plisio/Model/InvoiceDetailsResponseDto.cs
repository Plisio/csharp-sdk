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
  public class InvoiceDetailsResponseDto {
    /// <summary>
    /// Gets or Sets Invoice
    /// </summary>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public InvoiceExtendedResponseDto Invoice { get; set; }

    /// <summary>
    /// Current active invoice ID. Invoice ID with the last selected cryptocurrency
    /// </summary>
    /// <value>Current active invoice ID. Invoice ID with the last selected cryptocurrency</value>
    [DataMember(Name="active_invoice_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_invoice_id")]
    public string ActiveInvoiceId { get; set; }

    /// <summary>
    /// Gets or Sets Shop
    /// </summary>
    [DataMember(Name="shop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shop")]
    public ShopInfoDto Shop { get; set; }

    /// <summary>
    /// Gets or Sets Paysys
    /// </summary>
    [DataMember(Name="paysys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paysys")]
    public InvoicePaysysDto Paysys { get; set; }

    /// <summary>
    /// Allowed cryptocurrencies for select
    /// </summary>
    /// <value>Allowed cryptocurrencies for select</value>
    [DataMember(Name="allowed_psys_cids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_psys_cids")]
    public List<InvoicePaysysDto> AllowedPsysCids { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceDetailsResponseDto {\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  ActiveInvoiceId: ").Append(ActiveInvoiceId).Append("\n");
      sb.Append("  Shop: ").Append(Shop).Append("\n");
      sb.Append("  Paysys: ").Append(Paysys).Append("\n");
      sb.Append("  AllowedPsysCids: ").Append(AllowedPsysCids).Append("\n");
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

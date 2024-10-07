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
  public class InvoiceSimpleResponseDto {
    /// <summary>
    /// Plisio’s intertnal ID
    /// </summary>
    /// <value>Plisio’s intertnal ID</value>
    [DataMember(Name="txn_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "txn_id")]
    public string TxnId { get; set; }

    /// <summary>
    /// Invoice URL
    /// </summary>
    /// <value>Invoice URL</value>
    [DataMember(Name="invoice_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_url")]
    public string InvoiceUrl { get; set; }

    /// <summary>
    /// shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum
    /// </summary>
    /// <value>shop pays commission: invoice amount client pays commission: invoice_commission + invoice_sum</value>
    [DataMember(Name="invoice_total_sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice_total_sum")]
    public string InvoiceTotalSum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceSimpleResponseDto {\n");
      sb.Append("  TxnId: ").Append(TxnId).Append("\n");
      sb.Append("  InvoiceUrl: ").Append(InvoiceUrl).Append("\n");
      sb.Append("  InvoiceTotalSum: ").Append(InvoiceTotalSum).Append("\n");
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

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sales Credit Memo Line.
    /// </summary>
    public partial class SalesCreditMemoLine : Entity
    {
    
        /// <summary>
        /// Gets or sets account id.
        /// </summary>
        [JsonPropertyName("accountId")]
        public Guid? AccountId { get; set; }
    
        /// <summary>
        /// Gets or sets amount excluding tax.
        /// </summary>
        [JsonPropertyName("amountExcludingTax")]
        public Decimal? AmountExcludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets amount including tax.
        /// </summary>
        [JsonPropertyName("amountIncludingTax")]
        public Decimal? AmountIncludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        [JsonPropertyName("discountAmount")]
        public Decimal? DiscountAmount { get; set; }
    
        /// <summary>
        /// Gets or sets discount applied before tax.
        /// </summary>
        [JsonPropertyName("discountAppliedBeforeTax")]
        public bool? DiscountAppliedBeforeTax { get; set; }
    
        /// <summary>
        /// Gets or sets discount percent.
        /// </summary>
        [JsonPropertyName("discountPercent")]
        public Decimal? DiscountPercent { get; set; }
    
        /// <summary>
        /// Gets or sets document id.
        /// </summary>
        [JsonPropertyName("documentId")]
        public Guid? DocumentId { get; set; }
    
        /// <summary>
        /// Gets or sets invoice discount allocation.
        /// </summary>
        [JsonPropertyName("invoiceDiscountAllocation")]
        public Decimal? InvoiceDiscountAllocation { get; set; }
    
        /// <summary>
        /// Gets or sets item id.
        /// </summary>
        [JsonPropertyName("itemId")]
        public Guid? ItemId { get; set; }
    
        /// <summary>
        /// Gets or sets line type.
        /// </summary>
        [JsonPropertyName("lineType")]
        public string LineType { get; set; }
    
        /// <summary>
        /// Gets or sets net amount.
        /// </summary>
        [JsonPropertyName("netAmount")]
        public Decimal? NetAmount { get; set; }
    
        /// <summary>
        /// Gets or sets net amount including tax.
        /// </summary>
        [JsonPropertyName("netAmountIncludingTax")]
        public Decimal? NetAmountIncludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets net tax amount.
        /// </summary>
        [JsonPropertyName("netTaxAmount")]
        public Decimal? NetTaxAmount { get; set; }
    
        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        [JsonPropertyName("quantity")]
        public Decimal? Quantity { get; set; }
    
        /// <summary>
        /// Gets or sets sequence.
        /// </summary>
        [JsonPropertyName("sequence")]
        public Int32? Sequence { get; set; }
    
        /// <summary>
        /// Gets or sets shipment date.
        /// </summary>
        [JsonPropertyName("shipmentDate")]
        public Date ShipmentDate { get; set; }
    
        /// <summary>
        /// Gets or sets tax code.
        /// </summary>
        [JsonPropertyName("taxCode")]
        public string TaxCode { get; set; }
    
        /// <summary>
        /// Gets or sets tax percent.
        /// </summary>
        [JsonPropertyName("taxPercent")]
        public Decimal? TaxPercent { get; set; }
    
        /// <summary>
        /// Gets or sets total tax amount.
        /// </summary>
        [JsonPropertyName("totalTaxAmount")]
        public Decimal? TotalTaxAmount { get; set; }
    
        /// <summary>
        /// Gets or sets unit of measure id.
        /// </summary>
        [JsonPropertyName("unitOfMeasureId")]
        public Guid? UnitOfMeasureId { get; set; }
    
        /// <summary>
        /// Gets or sets unit price.
        /// </summary>
        [JsonPropertyName("unitPrice")]
        public Decimal? UnitPrice { get; set; }
    
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonPropertyName("account")]
        public Account Account { get; set; }
    
        /// <summary>
        /// Gets or sets item.
        /// </summary>
        [JsonPropertyName("item")]
        public Item Item { get; set; }
    
    }
}


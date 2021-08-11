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
    /// The type Item.
    /// </summary>
    public partial class Item : Entity
    {
    
        /// <summary>
        /// Gets or sets base unit of measure id.
        /// </summary>
        [JsonPropertyName("baseUnitOfMeasureId")]
        public Guid? BaseUnitOfMeasureId { get; set; }
    
        /// <summary>
        /// Gets or sets blocked.
        /// </summary>
        [JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets gtin.
        /// </summary>
        [JsonPropertyName("gtin")]
        public string Gtin { get; set; }
    
        /// <summary>
        /// Gets or sets inventory.
        /// </summary>
        [JsonPropertyName("inventory")]
        public Decimal? Inventory { get; set; }
    
        /// <summary>
        /// Gets or sets item category code.
        /// </summary>
        [JsonPropertyName("itemCategoryCode")]
        public string ItemCategoryCode { get; set; }
    
        /// <summary>
        /// Gets or sets item category id.
        /// </summary>
        [JsonPropertyName("itemCategoryId")]
        public Guid? ItemCategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets price includes tax.
        /// </summary>
        [JsonPropertyName("priceIncludesTax")]
        public bool? PriceIncludesTax { get; set; }
    
        /// <summary>
        /// Gets or sets tax group code.
        /// </summary>
        [JsonPropertyName("taxGroupCode")]
        public string TaxGroupCode { get; set; }
    
        /// <summary>
        /// Gets or sets tax group id.
        /// </summary>
        [JsonPropertyName("taxGroupId")]
        public Guid? TaxGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets unit cost.
        /// </summary>
        [JsonPropertyName("unitCost")]
        public Decimal? UnitCost { get; set; }
    
        /// <summary>
        /// Gets or sets unit price.
        /// </summary>
        [JsonPropertyName("unitPrice")]
        public Decimal? UnitPrice { get; set; }
    
        /// <summary>
        /// Gets or sets item category.
        /// </summary>
        [JsonPropertyName("itemCategory")]
        public ItemCategory ItemCategory { get; set; }
    
        /// <summary>
        /// Gets or sets picture.
        /// </summary>
        [JsonPropertyName("picture")]
        public IItemPictureCollectionPage Picture { get; set; }

        /// <summary>
        /// Gets or sets pictureNextLink.
        /// </summary>
        [JsonPropertyName("picture@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PictureNextLink { get; set; }
    
    }
}


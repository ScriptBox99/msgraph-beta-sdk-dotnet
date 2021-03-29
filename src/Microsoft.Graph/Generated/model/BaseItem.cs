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
    /// The type Base Item.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BaseItem>))]
    public partial class BaseItem : Entity
    {
    
		///<summary>
		/// The internal BaseItem constructor
		///</summary>
        protected internal BaseItem()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created by.
        /// Identity of the user, device, or application which created the item. Read-only.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of item creation. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Provides a user-visible description of the item. Optional.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets e tag.
        /// ETag for the item. Read-only.
        /// </summary>
        [JsonPropertyName("eTag")]
        public string ETag { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user, device, and application which last modified the item. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time the item was last modified. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the item. Read-write.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parent reference.
        /// Parent information, if the item has a parent. Read-write.
        /// </summary>
        [JsonPropertyName("parentReference")]
        public ItemReference ParentReference { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// URL that displays the resource in the browser. Read-only.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets created by user.
        /// Identity of the user who created the item. Read-only.
        /// </summary>
        [JsonPropertyName("createdByUser")]
        public User CreatedByUser { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by user.
        /// Identity of the user who last modified the item. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedByUser")]
        public User LastModifiedByUser { get; set; }
    
    }
}


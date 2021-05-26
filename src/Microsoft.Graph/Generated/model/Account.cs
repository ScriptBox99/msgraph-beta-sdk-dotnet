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
    /// The type Account.
    /// </summary>
    public partial class Account : Entity
    {
    
        /// <summary>
        /// Gets or sets blocked.
        /// </summary>
        [JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
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
        /// Gets or sets sub category.
        /// </summary>
        [JsonPropertyName("subCategory")]
        public string SubCategory { get; set; }
    
    }
}


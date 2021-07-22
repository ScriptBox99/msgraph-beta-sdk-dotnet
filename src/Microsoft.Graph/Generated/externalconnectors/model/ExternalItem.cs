// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type External Item.
    /// </summary>
    public partial class ExternalItem : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets acl.
        /// An array of access control entries. Each entry specifies the access granted to a user or group. Required.
        /// </summary>
        [JsonPropertyName("acl")]
        public IEnumerable<Acl> Acl { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// A plain-text  representation of the contents of the item. The text in this property is full-text indexed. Optional.
        /// </summary>
        [JsonPropertyName("content")]
        public ExternalItemContent Content { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// A property bag with the properties of the item. The properties MUST conform to the schema defined for the externalConnection. Required.
        /// </summary>
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    
    }
}


// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AuditResource.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuditResource>))]
    public partial class AuditResource
    {

        /// <summary>
        /// Gets or sets displayName.
        /// Display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets modifiedProperties.
        /// List of modified properties.
        /// </summary>
        [JsonPropertyName("modifiedProperties")]
        public IEnumerable<AuditProperty> ModifiedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets resourceId.
        /// Audit resource's Id.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Audit resource's type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}

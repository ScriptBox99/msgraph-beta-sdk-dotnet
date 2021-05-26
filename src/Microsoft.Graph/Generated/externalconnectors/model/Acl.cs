// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Acl.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Acl>))]
    public partial class Acl
    {

        /// <summary>
        /// Gets or sets accessType.
        /// </summary>
        [JsonPropertyName("accessType")]
        public AccessType? AccessType { get; set; }
    
        /// <summary>
        /// Gets or sets identitySource.
        /// </summary>
        [JsonPropertyName("identitySource")]
        public IdentitySourceType? IdentitySource { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public AclType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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

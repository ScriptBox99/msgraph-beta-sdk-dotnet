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
    /// The type External Group Member.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ExternalGroupMember>))]
    public partial class ExternalGroupMember : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets identity source.
        /// The identity source that the member belongs to. Possible values are: azureActiveDirectory, external.
        /// </summary>
        [Obsolete("The property named 'IdentitySource' will be deprecated in September 2021, please see the updated aclType usage.")]
        [JsonPropertyName("identitySource")]
        public IdentitySourceType? IdentitySource { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of member added to the external group. Possible values are: user or group when the identitySource is azureActiveDirectory and just group when the identitySource is external.
        /// </summary>
        [JsonPropertyName("type")]
        public ExternalGroupMemberType? Type { get; set; }
    
    }
}


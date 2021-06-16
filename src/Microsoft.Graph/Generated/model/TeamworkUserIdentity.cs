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
    /// The type TeamworkUserIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkUserIdentity>))]
    public partial class TeamworkUserIdentity : Identity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamworkUserIdentity"/> class.
        /// </summary>
        public TeamworkUserIdentity()
        {
            this.ODataType = "microsoft.graph.teamworkUserIdentity";
        }

        /// <summary>
        /// Gets or sets userIdentityType.
        /// </summary>
        [JsonPropertyName("userIdentityType")]
        public TeamworkUserIdentityType? UserIdentityType { get; set; }
    
    }
}

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
    /// The type TeamDiscoverySettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamDiscoverySettings>))]
    public partial class TeamDiscoverySettings
    {

        /// <summary>
        /// Gets or sets showInTeamsSearchAndSuggestions.
        /// If set to true, the team is visible via search and suggestions from the Teams client.
        /// </summary>
        [JsonPropertyName("showInTeamsSearchAndSuggestions")]
        public bool? ShowInTeamsSearchAndSuggestions { get; set; }
    
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

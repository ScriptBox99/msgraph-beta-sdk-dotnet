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
    /// The type App Catalogs.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppCatalogs>))]
    public partial class AppCatalogs
    {
    
        /// <summary>
        /// Gets or sets teams apps.
        /// </summary>
        [JsonPropertyName("teamsApps")]
        public IAppCatalogsTeamsAppsCollectionPage TeamsApps { get; set; }

        /// <summary>
        /// Gets or sets teamsAppsNextLink.
        /// </summary>
        [JsonPropertyName("teamsApps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TeamsAppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}


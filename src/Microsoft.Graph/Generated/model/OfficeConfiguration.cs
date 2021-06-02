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
    /// The type Office Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfficeConfiguration>))]
    public partial class OfficeConfiguration
    {
    
        /// <summary>
        /// Gets or sets tenant checkin statuses.
        /// List of office Client check-in status.
        /// </summary>
        [JsonPropertyName("tenantCheckinStatuses")]
        public IEnumerable<OfficeClientCheckinStatus> TenantCheckinStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets tenant user checkin summary.
        /// Entity that describes tenant check-in statues
        /// </summary>
        [JsonPropertyName("tenantUserCheckinSummary")]
        public OfficeUserCheckinSummary TenantUserCheckinSummary { get; set; }
    
        /// <summary>
        /// Gets or sets client configurations.
        /// List of office Client configuration.
        /// </summary>
        [JsonPropertyName("clientConfigurations")]
        public IOfficeConfigurationClientConfigurationsCollectionPage ClientConfigurations { get; set; }

        /// <summary>
        /// Gets or sets clientConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("clientConfigurations@odata.nextLink")]
        public string ClientConfigurationsNextLink { get; set; }
    
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


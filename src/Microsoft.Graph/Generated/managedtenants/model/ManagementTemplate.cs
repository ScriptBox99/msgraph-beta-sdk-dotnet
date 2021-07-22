// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Management Template.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementTemplate>))]
    public partial class ManagementTemplate : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets category.
        /// The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.
        /// </summary>
        [JsonPropertyName("category")]
        public ManagementCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description for the management template. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the management template. Required. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets parameters.
        /// The collection of parameters used by the management template. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("parameters")]
        public IEnumerable<TemplateParameter> Parameters { get; set; }
    
        /// <summary>
        /// Gets or sets workload actions.
        /// The collection of workload actions associated with the management template. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("workloadActions")]
        public IEnumerable<WorkloadAction> WorkloadActions { get; set; }
    
    }
}


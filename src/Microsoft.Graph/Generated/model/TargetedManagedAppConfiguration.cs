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
    /// The type Targeted Managed App Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TargetedManagedAppConfiguration>))]
    public partial class TargetedManagedAppConfiguration : ManagedAppConfiguration
    {
    
        ///<summary>
        /// The TargetedManagedAppConfiguration constructor
        ///</summary>
        public TargetedManagedAppConfiguration()
        {
            this.ODataType = "microsoft.graph.targetedManagedAppConfiguration";
        }

        /// <summary>
        /// Gets or sets app group type.
        /// Public Apps selection: group or individual
        /// </summary>
        [JsonPropertyName("appGroupType")]
        public TargetedManagedAppGroupType? AppGroupType { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonPropertyName("deployedAppCount")]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets is assigned.
        /// Indicates if the policy is deployed to any inclusion groups or not.
        /// </summary>
        [JsonPropertyName("isAssigned")]
        public bool? IsAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonPropertyName("apps")]
        public ITargetedManagedAppConfigurationAppsCollectionPage Apps { get; set; }

        /// <summary>
        /// Gets or sets appsNextLink.
        /// </summary>
        [JsonPropertyName("apps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// </summary>
        [JsonPropertyName("assignments")]
        public ITargetedManagedAppConfigurationAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonPropertyName("deploymentSummary")]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}


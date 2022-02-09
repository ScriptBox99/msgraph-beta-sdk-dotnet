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
    /// The type Device Compliance Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceCompliancePolicy>))]
    public partial class DeviceCompliancePolicy : Entity
    {
    
        ///<summary>
        /// The internal DeviceCompliancePolicy constructor
        ///</summary>
        protected internal DeviceCompliancePolicy()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Admin provided description of the Device Configuration.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided name of the device configuration.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device configuration.
        /// </summary>
        [JsonPropertyName("version")]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The collection of assignments for this compliance policy.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IDeviceCompliancePolicyAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device setting state summaries.
        /// Compliance Setting State Device Summary
        /// </summary>
        [JsonPropertyName("deviceSettingStateSummaries")]
        public IDeviceCompliancePolicyDeviceSettingStateSummariesCollectionPage DeviceSettingStateSummaries { get; set; }

        /// <summary>
        /// Gets or sets deviceSettingStateSummariesNextLink.
        /// </summary>
        [JsonPropertyName("deviceSettingStateSummaries@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceSettingStateSummariesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// List of DeviceComplianceDeviceStatus.
        /// </summary>
        [JsonPropertyName("deviceStatuses")]
        public IDeviceCompliancePolicyDeviceStatusesCollectionPage DeviceStatuses { get; set; }

        /// <summary>
        /// Gets or sets deviceStatusesNextLink.
        /// </summary>
        [JsonPropertyName("deviceStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device status overview.
        /// Device compliance devices status overview
        /// </summary>
        [JsonPropertyName("deviceStatusOverview")]
        public DeviceComplianceDeviceOverview DeviceStatusOverview { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled actions for rule.
        /// The list of scheduled action per rule for this compliance policy. This is a required property when creating any individual per-platform compliance policies.
        /// </summary>
        [JsonPropertyName("scheduledActionsForRule")]
        public IDeviceCompliancePolicyScheduledActionsForRuleCollectionPage ScheduledActionsForRule { get; set; }

        /// <summary>
        /// Gets or sets scheduledActionsForRuleNextLink.
        /// </summary>
        [JsonPropertyName("scheduledActionsForRule@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ScheduledActionsForRuleNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user statuses.
        /// List of DeviceComplianceUserStatus.
        /// </summary>
        [JsonPropertyName("userStatuses")]
        public IDeviceCompliancePolicyUserStatusesCollectionPage UserStatuses { get; set; }

        /// <summary>
        /// Gets or sets userStatusesNextLink.
        /// </summary>
        [JsonPropertyName("userStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user status overview.
        /// Device compliance users status overview
        /// </summary>
        [JsonPropertyName("userStatusOverview")]
        public DeviceComplianceUserOverview UserStatusOverview { get; set; }
    
    }
}


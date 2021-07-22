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
    /// The type Managed Device Compliance Trend.
    /// </summary>
    public partial class ManagedDeviceComplianceTrend : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets compliant device count.
        /// The number of devices with a compliant status. Required. Read-only.
        /// </summary>
        [JsonPropertyName("compliantDeviceCount")]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets config manager device count.
        /// The number of devices manged by Configuration Manager. Required. Read-only.
        /// </summary>
        [JsonPropertyName("configManagerDeviceCount")]
        public Int32? ConfigManagerDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets count date time.
        /// The date and time compliance snapshot was performed. Required. Read-only.
        /// </summary>
        [JsonPropertyName("countDateTime")]
        public string CountDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// The number of devices with an error status. Required. Read-only.
        /// </summary>
        [JsonPropertyName("errorDeviceCount")]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets in grace period device count.
        /// The number of devices that are in a grace period status. Required. Read-only.
        /// </summary>
        [JsonPropertyName("inGracePeriodDeviceCount")]
        public Int32? InGracePeriodDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets noncompliant device count.
        /// The number of devices that are in a non-compliant status. Required. Read-only.
        /// </summary>
        [JsonPropertyName("noncompliantDeviceCount")]
        public Int32? NoncompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets tenant display name.
        /// The display name for the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("tenantDisplayName")]
        public string TenantDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// The number of devices in an unknown status. Required. Read-only.
        /// </summary>
        [JsonPropertyName("unknownDeviceCount")]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}


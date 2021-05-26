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
    /// The type User Experience Analytics Work From Anywhere Device.
    /// </summary>
    public partial class UserExperienceAnalyticsWorkFromAnywhereDevice : Entity
    {
    
        /// <summary>
        /// Gets or sets auto pilot profile assigned.
        /// The user experience analytics work from anywhere intune device's autopilotProfileAssigned.
        /// </summary>
        [JsonPropertyName("autoPilotProfileAssigned")]
        public bool? AutoPilotProfileAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets auto pilot registered.
        /// The user experience work from anywhere intune device's autopilotRegistered.
        /// </summary>
        [JsonPropertyName("autoPilotRegistered")]
        public bool? AutoPilotRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad device id.
        /// The user experience work from anywhere azure Ad device Id.
        /// </summary>
        [JsonPropertyName("azureAdDeviceId")]
        public string AzureAdDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad join type.
        /// The user experience work from anywhere device's azure Ad joinType.
        /// </summary>
        [JsonPropertyName("azureAdJoinType")]
        public string AzureAdJoinType { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad registered.
        /// The user experience work from anywhere device's azureAdRegistered.
        /// </summary>
        [JsonPropertyName("azureAdRegistered")]
        public bool? AzureAdRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// The work from anywhere device's name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managed by.
        /// The user experience work from anywhere management agent of the device.
        /// </summary>
        [JsonPropertyName("managedBy")]
        public string ManagedBy { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// The user experience work from anywhere device's manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The user experience work from anywhere device's model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets ownership.
        /// The user experience work from anywhere device's ownership.
        /// </summary>
        [JsonPropertyName("ownership")]
        public string Ownership { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// The user experience work from anywhere device's serial number.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
    }
}


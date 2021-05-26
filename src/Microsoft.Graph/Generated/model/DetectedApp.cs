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
    /// The type Detected App.
    /// </summary>
    public partial class DetectedApp : Entity
    {
    
        /// <summary>
        /// Gets or sets device count.
        /// The number of devices that have installed this application
        /// </summary>
        [JsonPropertyName("deviceCount")]
        public Int32? DeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the discovered application. Read-only
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets size in byte.
        /// Discovered application size in bytes. Read-only
        /// </summary>
        [JsonPropertyName("sizeInByte")]
        public Int64? SizeInByte { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the discovered application. Read-only
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The devices that have the discovered application installed
        /// </summary>
        [JsonPropertyName("managedDevices")]
        public IDetectedAppManagedDevicesCollectionWithReferencesPage ManagedDevices { get; set; }

        /// <summary>
        /// Gets or sets managedDevicesNextLink.
        /// </summary>
        [JsonPropertyName("managedDevices@odata.nextLink")]
        public string ManagedDevicesNextLink { get; set; }
    
    }
}


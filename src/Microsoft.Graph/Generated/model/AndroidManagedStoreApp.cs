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
    /// The type Android Managed Store App.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidManagedStoreApp>))]
    public partial class AndroidManagedStoreApp : MobileApp
    {
    
        ///<summary>
        /// The AndroidManagedStoreApp constructor
        ///</summary>
        public AndroidManagedStoreApp()
        {
            this.ODataType = "microsoft.graph.androidManagedStoreApp";
        }
    
        /// <summary>
        /// Gets or sets app identifier.
        /// The Identity Name.
        /// </summary>
        [JsonPropertyName("appIdentifier")]
        public string AppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The Play for Work Store app URL.
        /// </summary>
        [JsonPropertyName("appStoreUrl")]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets app tracks.
        /// The tracks that are visible to this enterprise.
        /// </summary>
        [JsonPropertyName("appTracks")]
        public IEnumerable<AndroidManagedStoreAppTrack> AppTracks { get; set; }
    
        /// <summary>
        /// Gets or sets is private.
        /// Indicates whether the app is only available to a given enterprise's users.
        /// </summary>
        [JsonPropertyName("isPrivate")]
        public bool? IsPrivate { get; set; }
    
        /// <summary>
        /// Gets or sets is system app.
        /// Indicates whether the app is a preinstalled system app.
        /// </summary>
        [JsonPropertyName("isSystemApp")]
        public bool? IsSystemApp { get; set; }
    
        /// <summary>
        /// Gets or sets package id.
        /// The package identifier.
        /// </summary>
        [JsonPropertyName("packageId")]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets supports oem config.
        /// Whether this app supports OEMConfig policy.
        /// </summary>
        [JsonPropertyName("supportsOemConfig")]
        public bool? SupportsOemConfig { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// The total number of VPP licenses.
        /// </summary>
        [JsonPropertyName("totalLicenseCount")]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// The number of VPP licenses in use.
        /// </summary>
        [JsonPropertyName("usedLicenseCount")]
        public Int32? UsedLicenseCount { get; set; }
    
    }
}


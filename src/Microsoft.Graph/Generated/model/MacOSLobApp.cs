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
    /// The type Mac OSLob App.
    /// </summary>
    public partial class MacOSLobApp : MobileLobApp
    {
    
        ///<summary>
        /// The MacOSLobApp constructor
        ///</summary>
        public MacOSLobApp()
        {
            this.ODataType = "microsoft.graph.macOSLobApp";
        }

        /// <summary>
        /// Gets or sets build number.
        /// The build number of MacOS Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("buildNumber")]
        public string BuildNumber { get; set; }
    
        /// <summary>
        /// Gets or sets bundle id.
        /// The bundle id.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets child apps.
        /// The app list in this bundle package
        /// </summary>
        [JsonPropertyName("childApps")]
        public IEnumerable<MacOSLobChildApp> ChildApps { get; set; }
    
        /// <summary>
        /// Gets or sets identity version.
        /// The identity version.
        /// </summary>
        [JsonPropertyName("identityVersion")]
        public string IdentityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets ignore version detection.
        /// A boolean to control whether the app's version will be used to detect the app after it is installed on a device. Set this to true for macOS Line of Business (LoB) apps that use a self update feature.
        /// </summary>
        [JsonPropertyName("ignoreVersionDetection")]
        public bool? IgnoreVersionDetection { get; set; }
    
        /// <summary>
        /// Gets or sets install as managed.
        /// A boolean to control whether the app will be installed as managed (requires macOS 11.0 and other PKG restrictions).
        /// </summary>
        [JsonPropertyName("installAsManaged")]
        public bool? InstallAsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets md5hash.
        /// The MD5 hash codes
        /// </summary>
        [JsonPropertyName("md5Hash")]
        public IEnumerable<string> Md5Hash { get; set; }
    
        /// <summary>
        /// Gets or sets md5hash chunk size.
        /// The chunk size for MD5 hash
        /// </summary>
        [JsonPropertyName("md5HashChunkSize")]
        public Int32? Md5HashChunkSize { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonPropertyName("minimumSupportedOperatingSystem")]
        public MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets version number.
        /// The version number of MacOS Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("versionNumber")]
        public string VersionNumber { get; set; }
    
    }
}


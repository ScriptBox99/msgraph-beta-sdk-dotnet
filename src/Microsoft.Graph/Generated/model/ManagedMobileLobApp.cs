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
    /// The type Managed Mobile Lob App.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ManagedMobileLobApp>))]
    public partial class ManagedMobileLobApp : ManagedApp
    {
    
		///<summary>
		/// The internal ManagedMobileLobApp constructor
		///</summary>
        protected internal ManagedMobileLobApp()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets committed content version.
        /// The internal committed content version.
        /// </summary>
        [JsonPropertyName("committedContentVersion")]
        public string CommittedContentVersion { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// The name of the main Lob application file.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The total size, including all uploaded files.
        /// </summary>
        [JsonPropertyName("size")]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets content versions.
        /// The list of content versions for this app.
        /// </summary>
        [JsonPropertyName("contentVersions")]
        public IManagedMobileLobAppContentVersionsCollectionPage ContentVersions { get; set; }
    
    }
}


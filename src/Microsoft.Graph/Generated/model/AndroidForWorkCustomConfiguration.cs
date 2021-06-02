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
    /// The type Android For Work Custom Configuration.
    /// </summary>
    public partial class AndroidForWorkCustomConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The AndroidForWorkCustomConfiguration constructor
        ///</summary>
        public AndroidForWorkCustomConfiguration()
        {
            this.ODataType = "microsoft.graph.androidForWorkCustomConfiguration";
        }

        /// <summary>
        /// Gets or sets oma settings.
        /// OMA settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("omaSettings")]
        public IEnumerable<OmaSetting> OmaSettings { get; set; }
    
    }
}


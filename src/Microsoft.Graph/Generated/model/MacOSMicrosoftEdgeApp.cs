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
    /// The type Mac OSMicrosoft Edge App.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSMicrosoftEdgeApp>))]
    public partial class MacOSMicrosoftEdgeApp : MobileApp
    {
    
        ///<summary>
        /// The MacOSMicrosoftEdgeApp constructor
        ///</summary>
        public MacOSMicrosoftEdgeApp()
        {
            this.ODataType = "microsoft.graph.macOSMicrosoftEdgeApp";
        }
    
        /// <summary>
        /// Gets or sets channel.
        /// The channel to install on target devices. Possible values are: dev, beta, stable.
        /// </summary>
        [JsonPropertyName("channel")]
        public MicrosoftEdgeChannel? Channel { get; set; }
    
    }
}


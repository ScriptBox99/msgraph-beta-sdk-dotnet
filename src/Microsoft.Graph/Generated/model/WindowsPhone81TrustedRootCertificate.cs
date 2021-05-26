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
    /// The type Windows Phone81Trusted Root Certificate.
    /// </summary>
    public partial class WindowsPhone81TrustedRootCertificate : DeviceConfiguration
    {
    
        ///<summary>
        /// The WindowsPhone81TrustedRootCertificate constructor
        ///</summary>
        public WindowsPhone81TrustedRootCertificate()
        {
            this.ODataType = "microsoft.graph.windowsPhone81TrustedRootCertificate";
        }
    
        /// <summary>
        /// Gets or sets cert file name.
        /// File name to display in UI.
        /// </summary>
        [JsonPropertyName("certFileName")]
        public string CertFileName { get; set; }
    
        /// <summary>
        /// Gets or sets trusted root certificate.
        /// Trusted Root Certificate
        /// </summary>
        [JsonPropertyName("trustedRootCertificate")]
        public byte[] TrustedRootCertificate { get; set; }
    
    }
}


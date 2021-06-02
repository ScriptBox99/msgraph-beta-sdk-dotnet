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
    /// The type Windows10XTrusted Root Certificate.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10XTrustedRootCertificate>))]
    public partial class Windows10XTrustedRootCertificate : DeviceManagementResourceAccessProfileBase
    {
    
        ///<summary>
        /// The Windows10XTrustedRootCertificate constructor
        ///</summary>
        public Windows10XTrustedRootCertificate()
        {
            this.ODataType = "microsoft.graph.windows10XTrustedRootCertificate";
        }

        /// <summary>
        /// Gets or sets cert file name.
        /// File name to display in UI.
        /// </summary>
        [JsonPropertyName("certFileName")]
        public string CertFileName { get; set; }
    
        /// <summary>
        /// Gets or sets destination store.
        /// Destination store location for the Trusted Root Certificate. Possible values are: computerCertStoreRoot, computerCertStoreIntermediate, userCertStoreIntermediate.
        /// </summary>
        [JsonPropertyName("destinationStore")]
        public CertificateDestinationStore? DestinationStore { get; set; }
    
        /// <summary>
        /// Gets or sets trusted root certificate.
        /// Trusted Root Certificate
        /// </summary>
        [JsonPropertyName("trustedRootCertificate")]
        public byte[] TrustedRootCertificate { get; set; }
    
    }
}


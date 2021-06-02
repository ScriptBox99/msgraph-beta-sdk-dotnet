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
    /// The type Windows Phone81Imported PFXCertificate Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsPhone81ImportedPFXCertificateProfile>))]
    public partial class WindowsPhone81ImportedPFXCertificateProfile : WindowsCertificateProfileBase
    {
    
        ///<summary>
        /// The WindowsPhone81ImportedPFXCertificateProfile constructor
        ///</summary>
        public WindowsPhone81ImportedPFXCertificateProfile()
        {
            this.ODataType = "microsoft.graph.windowsPhone81ImportedPFXCertificateProfile";
        }

        /// <summary>
        /// Gets or sets intended purpose.
        /// Intended Purpose of the Certificate Profile - which could be Unassigned, SmimeEncryption, SmimeSigning etc. Possible values are: unassigned, smimeEncryption, smimeSigning, vpn, wifi.
        /// </summary>
        [JsonPropertyName("intendedPurpose")]
        public IntendedPurpose? IntendedPurpose { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates")]
        public IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCertificateStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates@odata.nextLink")]
        public string ManagedDeviceCertificateStatesNextLink { get; set; }
    
    }
}


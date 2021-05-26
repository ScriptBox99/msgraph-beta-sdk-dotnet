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
    /// The type Android For Work Vpn Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidForWorkVpnConfiguration>))]
    public partial class AndroidForWorkVpnConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The AndroidForWorkVpnConfiguration constructor
        ///</summary>
        public AndroidForWorkVpnConfiguration()
        {
            this.ODataType = "microsoft.graph.androidForWorkVpnConfiguration";
        }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method. Possible values are: certificate, usernameAndPassword, sharedSecret, derivedCredential, azureAD.
        /// </summary>
        [JsonPropertyName("authenticationMethod")]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets connection name.
        /// Connection name displayed to the user.
        /// </summary>
        [JsonPropertyName("connectionName")]
        public string ConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type. Possible values are: ciscoAnyConnect, pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn, citrix.
        /// </summary>
        [JsonPropertyName("connectionType")]
        public AndroidForWorkVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets custom data.
        /// Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonPropertyName("customData")]
        public IEnumerable<KeyValue> CustomData { get; set; }
    
        /// <summary>
        /// Gets or sets custom key value data.
        /// Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonPropertyName("customKeyValueData")]
        public IEnumerable<KeyValuePair> CustomKeyValueData { get; set; }
    
        /// <summary>
        /// Gets or sets fingerprint.
        /// Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Realm when connection type is set to Pulse Secure.
        /// </summary>
        [JsonPropertyName("realm")]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role when connection type is set to Pulse Secure.
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets servers.
        /// List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("servers")]
        public IEnumerable<VpnServer> Servers { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonPropertyName("identityCertificate")]
        public AndroidForWorkCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}


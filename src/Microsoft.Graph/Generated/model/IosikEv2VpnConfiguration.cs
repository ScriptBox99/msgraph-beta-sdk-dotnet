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
    /// The type Iosik Ev2Vpn Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosikEv2VpnConfiguration>))]
    public partial class IosikEv2VpnConfiguration : IosVpnConfiguration
    {
    
        ///<summary>
        /// The IosikEv2VpnConfiguration constructor
        ///</summary>
        public IosikEv2VpnConfiguration()
        {
            this.ODataType = "microsoft.graph.iosikEv2VpnConfiguration";
        }

        /// <summary>
        /// Gets or sets allow default child security association parameters.
        /// Allows the use of child security association parameters by setting all parameters to the device's default unless explicitly specified.
        /// </summary>
        [JsonPropertyName("allowDefaultChildSecurityAssociationParameters")]
        public bool? AllowDefaultChildSecurityAssociationParameters { get; set; }
    
        /// <summary>
        /// Gets or sets allow default security association parameters.
        /// Allows the use of security association parameters by setting all parameters to the device's default unless explicitly specified.
        /// </summary>
        [JsonPropertyName("allowDefaultSecurityAssociationParameters")]
        public bool? AllowDefaultSecurityAssociationParameters { get; set; }
    
        /// <summary>
        /// Gets or sets always on configuration.
        /// AlwaysOn Configuration
        /// </summary>
        [JsonPropertyName("alwaysOnConfiguration")]
        public AppleVpnAlwaysOnConfiguration AlwaysOnConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets child security association parameters.
        /// Child Security Association Parameters
        /// </summary>
        [JsonPropertyName("childSecurityAssociationParameters")]
        public IosVpnSecurityAssociationParameters ChildSecurityAssociationParameters { get; set; }
    
        /// <summary>
        /// Gets or sets client authentication type.
        /// Type of Client Authentication the VPN client will use. Possible values are: userAuthentication, deviceAuthentication.
        /// </summary>
        [JsonPropertyName("clientAuthenticationType")]
        public VpnClientAuthenticationType? ClientAuthenticationType { get; set; }
    
        /// <summary>
        /// Gets or sets dead peer detection rate.
        /// Determine how often to check if a peer connection is still active. . Possible values are: medium, none, low, high.
        /// </summary>
        [JsonPropertyName("deadPeerDetectionRate")]
        public VpnDeadPeerDetectionRate? DeadPeerDetectionRate { get; set; }
    
        /// <summary>
        /// Gets or sets disable mobility and multihoming.
        /// Disable MOBIKE
        /// </summary>
        [JsonPropertyName("disableMobilityAndMultihoming")]
        public bool? DisableMobilityAndMultihoming { get; set; }
    
        /// <summary>
        /// Gets or sets disable redirect.
        /// Disable Redirect
        /// </summary>
        [JsonPropertyName("disableRedirect")]
        public bool? DisableRedirect { get; set; }
    
        /// <summary>
        /// Gets or sets enable always on configuration.
        /// Determines if Always on VPN is enabled
        /// </summary>
        [JsonPropertyName("enableAlwaysOnConfiguration")]
        public bool? EnableAlwaysOnConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets enable certificate revocation check.
        /// Enables a best-effort revocation check; server response timeouts will not cause it to fail
        /// </summary>
        [JsonPropertyName("enableCertificateRevocationCheck")]
        public bool? EnableCertificateRevocationCheck { get; set; }
    
        /// <summary>
        /// Gets or sets enable eap.
        /// Enables EAP only authentication
        /// </summary>
        [JsonPropertyName("enableEAP")]
        public bool? EnableEAP { get; set; }
    
        /// <summary>
        /// Gets or sets enable perfect forward secrecy.
        /// Enable Perfect Forward Secrecy (PFS).
        /// </summary>
        [JsonPropertyName("enablePerfectForwardSecrecy")]
        public bool? EnablePerfectForwardSecrecy { get; set; }
    
        /// <summary>
        /// Gets or sets enable use internal subnet attributes.
        /// Enable Use Internal Subnet Attributes.
        /// </summary>
        [JsonPropertyName("enableUseInternalSubnetAttributes")]
        public bool? EnableUseInternalSubnetAttributes { get; set; }
    
        /// <summary>
        /// Gets or sets local identifier.
        /// Method of identifying the client that is trying to connect via VPN. . Possible values are: deviceFQDN, empty, clientCertificateSubjectName.
        /// </summary>
        [JsonPropertyName("localIdentifier")]
        public VpnLocalIdentifier? LocalIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets mtu size in bytes.
        /// Maximum transmission unit. Valid values 1280 to 1400
        /// </summary>
        [JsonPropertyName("mtuSizeInBytes")]
        public Int32? MtuSizeInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets remote identifier.
        /// Address of the IKEv2 server. Must be a FQDN, UserFQDN, network address, or ASN1DN
        /// </summary>
        [JsonPropertyName("remoteIdentifier")]
        public string RemoteIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets security association parameters.
        /// Security Association Parameters
        /// </summary>
        [JsonPropertyName("securityAssociationParameters")]
        public IosVpnSecurityAssociationParameters SecurityAssociationParameters { get; set; }
    
        /// <summary>
        /// Gets or sets server certificate common name.
        /// Common name of the IKEv2 Server Certificate used in Server Authentication
        /// </summary>
        [JsonPropertyName("serverCertificateCommonName")]
        public string ServerCertificateCommonName { get; set; }
    
        /// <summary>
        /// Gets or sets server certificate issuer common name.
        /// Issuer Common name of the IKEv2 Server Certificate issuer used in Authentication
        /// </summary>
        [JsonPropertyName("serverCertificateIssuerCommonName")]
        public string ServerCertificateIssuerCommonName { get; set; }
    
        /// <summary>
        /// Gets or sets server certificate type.
        /// The type of certificate the VPN server will present to the VPN client for authentication. Possible values are: rsa, ecdsa256, ecdsa384, ecdsa521.
        /// </summary>
        [JsonPropertyName("serverCertificateType")]
        public VpnServerCertificateType? ServerCertificateType { get; set; }
    
        /// <summary>
        /// Gets or sets shared secret.
        /// Used when Shared Secret Authentication is selected
        /// </summary>
        [JsonPropertyName("sharedSecret")]
        public string SharedSecret { get; set; }
    
        /// <summary>
        /// Gets or sets tls maximum version.
        /// The maximum TLS version to be used with EAP-TLS authentication
        /// </summary>
        [JsonPropertyName("tlsMaximumVersion")]
        public string TlsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets tls minimum version.
        /// The minimum TLS version to be used with EAP-TLS authentication
        /// </summary>
        [JsonPropertyName("tlsMinimumVersion")]
        public string TlsMinimumVersion { get; set; }
    
    }
}


// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type NetworkInterface.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<NetworkInterface>))]
    public partial class NetworkInterface
    {

        /// <summary>
        /// Gets or sets description.
        /// Description of the NIC (e.g. Ethernet adapter, Wireless LAN adapter Local Area Connection &amp;lt;#&amp;gt;, etc.).
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets ipV4Address.
        /// Last IPv4 address associated with this NIC.
        /// </summary>
        [JsonPropertyName("ipV4Address")]
        public string IpV4Address { get; set; }
    
        /// <summary>
        /// Gets or sets ipV6Address.
        /// Last Public (aka global) IPv6 address associated with this NIC.
        /// </summary>
        [JsonPropertyName("ipV6Address")]
        public string IpV6Address { get; set; }
    
        /// <summary>
        /// Gets or sets localIpV6Address.
        /// Last local (link-local or site-local) IPv6 address associated with this NIC.
        /// </summary>
        [JsonPropertyName("localIpV6Address")]
        public string LocalIpV6Address { get; set; }
    
        /// <summary>
        /// Gets or sets macAddress.
        /// MAC address of the NIC on this host.
        /// </summary>
        [JsonPropertyName("macAddress")]
        public string MacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}

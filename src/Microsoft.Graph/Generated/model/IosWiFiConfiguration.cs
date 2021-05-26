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
    /// The type Ios Wi Fi Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosWiFiConfiguration>))]
    public partial class IosWiFiConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The IosWiFiConfiguration constructor
        ///</summary>
        public IosWiFiConfiguration()
        {
            this.ODataType = "microsoft.graph.iosWiFiConfiguration";
        }
    
        /// <summary>
        /// Gets or sets connect automatically.
        /// Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.
        /// </summary>
        [JsonPropertyName("connectAutomatically")]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// Connect when the network is not broadcasting its name (SSID). When set to true, this profile forces the device to connect to a network that doesn't broadcast its SSID to all devices.
        /// </summary>
        [JsonPropertyName("connectWhenNetworkNameIsHidden")]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets disable mac address randomization.
        /// If set to true, forces devices connecting using this Wi-Fi profile to present their actual Wi-Fi MAC address instead of a random MAC address. Applies to iOS 14 and later.
        /// </summary>
        [JsonPropertyName("disableMacAddressRandomization")]
        public bool? DisableMacAddressRandomization { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Network Name
        /// </summary>
        [JsonPropertyName("networkName")]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets pre shared key.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonPropertyName("preSharedKey")]
        public string PreSharedKey { get; set; }
    
        /// <summary>
        /// Gets or sets proxy automatic configuration url.
        /// URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.
        /// </summary>
        [JsonPropertyName("proxyAutomaticConfigurationUrl")]
        public string ProxyAutomaticConfigurationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual address.
        /// IP Address or DNS hostname of the proxy server when manual configuration is selected.
        /// </summary>
        [JsonPropertyName("proxyManualAddress")]
        public string ProxyManualAddress { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual port.
        /// Port of the proxy server when manual configuration is selected.
        /// </summary>
        [JsonPropertyName("proxyManualPort")]
        public Int32? ProxyManualPort { get; set; }
    
        /// <summary>
        /// Gets or sets proxy settings.
        /// Proxy Type for this Wi-Fi connection. Possible values are: none, manual, automatic.
        /// </summary>
        [JsonPropertyName("proxySettings")]
        public WiFiProxySetting? ProxySettings { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// This is the name of the Wi-Fi network that is broadcast to all devices.
        /// </summary>
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi security type.
        /// Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.
        /// </summary>
        [JsonPropertyName("wiFiSecurityType")]
        public WiFiSecurityType? WiFiSecurityType { get; set; }
    
    }
}


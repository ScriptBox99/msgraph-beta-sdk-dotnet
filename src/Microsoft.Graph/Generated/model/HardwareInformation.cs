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
    /// The type HardwareInformation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<HardwareInformation>))]
    public partial class HardwareInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareInformation"/> class.
        /// </summary>
        public HardwareInformation()
        {
            this.ODataType = "microsoft.graph.hardwareInformation";
        }

        /// <summary>
        /// Gets or sets batteryChargeCycles.
        /// The number of charge cycles the device’s current battery has gone through. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("batteryChargeCycles")]
        public Int32? BatteryChargeCycles { get; set; }
    
        /// <summary>
        /// Gets or sets batteryHealthPercentage.
        /// The device’s current battery’s health percentage. Valid values 0 to 100
        /// </summary>
        [JsonPropertyName("batteryHealthPercentage")]
        public Int32? BatteryHealthPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets batterySerialNumber.
        /// The serial number of the device’s current battery
        /// </summary>
        [JsonPropertyName("batterySerialNumber")]
        public string BatterySerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets cellularTechnology.
        /// Cellular technology of the device
        /// </summary>
        [JsonPropertyName("cellularTechnology")]
        public string CellularTechnology { get; set; }
    
        /// <summary>
        /// Gets or sets deviceFullQualifiedDomainName.
        /// Returns the fully qualified domain name of the device (if any). If the device is not domain-joined, it returns an empty string.
        /// </summary>
        [JsonPropertyName("deviceFullQualifiedDomainName")]
        public string DeviceFullQualifiedDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets deviceGuardLocalSystemAuthorityCredentialGuardState.
        /// Local System Authority (LSA) credential guard status. . Possible values are: running, rebootRequired, notLicensed, notConfigured, virtualizationBasedSecurityNotRunning.
        /// </summary>
        [JsonPropertyName("deviceGuardLocalSystemAuthorityCredentialGuardState")]
        public DeviceGuardLocalSystemAuthorityCredentialGuardState? DeviceGuardLocalSystemAuthorityCredentialGuardState { get; set; }
    
        /// <summary>
        /// Gets or sets deviceGuardVirtualizationBasedSecurityHardwareRequirementState.
        /// Virtualization-based security hardware requirement status. Possible values are: meetHardwareRequirements, secureBootRequired, dmaProtectionRequired, hyperVNotSupportedForGuestVM, hyperVNotAvailable.
        /// </summary>
        [JsonPropertyName("deviceGuardVirtualizationBasedSecurityHardwareRequirementState")]
        public DeviceGuardVirtualizationBasedSecurityHardwareRequirementState? DeviceGuardVirtualizationBasedSecurityHardwareRequirementState { get; set; }
    
        /// <summary>
        /// Gets or sets deviceGuardVirtualizationBasedSecurityState.
        /// Virtualization-based security status. . Possible values are: running, rebootRequired, require64BitArchitecture, notLicensed, notConfigured, doesNotMeetHardwareRequirements, other.
        /// </summary>
        [JsonPropertyName("deviceGuardVirtualizationBasedSecurityState")]
        public DeviceGuardVirtualizationBasedSecurityState? DeviceGuardVirtualizationBasedSecurityState { get; set; }
    
        /// <summary>
        /// Gets or sets esimIdentifier.
        /// eSIM identifier
        /// </summary>
        [JsonPropertyName("esimIdentifier")]
        public string EsimIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets freeStorageSpace.
        /// Free storage space of the device.
        /// </summary>
        [JsonPropertyName("freeStorageSpace")]
        public Int64? FreeStorageSpace { get; set; }
    
        /// <summary>
        /// Gets or sets imei.
        /// IMEI
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }
    
        /// <summary>
        /// Gets or sets ipAddressV4.
        /// IPAddressV4
        /// </summary>
        [JsonPropertyName("ipAddressV4")]
        public string IpAddressV4 { get; set; }
    
        /// <summary>
        /// Gets or sets isEncrypted.
        /// Encryption status of the device
        /// </summary>
        [JsonPropertyName("isEncrypted")]
        public bool? IsEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets isSharedDevice.
        /// Shared iPad
        /// </summary>
        [JsonPropertyName("isSharedDevice")]
        public bool? IsSharedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets isSupervised.
        /// Supervised mode of the device
        /// </summary>
        [JsonPropertyName("isSupervised")]
        public bool? IsSupervised { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Manufacturer of the device
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets meid.
        /// MEID
        /// </summary>
        [JsonPropertyName("meid")]
        public string Meid { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model of the device
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemEdition.
        /// String that specifies the OS edition.
        /// </summary>
        [JsonPropertyName("operatingSystemEdition")]
        public string OperatingSystemEdition { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemLanguage.
        /// Operating system language of the device
        /// </summary>
        [JsonPropertyName("operatingSystemLanguage")]
        public string OperatingSystemLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemProductType.
        /// Int that specifies the Windows Operating System ProductType. More details here https://go.microsoft.com/fwlink/?linkid=2126950. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("operatingSystemProductType")]
        public Int32? OperatingSystemProductType { get; set; }
    
        /// <summary>
        /// Gets or sets osBuildNumber.
        /// Operating System Build Number on Android device
        /// </summary>
        [JsonPropertyName("osBuildNumber")]
        public string OsBuildNumber { get; set; }
    
        /// <summary>
        /// Gets or sets phoneNumber.
        /// Phone number of the device
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets serialNumber.
        /// Serial number.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sharedDeviceCachedUsers.
        /// All users on the shared Apple device
        /// </summary>
        [JsonPropertyName("sharedDeviceCachedUsers")]
        public IEnumerable<SharedAppleDeviceUser> SharedDeviceCachedUsers { get; set; }
    
        /// <summary>
        /// Gets or sets subnetAddress.
        /// SubnetAddress
        /// </summary>
        [JsonPropertyName("subnetAddress")]
        public string SubnetAddress { get; set; }
    
        /// <summary>
        /// Gets or sets subscriberCarrier.
        /// Subscriber carrier of the device
        /// </summary>
        [JsonPropertyName("subscriberCarrier")]
        public string SubscriberCarrier { get; set; }
    
        /// <summary>
        /// Gets or sets totalStorageSpace.
        /// Total storage space of the device.
        /// </summary>
        [JsonPropertyName("totalStorageSpace")]
        public Int64? TotalStorageSpace { get; set; }
    
        /// <summary>
        /// Gets or sets tpmSpecificationVersion.
        /// String that specifies the specification version.
        /// </summary>
        [JsonPropertyName("tpmSpecificationVersion")]
        public string TpmSpecificationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets wifiMac.
        /// WiFi MAC address of the device
        /// </summary>
        [JsonPropertyName("wifiMac")]
        public string WifiMac { get; set; }
    
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

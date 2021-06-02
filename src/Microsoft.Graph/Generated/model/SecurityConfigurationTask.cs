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
    /// The type Security Configuration Task.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SecurityConfigurationTask>))]
    public partial class SecurityConfigurationTask : DeviceAppManagementTask
    {
    
        ///<summary>
        /// The SecurityConfigurationTask constructor
        ///</summary>
        public SecurityConfigurationTask()
        {
            this.ODataType = "microsoft.graph.securityConfigurationTask";
        }

        /// <summary>
        /// Gets or sets applicable platform.
        /// The applicable platform. Possible values are: unknown, macOS, windows10AndLater, windows10AndWindowsServer.
        /// </summary>
        [JsonPropertyName("applicablePlatform")]
        public EndpointSecurityConfigurationApplicablePlatform? ApplicablePlatform { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint security policy.
        /// The endpoint security policy type. Possible values are: unknown, antivirus, diskEncryption, firewall, endpointDetectionAndResponse, attackSurfaceReduction, accountProtection.
        /// </summary>
        [JsonPropertyName("endpointSecurityPolicy")]
        public EndpointSecurityConfigurationType? EndpointSecurityPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint security policy profile.
        /// The endpoint security policy profile. Possible values are: unknown, antivirus, windowsSecurity, bitLocker, fileVault, firewall, firewallRules, endpointDetectionAndResponse, deviceControl, appAndBrowserIsolation, exploitProtection, webProtection, applicationControl, attackSurfaceReductionRules, accountProtection.
        /// </summary>
        [JsonPropertyName("endpointSecurityPolicyProfile")]
        public EndpointSecurityConfigurationProfileType? EndpointSecurityPolicyProfile { get; set; }
    
        /// <summary>
        /// Gets or sets insights.
        /// Information about the mitigation.
        /// </summary>
        [JsonPropertyName("insights")]
        public string Insights { get; set; }
    
        /// <summary>
        /// Gets or sets intended settings.
        /// The intended settings and their values.
        /// </summary>
        [JsonPropertyName("intendedSettings")]
        public IEnumerable<KeyValuePair> IntendedSettings { get; set; }
    
        /// <summary>
        /// Gets or sets managed device count.
        /// The number of vulnerable devices.
        /// </summary>
        [JsonPropertyName("managedDeviceCount")]
        public Int32? ManagedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The vulnerable managed devices.
        /// </summary>
        [JsonPropertyName("managedDevices")]
        public ISecurityConfigurationTaskManagedDevicesCollectionPage ManagedDevices { get; set; }

        /// <summary>
        /// Gets or sets managedDevicesNextLink.
        /// </summary>
        [JsonPropertyName("managedDevices@odata.nextLink")]
        public string ManagedDevicesNextLink { get; set; }
    
    }
}


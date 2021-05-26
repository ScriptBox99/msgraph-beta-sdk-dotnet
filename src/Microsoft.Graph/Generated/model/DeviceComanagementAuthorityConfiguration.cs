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
    /// The type Device Comanagement Authority Configuration.
    /// </summary>
    public partial class DeviceComanagementAuthorityConfiguration : DeviceEnrollmentConfiguration
    {
    
        ///<summary>
        /// The DeviceComanagementAuthorityConfiguration constructor
        ///</summary>
        public DeviceComanagementAuthorityConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceComanagementAuthorityConfiguration";
        }
    
        /// <summary>
        /// Gets or sets configuration manager agent command line argument.
        /// CoManagement Authority configuration ConfigurationManagerAgentCommandLineArgument
        /// </summary>
        [JsonPropertyName("configurationManagerAgentCommandLineArgument")]
        public string ConfigurationManagerAgentCommandLineArgument { get; set; }
    
        /// <summary>
        /// Gets or sets install configuration manager agent.
        /// CoManagement Authority configuration InstallConfigurationManagerAgent
        /// </summary>
        [JsonPropertyName("installConfigurationManagerAgent")]
        public bool? InstallConfigurationManagerAgent { get; set; }
    
        /// <summary>
        /// Gets or sets managed device authority.
        /// CoManagement Authority configuration ManagedDeviceAuthority
        /// </summary>
        [JsonPropertyName("managedDeviceAuthority")]
        public Int32? ManagedDeviceAuthority { get; set; }
    
    }
}


// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum CloudPcPartnerAgentInstallStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CloudPcPartnerAgentInstallStatus
    {
    
        /// <summary>
        /// Installed
        /// </summary>
        Installed = 0,
	
        /// <summary>
        /// Install Failed
        /// </summary>
        InstallFailed = 1,
	
        /// <summary>
        /// Installing
        /// </summary>
        Installing = 2,
	
        /// <summary>
        /// Uninstalling
        /// </summary>
        Uninstalling = 3,
	
        /// <summary>
        /// Uninstall Failed
        /// </summary>
        UninstallFailed = 4,
	
        /// <summary>
        /// Licensed
        /// </summary>
        Licensed = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}

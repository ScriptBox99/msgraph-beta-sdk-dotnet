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
    /// The enum MacOSSoftwareUpdateBehavior.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSSoftwareUpdateBehavior
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Default
        /// </summary>
        Default = 1,
	
        /// <summary>
        /// Download Only
        /// </summary>
        DownloadOnly = 2,
	
        /// <summary>
        /// Install ASAP
        /// </summary>
        InstallASAP = 3,
	
        /// <summary>
        /// Notify Only
        /// </summary>
        NotifyOnly = 4,
	
        /// <summary>
        /// Install Later
        /// </summary>
        InstallLater = 5,
	
    }
}

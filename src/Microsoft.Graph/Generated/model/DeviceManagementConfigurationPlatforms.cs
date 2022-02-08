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
    /// The enum DeviceManagementConfigurationPlatforms.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum DeviceManagementConfigurationPlatforms
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Android
        /// </summary>
        Android = 1,
	
        /// <summary>
        /// IOS
        /// </summary>
        IOS = 4,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 8,
	
        /// <summary>
        /// Windows10X
        /// </summary>
        Windows10X = 16,
	
        /// <summary>
        /// Windows10
        /// </summary>
        Windows10 = 32,
	
        /// <summary>
        /// Linux
        /// </summary>
        Linux = 128,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 1073741824,
	
    }
}

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
    /// The enum AospWifiSecurityType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AospWifiSecurityType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Wpa
        /// </summary>
        Wpa = 1,
	
        /// <summary>
        /// Wep
        /// </summary>
        Wep = 2,
	
    }
}

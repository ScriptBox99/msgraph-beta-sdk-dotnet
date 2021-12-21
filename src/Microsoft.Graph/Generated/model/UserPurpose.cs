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
    /// The enum UserPurpose.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserPurpose
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// User
        /// </summary>
        User = 1,
	
        /// <summary>
        /// Linked
        /// </summary>
        Linked = 2,
	
        /// <summary>
        /// Shared
        /// </summary>
        Shared = 3,
	
        /// <summary>
        /// Room
        /// </summary>
        Room = 4,
	
        /// <summary>
        /// Equipment
        /// </summary>
        Equipment = 5,
	
        /// <summary>
        /// Others
        /// </summary>
        Others = 6,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}

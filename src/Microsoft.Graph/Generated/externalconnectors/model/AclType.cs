// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.ExternalConnectors
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AclType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AclType
    {
    
        /// <summary>
        /// User
        /// </summary>
        User = 1,
	
        /// <summary>
        /// Group
        /// </summary>
        Group = 2,
	
        /// <summary>
        /// Everyone
        /// </summary>
        Everyone = 3,
	
        /// <summary>
        /// Everyone Except Guests
        /// </summary>
        EveryoneExceptGuests = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}

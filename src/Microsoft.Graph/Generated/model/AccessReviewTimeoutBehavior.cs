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
    /// The enum AccessReviewTimeoutBehavior.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccessReviewTimeoutBehavior
    {
    
        /// <summary>
        /// Keep Access
        /// </summary>
        KeepAccess = 0,
	
        /// <summary>
        /// Remove Access
        /// </summary>
        RemoveAccess = 1,
	
        /// <summary>
        /// Accept Access Recommendation
        /// </summary>
        AcceptAccessRecommendation = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 99,
	
    }
}

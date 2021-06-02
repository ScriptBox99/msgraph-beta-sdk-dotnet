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
    /// The enum ServiceUpdateCategory.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ServiceUpdateCategory
    {
    
        /// <summary>
        /// Prevent Or Fix Issue
        /// </summary>
        PreventOrFixIssue = 1,
	
        /// <summary>
        /// Plan For Change
        /// </summary>
        PlanForChange = 2,
	
        /// <summary>
        /// Stay Informed
        /// </summary>
        StayInformed = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}

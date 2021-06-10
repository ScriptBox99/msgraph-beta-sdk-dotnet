// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum CloudPcAuditActivityOperationType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CloudPcAuditActivityOperationType
    {
    
        /// <summary>
        /// Create
        /// </summary>
        Create = 0,
	
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 1,
	
        /// <summary>
        /// Patch
        /// </summary>
        Patch = 2,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 999,
	
    }
}

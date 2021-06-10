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
    /// The enum CloudPcAuditActivityResult.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CloudPcAuditActivityResult
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Client Error
        /// </summary>
        ClientError = 1,
	
        /// <summary>
        /// Failure
        /// </summary>
        Failure = 2,
	
        /// <summary>
        /// Timeout
        /// </summary>
        Timeout = 3,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 999,
	
    }
}

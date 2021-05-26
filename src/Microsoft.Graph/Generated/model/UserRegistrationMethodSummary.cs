// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserRegistrationMethodSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserRegistrationMethodSummary>))]
    public partial class UserRegistrationMethodSummary
    {

        /// <summary>
        /// Gets or sets totalUserCount.
        /// Total number of users in the tenant.
        /// </summary>
        [JsonPropertyName("totalUserCount")]
        public Int64? TotalUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets userRegistrationMethodCounts.
        /// Number of users registered for each authentication method.
        /// </summary>
        [JsonPropertyName("userRegistrationMethodCounts")]
        public IEnumerable<UserRegistrationMethodCount> UserRegistrationMethodCounts { get; set; }
    
        /// <summary>
        /// Gets or sets userRoles.
        /// User role type. Possible values are: all, privilegedAdmin, admin, user.
        /// </summary>
        [JsonPropertyName("userRoles")]
        public IncludedUserRoles? UserRoles { get; set; }
    
        /// <summary>
        /// Gets or sets userTypes.
        /// User type. Possible values are: all, member, guest.
        /// </summary>
        [JsonPropertyName("userTypes")]
        public IncludedUserTypes? UserTypes { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
